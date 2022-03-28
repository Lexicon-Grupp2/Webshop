using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Webshop.Models;

namespace Webshop.Viewmodels
{
    public class InventoryViewModel
    {
        public List<ProductViewModel> Inventory { get; set; }
        public ProductCategory ProductCategory { get; set; }
        public CreateProductViewModel CreateProductViewModel { get; set; }
        public InventoryViewModel(List<ProductViewModel> inventory)
        {
            Inventory = inventory;
        }

        public InventoryViewModel() { }
    }
}
