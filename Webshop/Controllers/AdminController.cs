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
    }
}
