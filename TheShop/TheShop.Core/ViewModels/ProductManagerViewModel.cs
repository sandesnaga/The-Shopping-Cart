﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheShop.Core.Models;

namespace TheShop.Core.ViewModels
{
    public class ProductManagerViewModel
    {
        public Product Product { get; set; }

        public IEnumerable<ProductCategory> ProductCategories { get; set; }

    }
}
