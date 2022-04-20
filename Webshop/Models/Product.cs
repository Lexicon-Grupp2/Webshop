using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Webshop.Models
{
    public class Product
    {
        public int Id { get; set; }
        [StringLength(50, MinimumLength = 2)]
        public string Name { get; set; }
        public string Description { get; set; }
        [Range(1, int.MaxValue, ErrorMessage = "Value for price must be a positive integer!")]
        public int Price { get; set; }
        public Category Category { get; set; }
        public int? CategoryId { get; set; }
        public List<ProductCategory> ProductCategories { get; set; }
        public int? ProductImageId { get; set; }
        public ProductImage ProductImage { get; set; }
    }
}
