using Microsoft.AspNetCore.Mvc;

namespace WebAppMVC.Controllers
{
	public class CheckoutController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
