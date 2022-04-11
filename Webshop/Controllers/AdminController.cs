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

        public IActionResult ListUsers()
        {          
            List<ApplicationUser> users = _context.Users.Include(user => user.Customer).ToList();

            UsersViewModel viewModel = new UsersViewModel(users);

            return View(viewModel);
        }

        // GET: Admin/EditUser/5
        [HttpGet]
        public async Task<IActionResult> EditUser(string Id)
        {
            if (Id == null)
            {
                return NotFound();
            }

            var user = await _context.Users.FindAsync(Id);
            if (user == null)
            {
                return NotFound();
            }
            return View(user);
        }

        // Post: Admin/Edit/5
        [HttpPost]
        public async Task<IActionResult> EditUser(string Id, ApplicationUser user)
        {
            //test get logged in user
            var tempuser = _context.Users
                        .Where(u => u.UserName == User.Identity.Name)
                        .FirstOrDefault();

            if (Id != null)
            {
                if (ModelState.IsValid)
                {
                    ApplicationUser userToChange = await _context.Users.FindAsync(Id);

                    //update todo->change better
                    userToChange.FirstName = user.FirstName;
                    userToChange.LastName = user.LastName;
                    userToChange.PhoneNumber = user.PhoneNumber;
                    userToChange.Email = user.Email;
                    userToChange.NormalizedEmail = user.Email.ToUpper();
                    userToChange.UserName = user.Email;
                    user.NormalizedUserName = user.Email.ToUpper();
                    userToChange.Country = user.Country;
                    userToChange.City = user.City;
                    userToChange.Address = user.Address;
                    user.PostalCode = user.PostalCode;

                    _context.Users.Update(userToChange);

                    await _context.SaveChangesAsync();
                }
            }
            return RedirectToAction(nameof(ListUsers));
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
