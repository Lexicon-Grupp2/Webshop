using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Webshop.Data;
using Webshop.Viewmodels;

namespace Webshop.Models
{
    public class ImageSaver
    {
        public static async Task<string> SaveImage(ApplicationDbContext context, IWebHostEnvironment hostEnvironment, ProductImageViewModel imageModel)
        {
            string imageName = "empty";

            if(imageModel != null)
            {
                //create database object
                ProductImage productImage = new ProductImage();
                productImage.ImageTitle = imageModel.ImageTitle;

                //Save image to wwwroot/image
                string wwwRootPath = hostEnvironment.WebRootPath;
                string fileName = Path.GetFileNameWithoutExtension(imageModel.ImageFile.FileName);
                string extension = Path.GetExtension(imageModel.ImageFile.FileName);
                productImage.ImageName = fileName = fileName + DateTime.Now.ToString("yymmssfff") + extension;
                string path = Path.Combine(wwwRootPath + "/Images/ProductImages/", fileName);
                using (var fileStream = new FileStream(path, FileMode.Create))
                {
                    await imageModel.ImageFile.CopyToAsync(fileStream);

                    //thumb test
                    int thumbHeight = 300;
                    string thumbFilename = Path.GetFileNameWithoutExtension(productImage.ImageName) + "th" + extension;
                    productImage.ImageThumbName = thumbFilename;

                    string tpath = wwwRootPath + "/images/ProductImages/" + thumbFilename;
                    Image image = Image.FromStream(imageModel.ImageFile.OpenReadStream(), true, true);

                    //resized
                    Bitmap resizetofit = new Bitmap(image, image.Width, image.Height);
                    Bitmap bitmapResized = ProportionallyResizeBitmapByHeight(resizetofit, thumbHeight);
                    bitmapResized.Save(tpath);
                }

                //Insert record
                context.ProductImages.Add(productImage);
                await context.SaveChangesAsync();

                imageName = productImage.ImageName;
            }

            return imageName;
        }

        public static async Task<bool> DeleteImageAsync(ApplicationDbContext context, IWebHostEnvironment hostEnvironment, int id)
        {
            bool result = false;

            //delete image
            var imageToRemove = context.ProductImages.Include(p => p.Products)
                .FirstOrDefault(p => p.ImageId == id);

            //ändra bättre (cascade set to null?)
            if (imageToRemove.Products.Count < 1)
            {
                //delete image from wwwroot/image/productimages
                var imagePath = Path.Combine(hostEnvironment.WebRootPath, "images/productimages", imageToRemove.ImageName);
                if (System.IO.File.Exists(imagePath))
                    System.IO.File.Delete(imagePath);
                //delete thumbimage from wwwroot/image/productimages
                imagePath = Path.Combine(hostEnvironment.WebRootPath, "images/productimages", imageToRemove.ImageThumbName);
                if (System.IO.File.Exists(imagePath))
                    System.IO.File.Delete(imagePath);

                //delete the record
                context.ProductImages.Remove(imageToRemove);
                await context.SaveChangesAsync();

                result = true;
            }

            return result;
        }

        public static Bitmap ProportionallyResizeBitmapByHeight(Bitmap imgToResize, int height)
        {
            int sourceWidth = imgToResize.Width;
            int sourceHeight = imgToResize.Height;

            float scale = 0;

            scale = (height / (float)sourceHeight);

            int destWidth = (int)(sourceWidth * scale);
            int destHeight = (int)(sourceHeight * scale);

            Bitmap result = new Bitmap(destWidth, destHeight);
            result.SetResolution(imgToResize.HorizontalResolution, imgToResize.VerticalResolution);
            Graphics g = Graphics.FromImage(result);
            g.DrawImage(imgToResize, 0, 0, destWidth, destHeight);
            g.Dispose();

            return result;
        }
    }
}
