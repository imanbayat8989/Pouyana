﻿using MyBlazorLibraries.ShoppingCart.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBlazorLibraries.Product.Models
{
    public class ShoppingCartModel
    {
        public IList<ShoppingCartItemModel> Items { get; }

        public ShoppingCartModel()
        {
            Items = new List<ShoppingCartItemModel>();
        }
    }
}
