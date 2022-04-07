using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Webshop.Models
{
    public interface IOrderRepo
    {
        List<Order> ViewAll();
        void Remove(int id);
        void Create(Order order);
    }
}
