using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebAppMVC.Data;
using WebAppMVC.Models;
using WebAppMVC.Models.ViewModels;
using Microsoft.AspNetCore.Authorization;

namespace WebAppMVC.Controllers
{
    [Authorize(Roles = "Admin")]
    public class InfoBoardController : Controller
    {
        private readonly ApplicationDbContext _context;

        public InfoBoardController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var InfoBoardVC = new InfoBoardViewModel()
            {
                Products = await _context.Products.ToListAsync(),
                Orders = await _context.Orders.ToListAsync(),
                OrderItems = await _context.OrderItems.ToListAsync(),
                Customers = await _context.KoalaCustomers.ToListAsync()
            };
            if (InfoBoardVC == null)
            {
                throw new Exception("Something is wrong");
            }

            return View(InfoBoardVC);
        }
    }
}
