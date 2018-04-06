using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MVCWebApp7.Data.Interfaces;
using MVCWebApp7.Data.Models;
using MVCWebApp7.ViewModels;


namespace MVCWebApp7.Controllers
{
    [Route("api/[controller]")]
    public class ProductDataController : Controller
    {
        private readonly IProductRepository _productRepository;

        public ProductDataController(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        [HttpGet]
        public IEnumerable<ProductViewModel> LoadMoreProducts()
        {
            IEnumerable<Product> dbProducts = null;

            dbProducts = _productRepository.Products.OrderBy(p => p.Id).Take(10);

            List<ProductViewModel> products = new List<ProductViewModel>();

            foreach (var dbProduct in dbProducts)
            {
                products.Add(MapDbProductToProductViewModel(dbProduct));
            }
            return products;
        }

        private ProductViewModel MapDbProductToProductViewModel(Product dbProduct) => new ProductViewModel()
        {
            Id = dbProduct.Id,
            Name = dbProduct.Name,
            Price = dbProduct.Price,
            ShortDescription = dbProduct.ShortDescription,
            ImageThumbnailUrl = dbProduct.ImageThumbnailUrl
        };

    }
}
