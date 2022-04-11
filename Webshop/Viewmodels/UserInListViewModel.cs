using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Webshop.Viewmodels
{
    public class UserInListViewModel
    {
        public string Name { get; set; }
        public string UserId { get; set; }
        public string Email { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public int Orders { get; set; }
        public List<string> Roles { get; set; }

    }
}
