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
        public string CustomerId { get; set; }
        public bool Paid { get; set; }
        public List<OrderDetail> OrderDetails { get; set; }
        [BindNever]
        [ScaffoldColumn(false)]
        public int TotalCost { get; set; }
    }
}
