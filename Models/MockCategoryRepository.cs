using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JennsClothingShop.Models
{
    public class MockCategoryRepository : ICategoryRepository
    {
        public IEnumerable<Category> AllCategories =>
            new List<Category>
            {new Category{CategoryId=1, CategoryName="Long Dresses", Description="All long dresses"},
             new Category{CategoryId=2, CategoryName="Short Dresses", Description="All short dresses"},
             new Category{CategoryId=3, CategoryName="Seasonal Dresses", Description="All seasonal dresses"}



            };
    }
}
