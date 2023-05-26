using Microsoft.AspNetCore.Mvc;

namespace WebAppMVC.Controllers
{
    public class CartController : Controller
    {
        //Instansiera AddToCart
        //Get
        public IActionResult ShowCart()
        {

            return View();
        }
        //Post
        [HttpPost]
        public IActionResult AddToCart(int id)
        {
            //Console.WriteLine("You got here");
            return View();
        }
    }
}
