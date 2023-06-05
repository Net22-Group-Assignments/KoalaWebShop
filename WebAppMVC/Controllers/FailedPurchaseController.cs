using Microsoft.AspNetCore.Mvc;

namespace WebAppMVC.Controllers
{
    public class FailedPurchaseController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
