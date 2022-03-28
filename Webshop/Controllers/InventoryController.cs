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
                             .ToList()
                             .Select(product => CreateProductViewModel(product))
                             .ToList()
            )) ;

        }

        private ProductViewModel CreateProductViewModel(Product product)
        {
            ProductViewModel model = new ProductViewModel();
            model.Id = product.Id;
            model.Name = product.Name;
            model.Description = product.Description;
            model.Price = product.Price;
            return model;
        }
    }
}
