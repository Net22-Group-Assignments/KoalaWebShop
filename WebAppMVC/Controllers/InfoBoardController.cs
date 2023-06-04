using CommandLine;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebAppMVC.Repository.IRepository;
using WebAppMVC.Data;
using WebAppMVC.Models;
using WebAppMVC.Models.ViewModels;
using WebAppMVC.Services;
using Microsoft.AspNetCore.Authorization;

namespace WebAppMVC.Controllers
{
    public class InfoBoardController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<KoalaCustomer> _customer;
        private readonly Order _order;
        private readonly OrderItem _orderItem;
        private readonly Product _products;


        public InfoBoardController(ApplicationDbContext context, UserManager<KoalaCustomer> customer, Product products, Order order, OrderItem orderItem)
        {
            _context = context;
            _customer = customer;
            _products = products;
            _order = order;
            _orderItem = orderItem;

        }
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            

            var InfoBoardVC = new InfoBoardViewModel()
            {
                Products = await _context.Products.ToListAsync(),
                Orders = await _context.Orders.ToListAsync(),
                Items = await _context.OrderItems.ToListAsync(),
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

