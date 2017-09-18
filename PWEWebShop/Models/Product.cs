using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PWEWebShop.Models
{
    public class Product
    {
        public int Id { get; }
        public string SKU { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public  string Price { get; set; }
        private List<Category> categories;

        private Category myCategory;

        public Product(Category parentCategory)
        {
            myCategory = parentCategory;
            categories = new List<Category>();
        }
    }
}
