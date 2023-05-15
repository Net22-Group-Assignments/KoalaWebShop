using Microsoft.AspNetCore.Mvc;

namespace WebAppAPI.Controllers
{
    public class UserApiController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
