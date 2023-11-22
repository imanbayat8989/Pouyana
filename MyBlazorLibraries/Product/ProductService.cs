using MyBlazorLibraries.Product.Models;
using MyBlazorLibraries.Storage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBlazorLibraries.Product
{
    public class ProductService : IProductService
    {
        private readonly IStorageService _storageService;

        public ProductService(IStorageService storageService)
        {
            _storageService = storageService;
        }

        public IList<ProductModel> GetAll()
        {
            return _storageService.Products.ToList();
        }

        public ProductModel? GetProduct(string sku)
        {
           return _storageService.Products.FirstOrDefault(p => p.Sku == sku);
        }

        public ProductModel? GetProductBySlug(string slug)
        {
            return _storageService.Products.FirstOrDefault(p => p.Slug == slug);
        }
    }
}
