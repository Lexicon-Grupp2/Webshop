using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Webshop.Models;

namespace Webshop.Viewmodels
{
    public class CreateCategoryViewModel
    {
        [Required]
        [StringLength(25, MinimumLength = 3)]
        [Display(Name = "Category Name")]
        public string CategoryName { get; set; }
        public List<Category> Categories { get; set; }
        public string ViewMessage { get; set; }
    }
}
