using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Webshop.Models
{
    public class ProductImage
    {
        [Key]
        public int ImageId { get; set; }
        public string ImageTitle { get; set; }
        public string ImageName { get; set; }
    }
}
