using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Webshop.Interfaces;
using Webshop.Models;

namespace Webshop.Data
{
    public class ProductRepo : IProductRepo
    {
        private readonly ApplicationDbContext _context;
        public ProductRepo(ApplicationDbContext context)
        {
            _context = context;
        }

        public List<Product> Get()
        {
            return _context.Inventory.ToList();
        }

        public IEnumerable<Product> AllProducts
        {
            get
            {
                return _context.Products.Include(item => item.Category);
            }
        }

        public Product Get(int Id)
        {
            return _context.Inventory.FirstOrDefault(cupCake => cupCake.Id == Id);
        }
    }
}
