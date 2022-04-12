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
            var orders = _context.Orders
                             .Include(order => order.Customer)
                             .Include(order => order.OrderDetails)
                             .ToList();

            return View(_orderRepo.ViewAll());
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
            var customersList = await _userManager.GetUsersInRoleAsync("Admin");
            var adminList = await _userManager.GetUsersInRoleAsync("User");

            var customers = (from role in _context.Roles 
                                  join user in _context.UserRoles 
                                  on role.Id equals user.RoleId
                                  where role.Name == "User"
                                  select new UserWithRole { UserId = user.UserId, RoleId = role.Id, RoleName = role.Name }).ToList();

            var admins = (from role in _context.Roles // get person table as p
                                  join user in _context.UserRoles // implement join as e in EmailAddresses table
                                  on role.Id equals user.RoleId //implement join on rows where p.BusinessEntityID == e.BusinessEntityID
                                  where role.Name == "Admin"
                                  select new UserWithRole { UserId = user.UserId, RoleId = role.Id, RoleName = role.Name }).ToList();

            var adminsWithNames = (from admin in admins
                                   join user in _context.Users
                                   on admin.UserId equals user.Id
                                   select new UserInListViewModel { UserId = user.Id, City = user.City, Country = user.Country, Email = user.Email, Name = user.FirstName + " " + user.LastName, Role = admin.RoleName}).ToList();

            var customersWithNames = (from tUser in customers
                                   join user in _context.Users
                                   on tUser.UserId equals user.Id
                                   select new UserInListViewModel { UserId = user.Id, City = user.City, Country = user.Country, Email = user.Email, Name = user.FirstName + " " + user.LastName, Role = tUser.RoleName }).ToList();


            List< ApplicationUser > users = _context.Users.Include(user => user.Customer).ToList();

            List<ApplicationUser> users2 = _context.Users.Include(user => user.Orders).ToList();

            UsersViewModel viewModel = new UsersViewModel(users);

            foreach (ApplicationUser u in viewModel.Users)
            {
                UserInListViewModel userViewModel = (new UserInListViewModel 
                { UserId = u.Id, City = u.City, Country = u.Country, 
                    Email = u.Email, Name = u.FirstName + " " + u.LastName  
                });

                //if(u.Customer != null)
                //{
                //    if(u.Customer.Orders != null)
                //    {
                //        userViewModel.Orders = u.Customer.Orders.Count;
                //    }
                //}
                if (u.Orders != null)
                {
                    userViewModel.Orders = u.Orders.Count;
                }


                //roles

                //add
                viewModel.UserViewModels.Add(userViewModel);
            }

            viewModel.Admins = adminsWithNames;
            viewModel.Customers = customersWithNames;

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
