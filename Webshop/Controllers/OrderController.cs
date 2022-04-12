using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using Webshop.Data;
using Webshop.Models;

namespace Webshop.Controllers
{
    [Authorize(Roles = "Admin, User")]
    public class OrderController : Controller
    {
        private readonly IOrderRepo _orderRepo;
        private readonly ShoppingCart _shoppingCart;
        private readonly ApplicationDbContext _context;
        private readonly UserManager<ApplicationUser> _userManager;

        public OrderController(IOrderRepo orderRepo, ShoppingCart shoppingCart, ApplicationDbContext context, UserManager<ApplicationUser> userManager)
        {
            _orderRepo = orderRepo;
            _shoppingCart = shoppingCart;
            _context = context;
            _userManager = userManager;
        }
       
        public IActionResult Checkout()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Checkout(Order order)
        {
            var items = _shoppingCart.GetShoppingCartItems();
            _shoppingCart.CartContents = items;

            string customerId = _userManager.FindByNameAsync(User.Identity.Name).Result.Id;

            if (ModelState.IsValid)
            {
                _orderRepo.Create(order, customerId);
                _shoppingCart.ResetCart();
                return View("OrderComplete");
            }

            return View(order);
        }
    }
}
