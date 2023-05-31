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
        private readonly ApplicationDbContext _context;

        public CheckoutController(CartService cartService, UserManager<KoalaCustomer> userManager, ApplicationDbContext context)
        {
            _cartService = cartService;
            _userManager = userManager;
            _context = context;
        }
        [HttpGet]
        public async Task<ActionResult> GetUserId()
        {
            ViewData["Message"] = "Woho  you got here";
            var customer = await _userManager.FindByNameAsync(User.Identity.Name);
            var items = await _cartService.GetAllCartItems(customer);
            return View(items);
        }
        public async Task<bool> CartOrderTransfer()
        {
            using var transactions = _context.Database.BeginTransaction();
            var userId = GetUserId();
            if (userId == null)
            {
                throw new Exception("User not logged in");

            }
            var customer = await _userManager.FindByNameAsync(User.Identity.Name);
            var items = await _cartService.GetAllCartItems(customer);



            return true;
        }
        public async Task<Cart> GetCart(int userId)
        {
            var cart = await _context.Carts.FirstOrDefaultAsync(x => x.CustomerId == userId);
            return cart;
        }

    }
}
