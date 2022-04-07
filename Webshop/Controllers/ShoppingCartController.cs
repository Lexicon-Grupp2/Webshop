using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Webshop.Data;
using Webshop.Viewmodels;
using Webshop.Models;
using Webshop.Interfaces;

namespace Webshop.Controllers
{
    public class ShoppingCartController : Controller
    {

        private readonly IProductRepo _productRepo;
        private readonly ShoppingCart _shoppingCart;

        public ShoppingCartController(IProductRepo productRepo, ShoppingCart shoppingCart)
        {
            _productRepo = productRepo;
            _shoppingCart = shoppingCart;
        }

        public ViewResult Index()
        {
            var items = _shoppingCart.GetShoppingCartItems();
            _shoppingCart.CartContents = items;

            var shoppingCartViewModel = new ShoppingCartViewModel
            {
                ShoppingCart = _shoppingCart,
                ShoppingCartTotal = _shoppingCart.GetShoppingCartTotal()
            };

            return View(shoppingCartViewModel);
        }

        public RedirectToActionResult AddToCart(int Id, int Quantity)
        {
            var addedCupCake = _productRepo.AllProducts.FirstOrDefault(item => item.Id == Id);

            if (addedCupCake != null)
            {
                _shoppingCart.AddProductToCart(addedCupCake, Quantity);
            }

            return RedirectToAction("Index");
        }

        public RedirectToActionResult RemoveFromCart(int Id)
        {
            var cupCakeToRemove = _productRepo.Get()
                .FirstOrDefault(cupCake => cupCake.Id == Id);

            if (cupCakeToRemove != null)
            {
                _shoppingCart.RemoveProductFromCart(cupCakeToRemove);
            }
            return RedirectToAction("Index");
        }

        public RedirectToActionResult UpdateCart(int Id, int Quantity)
        {
            var cupCakeToUpdate = _productRepo.Get()
                .FirstOrDefault(cupCake => cupCake.Id == Id);

            if (cupCakeToUpdate != null)
            {
                _shoppingCart.UpdateCart(cupCakeToUpdate, Quantity);
            }
            return RedirectToAction("Index");
        }
    }
}
