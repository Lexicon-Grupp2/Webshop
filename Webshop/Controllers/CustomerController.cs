using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Formatters;
using Microsoft.EntityFrameworkCore;
using PuppeteerSharp;
using PuppeteerSharp.Media;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Webshop.Data;
using Webshop.Models;

namespace Webshop.Controllers
{
    [Authorize]
    public class CustomerController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<ApplicationUser> _userManager;

        public CustomerController(ApplicationDbContext context, UserManager<ApplicationUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        public IActionResult Index()
        {
            string customerId = _userManager.FindByNameAsync(User.Identity.Name).Result.Id;

            var orders = _context.Orders
                             .Include(order => order.Customer)
                             .Include(order => order.OrderDetails)
                             .Where(order => order.CustomerId == customerId)
                             .ToList();

            return View(orders);
        }

        public IActionResult Details(int id)
        {
            string customerId = _userManager.FindByNameAsync(User.Identity.Name).Result.Id;

            _context.OrderDetails.ToList();
            var chosenDetails = _context.Orders.Find(id);

            if(chosenDetails == null)
                {
                    return NotFound();
                }
            else if(chosenDetails.CustomerId != customerId)
            {
                return StatusCode(401, "Not authorized to view this order!");
            }

            List<OrderDetail> details = chosenDetails.OrderDetails.ToList();

            return View("OrderDetails", details);
        }

        public IActionResult Receipt()
        {
            return View();
        }


        [HttpGet]
        [Obsolete]
        public async Task<IActionResult> Print()
        
        {
            var browserFetcher = new BrowserFetcher();
            await browserFetcher.DownloadAsync();

            await using var browser = await Puppeteer.LaunchAsync(new LaunchOptions { Headless = true });

            await using var page = await browser.NewPageAsync();
            await page.GoToAsync("https://localhost:44341/Customer/Receipt");           //Change this to your localhost


            var pdfContent = await page.PdfStreamAsync(new PdfOptions
            {
                Format = PaperFormat.A4,
                PrintBackground = true
            }) ;

            return File(pdfContent, "application/pdf", "receipt.pdf");

        }
    }
}
