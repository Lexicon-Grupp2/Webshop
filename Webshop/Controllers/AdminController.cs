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

        public IActionResult EditOrder(int id)
        {
            Order order = _context.Orders.FirstOrDefault(order => order.OrderId == id);

            OrderViewModel orderViewModel = new OrderViewModel()
            {
                OrderId = id,
                OrderDate = order.OrderDate,
                Paid = order.Paid,
                TotalCost = order.TotalCost,
                CustomerId = order.CustomerId
            };

            return View("EditOrder", orderViewModel);
        }

        [HttpPost]
        public IActionResult EditOrder(OrderViewModel updatedOrder)
        {
            Order order = _context.Orders
                .Where(order => order.OrderId == updatedOrder.OrderId)
                .FirstOrDefault();

            if (!updatedOrder.Equals(order))
            {
                order.OrderId = updatedOrder.OrderId;
                order.OrderDate = updatedOrder.OrderDate;
                order.Paid = updatedOrder.Paid;
                order.TotalCost = updatedOrder.TotalCost;
                order.CustomerId = updatedOrder.CustomerId;
            }
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
    }
}
