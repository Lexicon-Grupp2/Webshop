using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Webshop.Data;
using Webshop.Models;

namespace Webshop.Controllers
{
    public class ShoppingCartController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ShoppingCartController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult AddToCart(int Id)
        {
            var addedCupCake = _context.Inventory.FirstOrDefault(cupCake => cupCake.Id == Id);

            int cupCakePrice = addedCupCake.Price;


            //_shoppingCart.AddProduct(addedCupCake);
            //Funkar inte i nuläget


            //Uppdatera en shoppingcartItem som partialviewn hämtar

            

            ViewBag.Response = "Grattis, din cupcake kostar: " + cupCakePrice;

            //Bara ett test för att se korrekt värde
            return PartialView("_AddToCart", cupCakePrice);
           
        }
    }
}
