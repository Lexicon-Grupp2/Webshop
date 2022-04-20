using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Webshop.Models;

namespace Webshop.Viewmodels
{
    public class CreateProductViewModel
    {
        [Required]
        [StringLength(50, MinimumLength = 1)]
        public string Name { get; set; }
        public string Description { get; set; }
        public int Price { get; set; }
        public ProductCategory ProductCategory { get; set; }
        [Display(Name = "Product Category")]
        public int CategoryId { get; set; }
        [StringLength(25, MinimumLength = 3)]
        [Display(Name = "Image Title")]
        public string ImageTitle { get; set; }

        [StringLength(50, MinimumLength = 3)]
        [Display(Name = "Image Name")]
        public string ImageName { get; set; }
        [Display(Name = "Upload File")]
        public IFormFile ImageFile { get; set; }
    }
}
