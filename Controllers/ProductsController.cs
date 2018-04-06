using MVCWebApp7.ViewModels;
using MVCWebApp7.Data.Interfaces;
using MVCWebApp7.Data.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCWebApp7.Controllers
{
    public class ProductsController : Controller
    {
        private readonly IProductRepository _productRepository;
        private readonly ICategoryRepository _categoryRepository;

        public ProductsController(IProductRepository productRepository, ICategoryRepository categoryRepository)
        {
            _productRepository = productRepository;
            _categoryRepository = categoryRepository;
        }

        public ViewResult List(string category)
        {
            string _category = category;
            IEnumerable<Product> products;

            string currantCategory = string.Empty;

            if(string.IsNullOrEmpty(category))
            {
                products = _productRepository.Products.OrderBy(n => n.Id);
                currantCategory = "All Products";
            }else
            {
                if (string.Equals("PC-Labtop", _category, StringComparison.OrdinalIgnoreCase)) 
                {
                    products = _productRepository.Products.Where(p => p.Category.CategoryName.Equals("PC-Labtop")).OrderBy(p => p.Name);
                } else
                    products = _productRepository.Products.Where(p => p.Category.CategoryName.Equals("Mobile")).OrderBy(p => p.Name);

                currantCategory = _category;
            }

            var productListViewModel = new ProductListViewModel
            {
                Products = products,
                CurrentCategory = currantCategory
            };

            return View(productListViewModel);
            

        }
    }
}