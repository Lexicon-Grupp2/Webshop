using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Webshop.Viewmodels
{
    public class ProductImageViewModel
    {
        [StringLength(25, MinimumLength = 3)]
        [Display(Name = "Image Title")]
        public string ImageTitle { get; set; }

        [StringLength(50, MinimumLength = 3)]
        [Display(Name = "Image Name")]
        public string ImageName { get; set; }
        [Display(Name = "Upload Image File")]
        public IFormFile ImageFile { get; set; }
    }
}
