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
                               join pr in _context.ProductReviews on p.ProductId equals pr.FK_ProductId
                               where p.ProductId == pr.FK_ProductId
                               select new
                               {
                                   Title = p.Title,
                                   Price = p.Price,
                                   Discount = p.Discount,
                                   Summary = p.Summary,
                                   Rating = pr.Rating,
                                   Content = pr.Content
                               }).ToListAsync();
            foreach (var item in items)
            {
                ProductViewModel listitem = new ProductViewModel();
                listitem.Title = item.Title;
                listitem.Price = item.Price;
                listitem.Discount = item.Discount;
                listitem.Summary = item.Summary;
                listitem.Rating = item.Rating;
                listitem.Content = item.Content;
                list.Add(listitem);
            }
            return View(list);
        }

        // Get all products matching search
        public async Task<IActionResult> GetAllProducts(string searchString)
        {
            List<ProductViewModel> list = new List<ProductViewModel>();

            var items = await (from p in _context.Products
                               join pr in _context.ProductReviews on p.ProductId equals pr.FK_ProductId
                               where p.Title.Contains(searchString)
                               select new
                               {
                                   Title = p.Title,
                                   Price = p.Price,
                                   Discount = p.Discount,
                                   Summary = p.Summary,
                                   Rating = pr.Rating,
                                   Content = pr.Content
                               }).ToListAsync();
            foreach (var item in items)
            {
                ProductViewModel listitem = new ProductViewModel();
                listitem.Title = item.Title;
                listitem.Price = item.Price;
                listitem.Discount = item.Discount;
                listitem.Summary = item.Summary;
                listitem.Rating = item.Rating;
                listitem.Content = item.Content;
                list.Add(listitem);
            }
            return View(list);
        }

        // GET: ProductViewModels
        public async Task<IActionResult> Index()
        {
            return View(await _context.ProductViewModel.ToListAsync());
        }

        // GET: ProductViewModels/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.ProductViewModel == null)
            {
                return NotFound();
            }

            var productViewModel = await _context.ProductViewModel
                .FirstOrDefaultAsync(m => m.ProductViewModelId == id);
            if (productViewModel == null)
            {
                return NotFound();
            }

            return View(productViewModel);
        }

        // GET: ProductViewModels/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: ProductViewModels/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ProductViewModelId,Title,Price,Discount,Summary,Rating,Content")] ProductViewModel productViewModel)
        {
            if (ModelState.IsValid)
            {
                _context.Add(productViewModel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(productViewModel);
        }

        // GET: ProductViewModels/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.ProductViewModel == null)
            {
                return NotFound();
            }

            var productViewModel = await _context.ProductViewModel.FindAsync(id);
            if (productViewModel == null)
            {
                return NotFound();
            }
            return View(productViewModel);
        }

        // POST: ProductViewModels/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ProductViewModelId,Title,Price,Discount,Summary,Rating,Content")] ProductViewModel productViewModel)
        {
            if (id != productViewModel.ProductViewModelId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(productViewModel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProductViewModelExists(productViewModel.ProductViewModelId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(productViewModel);
        }

        // GET: ProductViewModels/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.ProductViewModel == null)
            {
                return NotFound();
            }

            var productViewModel = await _context.ProductViewModel
                .FirstOrDefaultAsync(m => m.ProductViewModelId == id);
            if (productViewModel == null)
            {
                return NotFound();
            }

            return View(productViewModel);
        }

        // POST: ProductViewModels/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.ProductViewModel == null)
            {
                return Problem("Entity set 'ApplicationDbContext.ProductViewModel'  is null.");
            }
            var productViewModel = await _context.ProductViewModel.FindAsync(id);
            if (productViewModel != null)
            {
                _context.ProductViewModel.Remove(productViewModel);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ProductViewModelExists(int id)
        {
            return _context.ProductViewModel.Any(e => e.ProductViewModelId == id);
        }
    }
}
