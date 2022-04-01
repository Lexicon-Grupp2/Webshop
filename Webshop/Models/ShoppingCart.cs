using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Webshop.Data;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;

namespace Webshop.Models
{
    public class ShoppingCart
    {

        public string ShoppingCartId { get; set; }
        public List<CartContent> CartContents { get; set; }

        private readonly ApplicationDbContext _context;
        public ShoppingCart(ApplicationDbContext context)
        {
            _context = context;
        }

        public int GetShoppingCartTotal()
        {
            var total = _context.CartContents
                .Where(cart => cart.ShoppingCartId == ShoppingCartId)
                .Select(cart => cart.Product.Price * cart.Quantity).Sum();

            return total;
        }

        public List<CartContent> GetShoppingCartItems()
        {
            return CartContents ??
                (CartContents = _context.CartContents
                    .Where(c => c.ShoppingCartId == ShoppingCartId)
                    .Include(a => a.Product)
                    .ToList());
        }

        public static ShoppingCart GetCart(IServiceProvider services)
        {
            ISession session = services.GetRequiredService<IHttpContextAccessor>()?
                .HttpContext.Session;

            var context = services.GetService<ApplicationDbContext>();

            string cartId = session.GetString("CartId") ?? Guid.NewGuid().ToString();

            session.SetString("CartId", cartId);

            return new ShoppingCart(context) { ShoppingCartId = cartId };
        }

        public void AddProduct(Product product, int quantity)   //Lägg även till så man kan lägga flera produkter i varukorgen på samma gång
        {

            var cartContent = _context.CartContents.SingleOrDefault(
                item => item.Product.Id == product.Id && item.ShoppingCartId == ShoppingCartId);

            
            if (cartContent == null)
            {
                cartContent = new CartContent
                {
                    ShoppingCartId = ShoppingCartId,
                    Product = product,
                };

                _context.CartContents.Add(cartContent);
            }
            

            cartContent.Quantity++;
            _context.SaveChanges();

        }
    }
}
