using Microsoft.AspNetCore.Mvc;

namespace WebAppMVC.Controllers
{
    public class NothingInCart : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
