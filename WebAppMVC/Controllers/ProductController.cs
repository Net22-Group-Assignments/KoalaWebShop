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
        public async Task<IActionResult> Index()
        {
            Console.WriteLine(_context.Products.Dump());

            List<ProductViewModel> list = new List<ProductViewModel>();

            var rateUSD = _context.Currencies.Select(r => r.rates.USD).ToList();

            var rateEUR = _context.Currencies.Select(r => r.rates.EUR).ToList();

            var items = await (from p in _context.Products
                               select new
                               {
                                   title = p.Title,
                                   price = p.Price,
                                   PriceUSD = p.Price * rateUSD.FirstOrDefault(),
                                   PriceEUR = p.Price * rateEUR.FirstOrDefault(),
                                   discount = p.Discount,
                                   content = p.Content,
                                   quantity = p.Quantity,
                                   imgURL = p.ImgURL,
                               }).ToListAsync();

                foreach (var item in items)
                {
                    ProductViewModel listitem = new ProductViewModel();
                    listitem.Title = item.title;
                    listitem.Price = item.price;
                    listitem.PriceUSD = item.PriceUSD;
                    listitem.PriceEUR = item.PriceEUR;
                    listitem.Discount = item.discount;
                    listitem.Content = item.content;
                    listitem.Quantity = item.quantity;
                    listitem.ImgURL = item.imgURL;
                    list.Add(listitem);
                }
          
            return View(list);
        }
    }
}
