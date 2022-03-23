using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Webshop.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string CategoryName { get; set;}
        public List<Product> Products { get; set; }
        public List<ProductCategory> ProductCategories { get; set; }
        public Category() { }

    }
}
