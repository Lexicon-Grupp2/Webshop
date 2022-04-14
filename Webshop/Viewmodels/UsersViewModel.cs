using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Webshop.Models;

namespace Webshop.Viewmodels
{
    public class UsersViewModel
    {
        public List<UserInListViewModel> Admins { get; set; }
        public List<UserInListViewModel> Customers { get; set; }

        public UsersViewModel(List<UserInListViewModel> admins, List<UserInListViewModel> users)
        {
            Admins = admins;
            Customers = users;
        }
    }
}
