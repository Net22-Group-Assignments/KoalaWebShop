using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebAppMVC.Data;
using WebAppMVC.Models;
using WebAppMVC.Services;

namespace WebAppMVC.Controllers
{
    public class CheckoutController : Controller
    {
        private readonly CartService _cartService;
        private readonly UserManager<KoalaCustomer> _userManager;
        private readonly ApplicationDbContext _db;
        private int nullcheck = 0;
        public CheckoutController(CartService cartService, UserManager<KoalaCustomer> userManager, ApplicationDbContext db)
        {
            _cartService = cartService;
            _userManager = userManager;
            _db = db;
        }
        [HttpGet]
        public async Task<ActionResult> GetUserId()
        {
            ViewData["Message"] = "Woho  you got here";
            var customer = await _userManager.FindByNameAsync(User.Identity.Name);
            var items = await _cartService.GetAllCartItems(customer);

            if ( await CartOrderTransfer() == false)
            {
                if ( nullcheck == 0 )
                {
                    return RedirectToAction("Index", "ProductQuantity");
                }
                return RedirectToAction("Index", "FailedPurchase");
            }
            await CartOrderTransfer();

            return View(items);
        }

        public async Task<bool> CartOrderTransfer()
        {
            decimal Check = 0;;
            using var transactions = _db.Database.BeginTransaction();
            var customer = await _userManager.FindByNameAsync(User.Identity.Name);
            var items = await _cartService.GetAllCartItems(customer);
            if (items == null)
            {
                throw new Exception("Cart is empty");
            }
            foreach (var item in items)
            {
                 Check += item.Product.Price;
            }
            if (customer.Credits < Check)
            {

                return false;

            }
            foreach (var item in items)
            {
                 nullcheck = item.Product.Quantity;
            }
            if (nullcheck == 0)
            {
                return false;
            }
            foreach(var item in items)
            {
                item.Product.Quantity--;
            }
            foreach (var item in items)
            {
                customer.Credits -= Check;
            }
           

            var order = new Order
            {
                CustomerId = customer.Id,
                PlacementTime = DateTime.UtcNow,
                
            };
            _db.Orders.Add(order);
            _db.SaveChanges();
            foreach (var item in items)
            {
                var orderItem = new OrderItem
                {
                    ProductId = item.ProductId,
                    OrderId = order.Id,
                    Quantity = item.Quantity   
                };
                _db.OrderItems.Add(orderItem);
            }
            _db.SaveChanges();

            //RemoveCartDetails
            _db.CartItems.RemoveRange(items);
            _db.SaveChanges();
            transactions.Commit();

            ViewData["Success"] = "CartOrderTransferComplete";
            return true;
           
        }
        public async Task<Cart> GetCart(int userId)
        {
            var cart = await _db.Carts.FirstOrDefaultAsync(x => x.CustomerId == userId);
            return cart;
        }
    }
}
