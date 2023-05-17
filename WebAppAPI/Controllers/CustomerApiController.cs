using Microsoft.AspNetCore.Mvc;

namespace WebAppAPI.Controllers
{
    public class CustomerApiController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
