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


        // GET: ProductViewModels
        // Get all products

        public async Task<IActionResult> GetAllProducts()
        {
            List<ProductViewModel> list = new List<ProductViewModel>();

            var items = await (from p in _context.Products
                               join r in _context.Reviews on p.ProductId equals r.FK_ProductId
                               join c in _context.Categories on p.FkCategory equals c.CategoryId
                               where p.ProductId == r.FK_ProductId
                               select new
                               {
                                   Title = p.Title,
                                   Price = p.Price,
                                   Content = r.Content
                               }).ToListAsync();
            foreach (var item in items)
            {
                ProductViewModel listitem = new ProductViewModel();
                listitem.Title = item.Title;
                listitem.Price = item.Price;
                listitem.Content = item.Content;
                list.Add(listitem);
            }
            return View(list);
        }

        // Get all products matching search
        public async Task<IActionResult> GetAllProductsBySearch(string searchString)
        {
            List<ProductViewModel> list = new List<ProductViewModel>();

            var items = await (from p in _context.Products
                               join r in _context.Reviews on p.ProductId equals r.FK_ProductId
							   join c in _context.Categories on p.FkCategory equals c.CategoryId
							   where p.Title.Contains(searchString)
                               select new
                               {
                                   Title = p.Title,
                                   Price = p.Price,
                                   Content = r.Content
                               }).ToListAsync();
            foreach (var item in items)
            {
                ProductViewModel listitem = new ProductViewModel();
                listitem.Title = item.Title;
                listitem.Price = item.Price;
                listitem.Content = item.Content;
                list.Add(listitem);
            }
            return View(list);
        }
    }
}
