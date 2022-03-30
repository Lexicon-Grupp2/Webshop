using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Webshop.Data;
using Webshop.Models;
using Webshop.Viewmodels;

namespace Webshop.Controllers
{
    public class InventoryController : Controller
    {
        private static readonly InventoryViewModel inventoryViewModel = new InventoryViewModel();

        private readonly ApplicationDbContext _context;
        public InventoryController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            ViewData["CategoryId"] = new SelectList(_context.Categories, "Id", "CategoryName");
            return View(new InventoryViewModel(_context.Inventory
                             .Include(product => product.Category)
                             .Include(product => product.ProductImage)
                             .ToList()
                             .Select(product => CreateProductViewModel(product))
                             .ToList()
            )) ;

        }

        // GET: Inventory/CreateProduct
        public IActionResult CreateProduct()
        {
            ViewData["CategoryId"] = new SelectList(_context.Categories, "Id", "CategoryName");

            return View();
        }

        // POST: Inventory/CreateProduct
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateProduct([Bind("Name,Price,Description,CategoryId")] CreateProductViewModel model)
        {
            if (ModelState.IsValid)
            {
                Product product = new Product();
                product.Name = model.Name;
                product.Price = model.Price;
                product.Description = model.Description;
                product.CategoryId = model.CategoryId;

                //Insert record
                _context.Inventory.Add(product);
                await _context.SaveChangesAsync();

                return RedirectToAction(nameof(Index));
            }
            return View(model);
        }

        private ProductViewModel CreateProductViewModel(Product product)
        {
            ProductViewModel model = new ProductViewModel();
            model.Id = product.Id;
            model.Name = product.Name;
            model.Description = product.Description;
            model.Price = product.Price;
            model.ProductImage = product.ProductImage;
            model.Category = product.Category;
            return model;
        }
    }
}
