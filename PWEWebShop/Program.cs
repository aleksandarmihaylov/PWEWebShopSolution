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
            //test the save category to the database
            //1. Create a Category Repository
            CategoryRepository categoryRepository = new CategoryRepository();
            //2. Create a Category
            Category category = new Category();
            //category.Id = 1;
            category.Name = "Shirts";
            category.Description = "Fantastic Shirts for everyones";
            //3. Save/Update the Category through the Category Repository
            //categoryRepository.SaveCategory(category);
            //categoryRepository.UpdateCategory(category,2);
            // Delete the Category through the Category Repository where id is given
            //categoryRepository.DeleteCategory(1);

            //testing the load all method
            //List<Category> categories = categoryRepository.LoadAllCategories();
            //foreach (Category c in categories)
            //{
            //    Console.WriteLine("ID= " + c.Id);
            //    Console.WriteLine("Name= " + c.Name);
            //    Console.WriteLine("Description = " + c.Description);
            //    Console.WriteLine("------------------------");
            //}
            //Console.ReadLine();

            //testing the load single method
            Category myReturnedCategory = categoryRepository.LoadCategory(2);
            Console.WriteLine("ID= " + myReturnedCategory.Id);
            Console.WriteLine("Name= " + myReturnedCategory.Name);
            Console.WriteLine("Description = " + myReturnedCategory.Description);
            Console.ReadLine();
        }
    }
}
