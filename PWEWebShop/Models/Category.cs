using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PWEWebShop.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public Shop TheShop;
        public List<Product> Products;
        public List<Category> SubCategories { get; set; }

        public Category()
        {
            //TheShop = myShop;
            Products = new List<Product>();
            SubCategories = new List<Category>();
        }

        public void AddProduct (Product product)
        {
            Products.Add(product);
        }

        public Product FindProduct (int Id)
        {
            foreach (Product myFoundProduct in Products)
            {
                if(myFoundProduct.Id == Id)
                {
                    return myFoundProduct;
                }
            }
            return null;
        }
    }
}
