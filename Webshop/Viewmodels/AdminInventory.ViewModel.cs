using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Webshop.Viewmodels
{
    public class AdminInventoryViewModel
    {
        public string ErrorMessage { get; set; }

        public InventoryViewModel InvViewModel { get; set; }
        public AdminInventoryViewModel(InventoryViewModel inventoryViewModel)
        {
            InvViewModel = inventoryViewModel;
        }
        public AdminInventoryViewModel(InventoryViewModel inventoryViewModel, string errorMessage)
        {
            InvViewModel = inventoryViewModel;
            ErrorMessage = errorMessage;
        }
    }
}
