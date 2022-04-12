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
        public List<UserInListViewModel> UserViewModels { get; set; }

        public List<UserInListViewModel> Admins { get; set; }
        public List<UserInListViewModel> Customers { get; set; }

        public UsersViewModel(List<ApplicationUser> users)
        {
            Users = users;
            UserViewModels = new List<UserInListViewModel>();
            Admins = new List<UserInListViewModel>();
            Customers = new List<UserInListViewModel>();
        }
    }
}
