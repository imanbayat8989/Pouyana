using MyBlazorLibraries.Product.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBlazorLibraries.Storage
{
    public interface IStorageService
    {
        IList<ProductModel> Products { get; }

        ShoppingCartModel? ShoppingCart { get; }
    }
}
