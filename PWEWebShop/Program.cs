using PWEWebShop.DAL;
using PWEWebShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PWEWebShop
{
    class Program
    {
        static void Main(string[] args)
        {
            //create the repositories to help us out
            ShopRepository shopRepository = new ShopRepository();
            //create the shop
            Shop myShop = new Shop();
            //save the sop in the repository
            shopRepository.Save(myShop);
            //create some customers
            Customer customer1 = new Customer(myShop);
            customer1.Name = "First Customer";
            customer1.Address = "The street";
            myShop.Customers.Add(customer1);
            // Create a category
            Category shirstsCategory = new Category(myShop);
            shirstsCategory.Id = 1;
            shirstsCategory.Name = "Shirts";
            shirstsCategory.Description = "This is the description";
            //add it to the shop
            myShop.Categories.Add(shirstsCategory);
            //create a new product
            Product whiteShirt = new Product(shirstsCategory);
            whiteShirt.Description = "Nice white shirt";
            whiteShirt.Id = 1;
            whiteShirt.Name = "White Shity";
            whiteShirt.Price = 99;
            whiteShirt.SKU = "WS1234";
            //add it to the category
            shirstsCategory.Products.Add(whiteShirt);
        }
    }
}
