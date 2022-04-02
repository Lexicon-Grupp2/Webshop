using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
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
    public class ImageController : Controller
    {
        private readonly ApplicationDbContext _context;

        private readonly IWebHostEnvironment _hostEnvironment;

        public ImageController(ApplicationDbContext context, IWebHostEnvironment hostEnvironment)
        {
            _context = context;
            _hostEnvironment = hostEnvironment;
        }

        // GET: Image
        public IActionResult Index()
        {
            return View(_context.ProductImages.ToList());
        }

        // GET: Image/Details/5
        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var imageModel = _context.ProductImages
                .First(m => m.ImageId == id);
            if (imageModel == null)
            {
                return NotFound();
            }

            return View(imageModel);
        }

        // GET: Image/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Image/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ImageId,ImageTitle,ImageFile")] ProductImageViewModel imageModel)
        {
            if (ModelState.IsValid)
            {
                string imageName = await ImageSaver.SaveImage(_context, _hostEnvironment, imageModel);

                if(imageName != "empty")
                    return RedirectToAction(nameof(Index));
            }
            return View(imageModel);
        }

        public async Task<IActionResult> Delete(int? id)
        {
            var imageModel = await _context.ProductImages.FindAsync(id);

            return View(imageModel);
        }

        // POST: Image/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            #region old
            //var imageModel = await _context.ProductImages.FindAsync(id);

            ////detta istället
            //var imageToRemove = _context.ProductImages.Include(p => p.Products)
            //    .FirstOrDefault(p => p.ImageId == id);

            ////ändra bättre (set to null?)
            //if (imageToRemove.Products == null)
            //{
            //    //delete image from wwwroot/image/productimages
            //    var imagePath = Path.Combine(_hostEnvironment.WebRootPath, "images/productimages", imageModel.ImageName);
            //    if (System.IO.File.Exists(imagePath))
            //        System.IO.File.Delete(imagePath);
            //    //delete thumbimage from wwwroot/image/productimages
            //    imagePath = Path.Combine(_hostEnvironment.WebRootPath, "images/productimages", imageModel.ImageThumbName);
            //    if (System.IO.File.Exists(imagePath))
            //        System.IO.File.Delete(imagePath);

            //    //delete the record
            //    _context.ProductImages.Remove(imageModel);
            //    await _context.SaveChangesAsync();
            //}
            #endregion

            bool wasDeleted = await ImageSaver.DeleteImageAsync(_context, _hostEnvironment, id);

            return RedirectToAction(nameof(Index));
        }

        // GET: Image/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var imageModel = await _context.ProductImages.FindAsync(id);
            if (imageModel == null)
            {
                return NotFound();
            }
            return View(imageModel);
        }
    }
}
