using PWEWebShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PWEWebShop.DAL
{
    public class CategoryRepository
    {
        private List<Category> allCategories;

        public CategoryRepository()
        {
            allCategories = new List<Category>();
        }

        public void Save(Category category)
        {
            allCategories.Add(category);
        }

        public Category FindCategory (int Id)
        {
            foreach (Category myFoundCategory in allCategories)
            {
                if(myFoundCategory.Id == Id)
                {
                    return myFoundCategory;
                }
            }
            return null;
        }
    }
}
