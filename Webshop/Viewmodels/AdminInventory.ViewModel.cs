using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Webshop.Viewmodels
{
    public class AdminInventoryViewModel
    {
        public string ErrorMessage { get; set; }
        public List<ProductViewModel> Inventory { get; set; }
        public AdminInventoryViewModel(List<ProductViewModel> inventory)
        {
            Inventory = inventory;
        }
        public AdminInventoryViewModel(List<ProductViewModel> inventory, string errorMessage)
        {
            Inventory = inventory;
            ErrorMessage = errorMessage;
        }
    }
}
