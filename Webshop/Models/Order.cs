using System;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Webshop.Models
{
    public class Order
    {
        [Key]
        public int OrderId { get; set; }
        [BindNever]
        [ScaffoldColumn(false)]
        public DateTime OrderDate { get; set; }
        public List<OrderDetail> OrderDetails { get; set; }
        [BindNever]
        [ScaffoldColumn(false)]
        public int TotalCost { get; set; }
        [Required]
        public DateTime OrderDate { get; set; }
        public int Quantity { get; set; }
        public int TotalCost { get; set; }
        public string ShoppingCartId { get; set; }
        public List<Product> Products { get; set; }
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }
    }
}
