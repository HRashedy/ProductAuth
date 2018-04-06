using Microsoft.EntityFrameworkCore;
using MVCWebApp7.Data.Interfaces;
using MVCWebApp7.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCWebApp7.Data.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly ApplicationDbContext _applicationDbContext;
        public ProductRepository(ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }
        public IEnumerable<Product> Products => _applicationDbContext.Products.Include(c => c.Category);

        public IEnumerable<Product> PreferredProducts => _applicationDbContext.Products.Where(p => p.IsPreferredProduct).Include(c => c.Category);

        public Product GetProductById(int productId) => _applicationDbContext.Products.FirstOrDefault(p => p.Id == productId);
    }
}
