using CommandLine;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebAppMVC.Data;
using WebAppMVC.Models;

namespace WebAppMVC.Controllers
{
    public class CartController : Controller
    {
        private readonly IHttpContextAccessor _contextAccessor;
        private readonly UserManager<KoalaCustomer> _koalaUserManager;
        private readonly ApplicationDbContext _context;
        private readonly SetCart _setcart;
        public CartController(IHttpContextAccessor contextAccessor, UserManager<KoalaCustomer> koalaUserManager, ApplicationDbContext applicationDbContext, SetCart setcart)
        {
            _contextAccessor = contextAccessor;
            _koalaUserManager = koalaUserManager;
            _context = applicationDbContext;
            _setcart = setcart;
        }
        //Instansiera AddToCart
        //Get
        public IActionResult Index()
        {
            var user = _koalaUserManager.GetUserAsync(User);
            if (user == null)
            {
                return NotFound("User was not found");
            }
            
            var items = _setcart.GetAllCartItems();
            _setcart.CartItems = items;
            return View(_setcart);
        }
        public ActionResult AddToCart(int id)
        {
            var selectProduct = GetProductById(id);
            if (selectProduct != null)
            {
                _setcart.AddToCart(selectProduct, 1);
            }
            return  RedirectToAction("index", "Home");
        }
        public IActionResult RemoveFromCart(int id)
        {
            var selectProduct = GetProductById(id); 
            if (selectProduct != null) 
            {
                _setcart.RemoveFromCart(selectProduct);
            }
            return RedirectToAction("Index");
        }
        public IActionResult ReduceQuantity(int id)
        {
            var selectProduct = GetProductById(id);
            if (selectProduct != null) 
            {
                _setcart.ReduceQuantity(selectProduct);
            }
            return RedirectToAction("Index");
        }
        public IActionResult IncreaseQuantity(int id)
        {
            var selectProduct = GetProductById(id);
            if (selectProduct !=null)
            {
                _setcart.IncreaseQuantity(selectProduct);
            }
            return RedirectToAction("Index");
        }
        public IActionResult ClearCart()
        {
            _setcart.ClearCart();
            return RedirectToAction("Index");
        }
        public Product GetProductById(int id)
        {
            return _context.Products.FirstOrDefault(p => p.Id == id);
        }
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
