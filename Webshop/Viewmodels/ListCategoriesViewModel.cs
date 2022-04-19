using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Webshop.Models;

namespace Webshop.Viewmodels
{
    public class ListCategoriesViewModel
    {
        public string ErrorMessage { get; set; }
        public List<Category> Categories { get; set; }
    }
}
