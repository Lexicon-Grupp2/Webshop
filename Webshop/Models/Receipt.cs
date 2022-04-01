using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Webshop.Models
{
    public class Receipt
    {
        [Key]
        public int OrderId { get; set; }
        [Required]
        public DateTime OrderDate { get; set; }
        public int TotalCost { get; set; }
        public List<Product> Products { get; set; }
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }


        //public List<OrderContents> orderContents { get; set; }

    }
}
