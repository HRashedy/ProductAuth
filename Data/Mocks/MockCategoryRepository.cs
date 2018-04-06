using MVCWebApp7.Data.Interfaces;
using MVCWebApp7.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCWebApp7.Data.Mocks
{
    public class MockCategoryRepository : ICategoryRepository
    {
       // public IEnumerable<Category> Categories => throw new NotImplementedException();

        public IEnumerable<Category> Categories
        {
            get
            {
                return new List<Category>
                     {
                         new Category { CategoryName = "Mobile", Description = "All Mobiles" },
                         new Category { CategoryName = "PC", Description = "All Kind OF Personal Computers" }
                     };
            }
        }
    }
}
