using PWEWebShop.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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

        public void SaveCategory(Category category)
        {
            //save the category to the database here
            //1st step. set up and configure connection ADO.NET
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = "Server=DESKTOP-PVFC580\SQLEXPRESS;Database=PWEWebShop;Integrated Secturity=SSPI;";
            try
            {
                //1.5 step. open the connection
                connection.Open();
                //2nd step. set up and write sql command
                SqlCommand mySqlCommand = connection.CreateCommand();
                mySqlCommand.CommandText = "insert into Category(Name, Description) values('" + category.Name + "', '" + category.Description + "')";
                //3rd step. execute the sql command
                mySqlCommand.ExecuteNonQuery();
                //4th step. close the connection
                connection.Close();
            }
            catch(Exception ex)
            {
                connection.Close();
            }
        }

        public void UpdateCategory(Category category)
        {
            //update the category here
        }

        public void DeleteCategory(int categoryId)
        {
            //delete the category from the database here
        }

        public Category LoadCategory(int id)
        {
            //return null, I will get back later on
            //this method is for loading a single catefgory
            // like for the edit category page in our real webshop
            return null;
        }

        public List<Category> LoadAllCategories()
        {
            //This is for  loading all the categories
            //shoud i sor this alphabetically?
            return null;
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
