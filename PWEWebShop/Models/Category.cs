using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PWEWebShop.Models
{
    public class Category
    {
        public int Id { get; }
        public string Name { get; set; }
        public string Description { get; set; }
        private Shop shop;
        private List<Product> products;

        public Category()
        {
            products = new List<Product>();
        }
    }
}
