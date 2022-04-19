using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Webshop.Data;
using Webshop.Models;
using Webshop.Viewmodels;

namespace Webshop.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private static readonly InventoryViewModel inventoryViewModel = new InventoryViewModel();

        private readonly ApplicationDbContext _context;
        private readonly IWebHostEnvironment _hostEnvironment;

        public HomeController(ILogger<HomeController> logger, ApplicationDbContext context, IWebHostEnvironment hostEnvironment)
        {
            _logger = logger;
            _context = context;
            _hostEnvironment = hostEnvironment;
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
            ));
        }

        public IActionResult Privacy()
        {
            return View();
        }

        /*
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        */

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
