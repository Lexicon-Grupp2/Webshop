using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Webshop.Models
{
    public class UserWithRole
    {
        public string UserId { get; set; }
        public string RoleId { get; set; }
        public string  RoleName { get; set; }
        public string UserName { get; set; }
    }
}
