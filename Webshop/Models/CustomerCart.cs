using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Webshop.Models
{
    public class CustomerCart
    {
        //Osäker om det behövs en särskild klass som representerar varje unik kundkorg(RL)

        public int CustomerCartId { get; set; }
        public int TotalCost { get; set; }
        public Product Product { get; set; }
        public string ShoppingCartId { get; set; }
    }
}
