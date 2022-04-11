using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Webshop.Models;

namespace Webshop.Viewmodels
{
    public class UsersViewModel
    {
        public List<ApplicationUser> Users { get; set; }

        public UsersViewModel(List<ApplicationUser> users)
        {
            Users = users;
        }
    }
}
