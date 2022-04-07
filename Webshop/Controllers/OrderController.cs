using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using Webshop.Data;
using Webshop.Models;

namespace Webshop.Controllers
{
    //[Authorize(Roles = "Admin, User")]
    public class OrderController : Controller
    {
        private readonly IOrderRepo _orderRepo;
        private readonly ShoppingCart _shoppingCart;
        private readonly ApplicationDbContext _context;

        public OrderController(IOrderRepo orderRepo, ShoppingCart shoppingCart, ApplicationDbContext context)
        {
            _orderRepo = orderRepo;
            _shoppingCart = shoppingCart;
            _context = context;
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

            if (ModelState.IsValid)
            {
                _orderRepo.Create(order);
                _shoppingCart.ResetCart();
                return View("OrderComplete");
            }

            return View(order);
        }
    }
}
