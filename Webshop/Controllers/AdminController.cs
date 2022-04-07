using Microsoft.AspNetCore.Mvc;
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
    //[Authorize(Roles = "Admin")]
    public class AdminController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly IOrderRepo _orderRepo;

        public AdminController(ApplicationDbContext context, IOrderRepo orderRepo)
        {
            _context = context;
            _orderRepo = orderRepo;
        }

        public IActionResult Index()
        {
            return View(_orderRepo.ViewAll());
        }

        public IActionResult Details(int id)
        {
            _context.OrderDetails.ToList();
            var chosenDetails = _context.Orders.Find(id);
            List<OrderDetail> details = chosenDetails.OrderDetails.ToList();

            return View("OrderDetails", details);
        }

        public IActionResult DeleteOrder(int id)
        {
            var chosenOrder = _context.Orders.SingleOrDefault(order => order.OrderId == id);

            _context.Orders.Remove(chosenOrder);
            _context.SaveChanges();

            return RedirectToAction("Index");
        }

        // GET: Admin/CreateCategory
        public IActionResult CreateCategory()
        {
            CreateCategoryViewModel viewModel = new CreateCategoryViewModel();
            viewModel.Categories = _context.Categories.ToList();

            return View(viewModel);
        }

        // POST: Admin/CreateCategory
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateCategory([Bind("CategoryName")] CreateCategoryViewModel viewModel)
        {
            if (ModelState.IsValid)
            {
                Category category = new Category
                {
                    CategoryName = viewModel.CategoryName
                };

                var tempCategory = _context.Categories
                        .Where(c => c.CategoryName == viewModel.CategoryName)
                        .FirstOrDefault();

                if (tempCategory == null)
                {
                    await _context.Categories.AddAsync(category);
                    await _context.SaveChangesAsync();
                    return RedirectToAction(nameof(Index));
                }
                else
                    viewModel.ViewMessage = "A category with the name '" + viewModel.CategoryName + "' already exists!";
            }
            viewModel.Categories = _context.Categories.ToList();

            return View(viewModel);
        }
    }
}
