using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Webshop.Models;
using Webshop.Viewmodels;

namespace Webshop.Interfaces
{
    public interface IProductRepo
    {
        public List<Product> Get();
        IEnumerable<Product> AllProducts { get; }
        public Product Get(int id);
    }
}
