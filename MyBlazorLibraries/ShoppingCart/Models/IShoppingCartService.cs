using MyBlazorLibraries.Product.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBlazorLibraries.ShoppingCart.Models
{
    public interface IShoppingCartService
    {
        ShoppingCartModel Get();
        void AddProduct(ProductModel product, int quantity);
        void DeleteProduct(ShoppingCartItemModel item);
        int Count();
        bool HasProduct(string sku);
    }
}
