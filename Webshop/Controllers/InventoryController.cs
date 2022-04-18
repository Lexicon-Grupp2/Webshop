using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Webshop.Data;
using Webshop.Models;
using Webshop.Viewmodels;

namespace Webshop.Controllers
{
    public class InventoryController : Controller
    {
        private static readonly InventoryViewModel inventoryViewModel = new InventoryViewModel();

        private readonly ApplicationDbContext _context;
        private readonly IWebHostEnvironment _hostEnvironment;

        public InventoryController(ApplicationDbContext context, IWebHostEnvironment hostEnvironment)
        {
            _context = context;
            _hostEnvironment = hostEnvironment;
        }
        public IActionResult Index()
        {          
            ViewData["CategoryId"] = new SelectList(_context.Categories, "Id", "CategoryName");
            return View(new InventoryViewModel(_context.Inventory
                             .Include(product => product.Category)
                             .Include(product => product.ProductImage)
                             .ToList()
                             .Select(product => CreateProductViewModel(product))
                             .ToList()
            )) ;
        }

        public IActionResult AdminInventory()
        {
            return View(new AdminInventoryViewModel(_context.Inventory
                             .Include(product => product.Category)
                             .Include(product => product.ProductImage)
                             .ToList()
                             .Select(product => CreateProductViewModel(product))
                             .ToList()
            ));
        }

        // GET: Inventory/CreateProduct
        public IActionResult CreateProduct()
        {
            ViewData["CategoryId"] = new SelectList(_context.Categories, "Id", "CategoryName");

            return View();
        }

        // POST: Inventory/CreateProduct
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateProduct([Bind("Name,Price,Description,CategoryId,ImageTitle,ImageFile")] CreateProductViewModel model)
        {
            if (ModelState.IsValid)
            {
                Product product = new Product
                {
                    Name = model.Name,
                    Price = model.Price,
                    Description = model.Description,
                    CategoryId = model.CategoryId
                };

                if (model.ImageFile != null)
                {
                    ProductImageViewModel productImageToSend = new ProductImageViewModel();
                    productImageToSend.ImageFile = model.ImageFile;
                    productImageToSend.ImageTitle = model.ImageTitle;

                    string imageName = await ImageSaver.SaveImage(_context, _hostEnvironment, productImageToSend);

                    if (imageName != "empty")
                    {
                        var pr = _context.ProductImages
                        .Where(p => p.ImageName == imageName)
                        .FirstOrDefault();

                        if (pr != null)
                        {
                            product.ProductImageId = pr.ImageId;
                            _context.Inventory.Add(product);
                            await _context.SaveChangesAsync();
                        }
                    }
                }
                else
                {
                    //Insert record
                    _context.Inventory.Add(product);
                    await _context.SaveChangesAsync();
                }

                return RedirectToAction(nameof(Index));
            }
            return View(model);
        }

        public IActionResult Delete(int? Id)
        {
            var product = _context.Inventory
                .Include(p => p.Category)
                .Include(p => p.ProductImage)
                .FirstOrDefault(p => p.Id == Id);

            ProductViewModel model = this.CreateProductViewModel(product);

            return View(model);
        }

        // POST: Inventory/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            string errormessage;
            var productToDelete = await _context.Inventory.FindAsync(id);

            //todo-> combine these checks
            var productInCart = _context.CartContents
                        .Where(p => p.Product.Id == id)
                        .FirstOrDefault();

            var productInOrderDetails = _context.OrderDetails
                        .Where(od => od.ProductId == id)
                        .FirstOrDefault();

            if(productInCart != null)
            {
                errormessage = "Cant delete product '" + productToDelete.Name + "' because it exists in a cart!";
                return View("AdminInventory", new AdminInventoryViewModel(_context.Inventory
                             .Include(product => product.Category)
                             .Include(product => product.ProductImage)
                             .ToList()
                             .Select(product => CreateProductViewModel(product))
                             .ToList(), errormessage
            ));
            }
            if(productInOrderDetails != null)
            {
                errormessage =  "Cant delete product '" + productToDelete.Name + "' because it exists in an order!";
                return View("AdminInventory", new AdminInventoryViewModel(_context.Inventory
                             .Include(product => product.Category)
                             .Include(product => product.ProductImage)
                             .ToList()
                             .Select(product => CreateProductViewModel(product))
                             .ToList(), errormessage
            ));
            }

            else
            {
                //product is not inside a cart/orderdetail-> ok to delete
                _context.Inventory.Remove(productToDelete);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(AdminInventory));
            }         
        }

        // GET: Inventory/Edit/5
        [HttpGet]
        public async Task<IActionResult> Edit(int? Id)
        {
            if (Id == null)
            {
                return NotFound();
            }

            var productToEdit = await _context.Inventory.FindAsync(Id);
            if (productToEdit == null)
            {
                return NotFound();
            }

            ViewData["CategoryId"] = new SelectList(_context.Categories, "Id", "CategoryName", productToEdit.Category);
            ViewData["ImageList"] = new List<ProductImage>(_context.ProductImages.ToList());

            return View(productToEdit);
        }

        // Post: Inventory/Edit/5
        [HttpPost]
        public async Task<IActionResult> Edit(int? id, Product product, int? imageId)
        {
            if (id != null)
            {
                if (ModelState.IsValid)
                {
                    Product productToChange = await _context.Inventory.FindAsync(id);

                    productToChange.CategoryId = product.CategoryId;
                    productToChange.Name = product.Name;
                    productToChange.Price = product.Price;
                    productToChange.Description = product.Description;
                    if(imageId != null)
                    {
                        if (imageId > 0)
                            productToChange.ProductImageId = imageId;
                        else
                            productToChange.ProductImageId = null;
                    }

                    _context.Inventory.Update(productToChange);

                    await _context.SaveChangesAsync();
                }
            }
            return RedirectToAction(nameof(Index));
        }

        private ProductViewModel CreateProductViewModel(Product product)
        {
            ProductViewModel model = new ProductViewModel();
            model.Id = product.Id;
            model.Name = product.Name;
            model.Description = product.Description;
            model.Price = product.Price;
            model.ProductImage = product.ProductImage;
            model.Category = product.Category;
            return model;
        }
    }
}
