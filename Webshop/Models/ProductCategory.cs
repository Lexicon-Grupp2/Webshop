using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Webshop.Models
{
    //Inte säker på att denna behövs, kan ligga kvar tills vidare (RL)

    public class ProductCategory
    {
        public int ProductId { get; set; }
        public int CategoryId { get; set; }
        public string Description { get; set; }
        public Product Product { get; set; }
        public Category Category { get; set; }
        public ProductCategory() { }

        //public List<Product> Products { get; set; }
    }
}
