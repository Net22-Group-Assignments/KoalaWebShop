using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using WebAppMVC.Data;
using WebAppMVC.Models;
using WebAppMVC.Models.ViewModels;

namespace WebAppMVC.Controllers
{
    public class CreditController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<KoalaCustomer> _userManager;

		public CreditController(ApplicationDbContext context, UserManager<KoalaCustomer> userManager)
        {
            _context = context;
            _userManager = userManager;
		}
        public async Task<ActionResult> Index()
        {
            var creditViewModels = new CreditViewModel();

            var customer = await _userManager.FindByNameAsync(User.Identity.Name);

            var credits = customer.Credits;

            creditViewModels.Credits = credits;

            return View(creditViewModels);
        }
    }
}
