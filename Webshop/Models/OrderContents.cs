using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Webshop.Models
{
    public class OrderContents
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public int TotalCost { get; set; }

        [Required]
        public int ProductId { get; set; }
        public List<Product> Products { get; set; }

        [Required]
        public int OrderId { get; set; }
    }
}
