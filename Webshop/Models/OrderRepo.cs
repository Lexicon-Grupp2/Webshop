using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Webshop.Data;

namespace Webshop.Models
{
    public class OrderRepo : IOrderRepo
    {
        readonly ApplicationDbContext _context;
        private readonly ShoppingCart _shoppingCart;

        public OrderRepo(ApplicationDbContext context, ShoppingCart shoppingCart)
        {
            _context = context;
            _shoppingCart = shoppingCart;
        }

        public List<Order> ViewAll()
        {
            return _context.Orders.ToList();
        }

        //Bättre (säkrare) att lägga all logiken här istället?

        public void Remove(int id)
        {
            var chosenOrder = _context.Orders.SingleOrDefault(order => order.OrderId == id);

            _context.Orders.Remove(chosenOrder);
            _context.SaveChanges();

        }

        public void Create(Order order, string customerid)
        {
            order.OrderDate = DateTime.Now;

            var shoppingCartContents = _shoppingCart.CartContents;
            order.TotalCost = _shoppingCart.GetShoppingCartTotal();

            order.OrderDetails = new List<OrderDetail>();

            foreach (var item in shoppingCartContents)
            {
                var orderDetail = new OrderDetail
                {

                    //Här kan vi lägga till fler värden efter behov
                    ProductName = item.Product.Name,
                    Quantity = item.Quantity,
                    ProductId = item.Product.Id,
                    Price = item.Product.Price
                };

                order.OrderDetails.Add(orderDetail);
            }

            _context.Orders.Add(order);

            _context.SaveChanges();
        }

    }
}
