using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Webshop.Models;

namespace Webshop.Viewmodels
{
    public class CustomerCartViewModel
    {
        public CustomerCart CustomerCart { get; set; }
        public int CustomerCartTotal { get; set; }
    }
}
