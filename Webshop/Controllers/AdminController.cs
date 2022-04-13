using System;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly IOrderRepo _orderRepo;

        public AdminController(ApplicationDbContext context, UserManager<ApplicationUser> userManager, IOrderRepo orderRepo)
        {
            _context = context;
            _orderRepo = orderRepo;
            _userManager = userManager;
        }

        public IActionResult Index()
        {
            return View(_orderRepo.ViewAll());
        }

        public IActionResult ListOrdersForSpecificCustomer(string id)
        {
            var orders = _context.Orders
                             .Include(order => order.Customer)
                             .Include(order => order.OrderDetails)
                             .Where(order => order.CustomerId == id)
                             .ToList();

            return View("Index", orders);
        }

        public IActionResult Details(int id)
        {
            _context.OrderDetails.ToList();
            var chosenDetails = _context.Orders.Find(id);
            List<OrderDetail> details = chosenDetails.OrderDetails.ToList();

            return View("OrderDetails", details);
        }

        public IActionResult EditOrder(int id)
        {
            Order order = _context.Orders.FirstOrDefault(order => order.OrderId == id);

            return View(order);
        }

        [HttpPost]
        public IActionResult EditOrder(Order order)
        {
            _context.Entry(order).State = EntityState.Modified;

            _context.SaveChanges();
            return RedirectToAction("Index");
        }


        public IActionResult DeleteOrder(int id)
        {
            var chosenOrder = _context.Orders.SingleOrDefault(order => order.OrderId == id);

            _context.Orders.Remove(chosenOrder);
            _context.SaveChanges();

            return RedirectToAction("Index");
        }

        public async Task<IActionResult> ListUsers()
        {
            //new way for later
            var adminList = await _userManager.GetUsersInRoleAsync("Admin");
            List<UserInListViewModel> adminsViewModels = new List<UserInListViewModel>();
            foreach (ApplicationUser adm in adminList)
            {
                UserInListViewModel cvm = new UserInListViewModel();

                cvm.Name = adm.FirstName + " " + adm.LastName;
                cvm.Country = adm.Country;
                cvm.City = adm.City;
                cvm.Email = adm.Email;
                cvm.Role = "Admin";
                cvm.UserId = adm.Id;

                adminsViewModels.Add(cvm);
            }

            var customersList = await _userManager.GetUsersInRoleAsync("User");

            List<UserInListViewModel> customerViewModels = new List<UserInListViewModel>();
            foreach (ApplicationUser cust in customersList)
            {
                UserInListViewModel cvm = new UserInListViewModel();

                cvm.Name = cust.FirstName + " " + cust.LastName;
                cvm.Country = cust.Country;
                cvm.City = cust.City;
                cvm.Email = cust.Email;
                cvm.Role = "User";
                cvm.UserId = cust.Id;

                if (cust.Orders != null)
                {
                    cvm.Orders = cust.Orders.Count();
                }
                else
                {
                    cvm.Orders = 0;

                    ApplicationUser tempuser = _context.Users
                                                    .Include(u => u.Orders)
                                                    .FirstOrDefault(u => u.Id == cust.Id);

                    if (tempuser.Orders != null)
                        cvm.Orders = tempuser.Orders.Count;
                }


                customerViewModels.Add(cvm);
            }

            UsersViewModel viewModel = new UsersViewModel(adminsViewModels, customerViewModels);

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

        // GET: Admin/EditUser/5
        [HttpGet]
        public async Task<IActionResult> AddRoleToUser(string Id)
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

            return RedirectToAction("AddRoleToSpecificUser", "Role", user);
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
