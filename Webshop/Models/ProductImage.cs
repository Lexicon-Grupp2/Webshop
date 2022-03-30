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

        [Display(Name = "Image Title")]
        public string ImageTitle { get; set; }

        [Display(Name = "Image Title")]
        public string ImageName { get; set; }
        public string ImageThumbName { get; set; }

        public List<Product> Products { get; set; }
    }
}
