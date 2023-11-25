using MyBlazorLibraries.Product.Models;
using MyBlazorLibraries.ShoppingCart.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBlazorLibraries.Storage
{
    public class StorageService : IStorageService
    {
        public IList<ProductModel> Products { get;protected set; }

        public ShoppingCartModel ShoppingCart { get; protected set; }

        public StorageService()
        {
            Products = new List<ProductModel>();
            ShoppingCart = new ShoppingCartModel();
           
       

            AddProduct(new ProductModel("واقعیت افزوده", "پویانا", 20000, "product1.jpg"));
            AddProduct(new ProductModel("واقعیت مجازی", " پویانا کفشدوزکی", 30000, "product2.jpg"));
            AddProduct(new ProductModel("واقعیت ترکیبی", " پویانا مینیون", 40000, "product3.jpg"));
        }

        private void AddProduct(ProductModel product)
        {
            if (!Products.Any(p => p.Sku == product.Sku)) 
            {
                Products.Add(product);
            }
        }
    }
}
