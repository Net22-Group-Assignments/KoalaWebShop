using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WebAppMVC.Data;
using WebAppMVC.Models.ViewModels;

namespace WebAppMVC.Controllers
{
    public class ProductController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ProductController(ApplicationDbContext context)
        {
            _context = context;
        }


        //GET: ProductViewModels
        //Get all products

        public async Task<IActionResult> Index()
        {
            List<ProductViewModel> list = new List<ProductViewModel>();

            var items = await (from p in _context.Products
                               join oi in _context.OrderItems on p.Id equals oi.ProductId
                               join c in _context.Currencies on oi.CurrencyId equals c.CurrencyId
                               select new
                               {
                                   Title = p.Title,
                                   Price = p.Price,
                                   PriceUSD = p.Price * c.rates.USD,
                                   PriceEUR = p.Price * c.rates.EUR,
                                   Discount = p.Discount,
                                   Content = p.Content,
                                   Quantity = p.Quantity,
                                   ImgURL = p.ImgURL,
                               }).ToListAsync();

            foreach (var item in items)
            {
                ProductViewModel listitem = new ProductViewModel();
                listitem.Title = item.Title;
                listitem.Price = item.Price;
                listitem.PriceUSD = item.PriceUSD;
                listitem.PriceEUR = item.PriceEUR;
                listitem.Discount = item.Discount;
                listitem.Content = item.Content;
                listitem.Quantity = item.Quantity;
                listitem.ImgURL = item.ImgURL;
                list.Add(listitem);
            }
            return View(list);
        }
    }
}
