using MyBlazorLibraries.Product.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBlazorLibraries.ShoppingCart.Models
{
    public class ShoppingCartItemModel
    {
        public ProductModel Product { get; }
        public int Price { get; protected set; }
        public int Quantity { get; protected set; }
        public int TotalPrice
        {
            get
            {
                return Price * Quantity;
            }
        }

        public ShoppingCartItemModel(ProductModel product, int quantity)
        {
            this.Product = product;
            this.Price = product.Price;
            this.Quantity = quantity;
        }

        public void UpdateQuantity(ProductModel product, int quantity)
        {
            Price = product.Price;
            Quantity = quantity;
        }
    }
}
