using MVCWebApp7.Data.Interfaces;
using MVCWebApp7.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCWebApp7.Data.Mocks
{
    public class MockProductRepository : IProductRepository
    {
        private readonly ICategoryRepository _categoryRepository = new MockCategoryRepository();
        public IEnumerable<Product> Products
        {
            get
            {
                return new List<Product>
                {
                    new Product {
                        Name = "IPhone",
                        Price = 7.95M, ShortDescription = "Best Sall",
                        LongDescription = "Iphone is the best in Europ, and many Other countryes",
                        Category = _categoryRepository.Categories.First(),
                        ImageUrl = "https://www.o2.co.uk/shop/phones/apple/iphone-se",
                        InStock = true,
                        IsPreferredProduct = true,
                        ImageThumbnailUrl = "https://www.google.com.tr/imgres?imgurl=https%3A%2F%2Fstaticshop.o2.co.uk%2Fproduct%2Fimages%2Fiphone_se_16gb_rose_gold_header.png%3Fcb%3Dca87b899b2ffa0499b9a577d0931ff3f&imgrefurl=https%3A%2F%2Fwww.o2.co.uk%2Fshop%2Fphones%2Fapple%2Fiphone-se&docid=Rm1CPHxOrWzUcM&tbnid=MV-3icsoliva1M%3A&vet=1&w=430&h=430&bih=494&biw=1133&ved=0ahUKEwin5KXqraDaAhXJIlAKHWJeBJwQMwiqAigAMAA&iact=c&ictx=1"
                    },
                    new Product {
                        Name = "Samsung",
                        Price = 12.95M, ShortDescription = "Top 5",
                        LongDescription = "Best Sell In Medil East",
                        Category =  _categoryRepository.Categories.First(),
                        ImageUrl = "http://www.samsung.com/my/",
                        InStock = true,
                        IsPreferredProduct = false,
                        ImageThumbnailUrl = "https://www.google.com.tr/imgres?imgurl=http%3A%2F%2Fimages.samsung.com%2Fis%2Fimage%2Fsamsung%2Fp5%2Fmy%2Fhome%2FBlack.png%3F%24ORIGIN_PNG%24&imgrefurl=http%3A%2F%2Fwww.samsung.com%2Fmy%2F&docid=D74IdKSQQSvjcM&tbnid=2irJIlHb2neZpM%3A&vet=1&w=826&h=620&bih=494&biw=1133&ved=0ahUKEwjDsa6TrqDaAhXKZ1AKHR_HB54QMwj8ASgAMAA&iact=c&ictx=1"
                    },
                    new Product {
                        Name = "Alcatel ",
                        Price = 12.95M, ShortDescription = "Top 5",
                        LongDescription = "Good Sall in Gulf",
                        Category =  _categoryRepository.Categories.First(),
                        ImageUrl = "https://eu.alcatelmobile.com/",
                        InStock = true,
                        IsPreferredProduct = false,
                        ImageThumbnailUrl = "https://www.google.com.tr/imgres?imgurl=https%3A%2F%2Feu.alcatelmobile.com%2Fmedia%2Fcatalog%2Fproduct%2Fcache%2F7%2Fimage%2F1200x630%2F9df78eab33525d08d6e5fb8d27136e95%2Fa%2Fl%2Falcatel_mobile-3c_b7.png&imgrefurl=https%3A%2F%2Feu.alcatelmobile.com%2F&docid=u_47uL6JCcA2DM&tbnid=_LwUG3DEtd4svM%3A&vet=1&w=1200&h=630&bih=494&biw=1133&ved=0ahUKEwjEwJqrrqDaAhWBL1AKHTPYBp0QMwizAigCMAI&iact=c&ictx=1"
                    },
                    new Product
                    {
                        Name = "Lenovo",
                        Price = 12.95M,
                        ShortDescription = "Best quality and price",
                        LongDescription = "Good quality with and best price Best sall in ME.",
                        Category = _categoryRepository.Categories.Last(),
                        ImageUrl = "https://www3.lenovo.com/nz/en/desktops-and-all-in-ones/ideacentre/ideacentre-all-in-one/AIO-520S-23/p/FFICF2S0273",
                        InStock = true,
                        IsPreferredProduct = false,
                        ImageThumbnailUrl = "https://www.google.com.tr/imgres?imgurl=https%3A%2F%2Fwww3.lenovo.com%2Fmedias%2Flenovo-all-in-one-desktop-ideacentre-520s-front.png%3Fcontext%3DbWFzdGVyfGltYWdlc3wxODg2NHxpbWFnZS9wbmd8aW1hZ2VzL2g0NS9oNmIvOTQwNzI1NzI0Nzc3NC5wbmd8MzU5MjVkZTMzNWQ5Y2IxZjAxYTRhODcwMzA2ZWE2ZmZhNzMxNmQ4ZjY2OGJiN2IwNDIwOWUxM2JkY2EwNGQ2Yg&imgrefurl=https%3A%2F%2Fwww3.lenovo.com%2Fnz%2Fen%2Fdesktops-and-all-in-ones%2Fideacentre%2Fideacentre-all-in-one%2FAIO-520S-23%2Fp%2FFFICF2S0273&docid=-VGqC5uuUemYHM&tbnid=wqXVzgLLmQWNpM%3A&vet=1&w=400&h=300&bih=494&biw=1133&ved=0ahUKEwjw2rP8rqDaAhVGZFAKHYZIDJkQMwjUASgBMAE&iact=c&ictx=1"
                    }
                };
            }
        }

        public IEnumerable<Product> PreferredProducts { get; }

        public Product GetProductById(int productId)
        {
            throw new NotImplementedException();
        }
    }
}
