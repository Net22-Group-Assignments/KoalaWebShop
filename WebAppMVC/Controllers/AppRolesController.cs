using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using System.Runtime.CompilerServices;

namespace WebAppMVC.Controllers
{
	[Authorize(Roles ="Admin")]
	public class AppRolesController : Controller
	{
		private readonly RoleManager<IdentityRole<int>> _roleManager;
        public AppRolesController(RoleManager<IdentityRole<int>> roleManager)
        {
			_roleManager = roleManager;

		}
		// List of all the roles created by users
        public IActionResult Index()
		{
			var roles = _roleManager.Roles;

			return View(roles);
		}
		[HttpGet]
		public IActionResult Create()
		{
			return View();
		}
		[HttpPost]
		public async Task<IActionResult> Create(IdentityRole model)
		{
			if (!_roleManager.RoleExistsAsync(model.Name).GetAwaiter().GetResult())
			{
				_roleManager.CreateAsync(new IdentityRole<int>(model.Name)).GetAwaiter().GetResult();
			}
			return RedirectToAction("Index");
		}

	}
}
