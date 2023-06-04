using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using AutoMapper;
using WebAppMVC.Data;
using WebAppMVC.Models;
using WebAppMVC.Models.ViewModels;
using WebAppMVC.Services;

namespace WebAppMVC.Controllers
{
    public class ProductController : Controller
    {
        private readonly ILogger<ProductController> _logger;
        private readonly ApplicationDbContext _db;
        private readonly ImageStorageService _imageStorage;
        private readonly ProductService _productService;
        private readonly IMapper _mapper;

        public ProductController(
            ILogger<ProductController> logger,
            ApplicationDbContext db,
            ImageStorageService imageStorage,
            IMapper mapper, ProductService productService)
        {
            _db = db;
            _imageStorage = imageStorage;
            _mapper = mapper;
            _productService = productService;
            _logger = logger;
        }

        public async Task<IActionResult> Index(string sortOrder, string searchString)
        {
            ViewData["NameSortParm"] = string.IsNullOrEmpty(sortOrder) ? "name_desc" : "";
            ViewData["CurrentFilter"] = searchString;
            var products = from p in _db.Products.Include(c => c.Category) select p;
            if (!string.IsNullOrEmpty(searchString))
            {
                products = products.Where(
                    p => p.Title.Contains(searchString) || p.Category.Title.Contains(searchString)
                );
            }
            return View(await products.AsNoTracking().ToListAsync());
        }

        // Get: Products/Create
        public async Task<IActionResult> Create()
        {
            var model = await _productService.CreateModifyProductViewModel();
            
            return View(model);
        }

        // POST: Products/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(
            [Bind("Title,Price,Discount,Content,Quantity,CategoryId,File")]
                ModifyProductViewModel createdProduct
        )
        {
            if (ModelState.IsValid)
            {
                createdProduct.ImgURL = await _imageStorage.UploadFileToBlobAsync(
                    createdProduct.File
                );
                _db.Products.Add(_mapper.Map<Product>(createdProduct));
                await _db.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(createdProduct);
        }

        //Get: Product
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _db.Products == null)
            {
                return NotFound();
            }
            var product = await _db.Products.FindAsync(id);
            if (product == null)
            {
                return NotFound();
            }
            return View(product);
        }

        //post: productedit
        [HttpPost, ActionName("Edit")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> EditProductPost(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var productToUpdate = await _db.Products
                .AsNoTracking()
                .FirstOrDefaultAsync(p => p.Id == id);
            if (
                await TryUpdateModelAsync<Product>(
                    productToUpdate,
                    "",
                    p => p.Title,
                    p => p.Category,
                    p => p.Price,
                    p => p.Quantity
                )
            )
            {
                try
                {
                    await _db.SaveChangesAsync();
                    return RedirectToAction(nameof(Index));
                }
                catch (DbUpdateException)
                {
                    ModelState.AddModelError("", "Unable tp save changes");
                }
            }
            return View(productToUpdate);
        }

        //Get productDetails
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _db.Products == null)
            {
                return NotFound();
            }
            var product = await _db.Products
                .Include(p => p.Category)
                .FirstOrDefaultAsync(p => p.Id == id);
            if (product == null)
            {
                return NotFound();
            }

            return View(product);
        }

        //HomeStuff
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(
                new ErrorViewModel
                {
                    RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier
                }
            );
        }
    }
}
