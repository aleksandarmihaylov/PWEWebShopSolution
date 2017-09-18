using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PWEWebShop.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string SKU { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        private Category TheCategory { get; set; }

        public Product(Category parentCategory)
        {
            TheCategory = parentCategory;
        }

        //public void AddCategory (Category category)
        //{
        //    categories.Add(category);
        //}

        //public Category FindCategory (int Id)
        //{
        //    foreach (Category myFoundCategory in categories)
        //    {
        //        if(myFoundCategory.Id == Id)
        //        {
        //            return myFoundCategory;
        //        }
        //    }
        //    return null;
        //}
    }
}
