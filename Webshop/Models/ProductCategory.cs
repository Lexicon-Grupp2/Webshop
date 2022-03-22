﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Webshop.Models
{
    public class ProductCategory
    {
        public int ProductId { get; set; }
        public int CategoryId { get; set; }
        public string Description { get; set; }
        public Product Product { get; set; }
        public Category Category { get; set; }
        public ProductCategory() { }

        //public List<Product> Products { get; set; }
    }
}