using CommandLine;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebAppMVC.Data;
using WebAppMVC.Models;
using WebAppMVC.Services;

namespace WebAppMVC.Controllers
{
    public class CartController : Controller
    {
        private readonly CartService _cartService;
        private readonly UserManager<KoalaCustomer> _userManager;

        public CartController(CartService cartService, UserManager<KoalaCustomer> userManager)
        {
            _cartService = cartService;
            _userManager = userManager;
        }

        //Instansiera AddToCart
        //Get
        public async Task<IActionResult> Index()
        {
            var customer = await _userManager.FindByNameAsync(User.Identity.Name);
            var items = await _cartService.GetAllCartItems(customer);

            return View(items);
        }

        [HttpPost]
        public async Task<ActionResult> AddToCart(int id)
        {
            var customer = await _userManager.FindByNameAsync(User.Identity.Name);
            await _cartService.AddToCart(id, 1, customer);

            return RedirectToAction("index", "Home");
        }

        [HttpPost]
        public async Task<IActionResult> RemoveFromCart(int id)
        {
            var customer = await _userManager.FindByNameAsync(User.Identity.Name);

            await _cartService.RemoveFromCart(id, customer);

            return RedirectToAction("Index", "Cart");
        }

        [HttpPost]
        public async Task<IActionResult> ReduceQuantity(int id)
        {
            var customer = await _userManager.FindByNameAsync(User.Identity.Name);

            await _cartService.ReduceQuantity(id, customer);

            return RedirectToAction("Index", "Cart");
        }
        //
        // public IActionResult IncreaseQuantity(int id)
        // {
        //     var selectProduct = GetProductById(id);
        //     if (selectProduct != null)
        //     {
        //         _setcart.IncreaseQuantity(selectProduct);
        //     }
        //     return RedirectToAction("Index");
        // }
        //
        // public IActionResult ClearCart()
        // {
        //     _setcart.ClearCart();
        //     return RedirectToAction("Index");
        // }
        //
        // public Product GetProductById(int id)
        // {
        //     return _context.Products.FirstOrDefault(p => p.Id == id);
        // }
        //Post
        //[HttpPost]
        //public async Task<IActionResult> AddToCart(int id)
        //{
        //    //Cart cart = new Cart();
        //    //var user = await _koalaUserManager.GetUserAsync(User);
        //    //cart.Customer = user; //if logged in
        //    //_applicationDbContext.Add(cart);
        //    //await _applicationDbContext.SaveChangesAsync();
        //    return View();
        //}
    }
}

// add to cart check if customerId is already initialized then dont inject primaryKey for customer, else doo it. ->
