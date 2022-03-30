using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Webshop.Data;
using Microsoft.Extensions.DependencyInjection;

namespace Webshop.Models
{
    public class ShoppingCart
    {


        private readonly ApplicationDbContext _context;
        public ShoppingCart(ApplicationDbContext context)
        {
            _context = context;
        }
        public string ShoppingCartId { get; set; }

        public void AddProduct(Product product) //Lägg även till inkommande antal (RL)
        {

            //Kanske hellre lägga till Viewmodel där det skapas?

            var customerCart = _context.CustomerCarts.SingleOrDefault();  //Saknar innehåll inom parentesen




            _context.CustomerCarts.Add(customerCart);
            _context.SaveChanges();

        }
    }
}
