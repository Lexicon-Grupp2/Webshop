using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Webshop.Models;

namespace Webshop.Viewmodels
{
    public class AddRoleToUserViewModel
    {
        public SelectList Roles { get; set; }
        public ApplicationUser User { get; set; }
        public string Message { get; set; }
    }
}
