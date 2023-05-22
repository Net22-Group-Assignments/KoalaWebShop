using Microsoft.AspNetCore.Mvc;
using WebAppMVC.Data;
using WebAppMVC.Models;

namespace WebAppMVC.Controllers
{
    [Area("KoalaCustomer")]
    public class OrderController : Controller
    {
        private ApplicationDbContext _db;
        public OrderController(ApplicationDbContext db)
        {
            _db = db;
        }
        //Get Checkout actionmethod
        public IActionResult Checkout()
        {
            return View();
        }
        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public async Task<IActionResult> CheckOut(Order anOrder)
        {
            List<Product> products = new List<Product>();
            if (products != null)
            {
                foreach (var product in products)
                {
                    Cart cart = new Cart();
                    cart.Products = product.ProductId;
                    anOrder.cartId.Add(cart);
                }
            }
            return View();
        }

    }
}
