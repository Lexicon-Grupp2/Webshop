using Microsoft.AspNetCore.Authorization;
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
    [Authorize(Roles = "Admin")]
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
            if (ModelState.IsValid && imageModel.ImageFile != null)
            {
                string imageName = await ImageSaver.SaveImage(_context, _hostEnvironment, imageModel);

                if (imageName != "empty")
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

        // Post: Image/Edit/5
        [HttpPost]
        public async Task<IActionResult> Edit(int? id, ProductImage productImage)
        {
            if (id != null)
            {
                if (ModelState.IsValid)
                {
                    ProductImage imageToChange = await _context.ProductImages.FindAsync(id);
                    imageToChange.ImageTitle = productImage.ImageTitle;
                    _context.ProductImages.Update(imageToChange);

                    await _context.SaveChangesAsync();
                }
            }
            return RedirectToAction(nameof(Index));
        }
    }
}
