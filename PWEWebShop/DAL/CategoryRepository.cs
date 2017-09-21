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
            connection.ConnectionString = "Server=DESKTOP-PVFC580\\SQLEXPRESS;Database=PWEWebShop;Integrated Security=SSPI;";
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

        public void UpdateCategory(Category category, int categoryId)
        {
            //update the category here            
            //1st step set up and confugire connection ADO.NEW
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = "Server=DESKTOP-PVFC580\\SQLEXPRESS;Database=PWEWebShop;Integrated Security=SSPI;";

            try
            {
                //1.5 open the connection
                connection.Open();
                //2. set up and write the sql command
                SqlCommand mySqlCommand = connection.CreateCommand();
                mySqlCommand.CommandText = "update Category set Name = '" + category.Name + "' , Description = '" + category.Description + "' where Id = "+ categoryId + " ";
                //3 execute the sql command 
                mySqlCommand.ExecuteNonQuery();
                //4 lose the connection
                connection.Close();
            }
            catch(Exception ex)
            {
                connection.Close();
            }
        }

        public void DeleteCategory(int categoryId)
        {
            //delete the category from the database here
            //sql: delete from category where id = 1;

            //1st step. set up and configure connection ADO.NET(library to help us connect to different databases)
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = "Server=DESKTOP-PVFC580\\SQLEXPRESS;Database=PWEWebShop;Integrated Security=SSPI;";
            			
            try
            {
                //1.5 step. open the connection
                connection.Open();
                //2nd step. set up and write sql command
                SqlCommand mySqlCommand = connection.CreateCommand();
                mySqlCommand.CommandText = "Delete from Category where id = " + categoryId;
                //3rd step. execute the sql command
                mySqlCommand.ExecuteNonQuery();
                //4th step. close the connection
                connection.Close();	
            }
            catch (Exception ex)
            {
                connection.Close();
            }

        }

        public Category LoadCategory(int categoryId)
        {
            Category resultCategory = new Category();
            //return null, I will get back later on
            //this method is for loading a single category
            // like for the edit category page in our real webshop

            //1st step. set up and configure connection ADO.NET(library to help us connect to different databases)
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = "Server=DESKTOP-PVFC580\\SQLEXPRESS;Database=PWEWebShop;Integrated Security=SSPI;";
            try
            {
                //1.5 step. open the connection
                connection.Open();
                //2nd step. set up and write sql command
                SqlCommand mySqlCommand = connection.CreateCommand();
                mySqlCommand.CommandText = "select Id, Name, Description from Category where id = " + categoryId;
                //3rd step. SqlReader, loop through all of them and create objects
                SqlDataReader reader = mySqlCommand.ExecuteReader();
                while (reader.Read())
                {
                    resultCategory.Id = reader.GetInt32(0);
                    resultCategory.Name = reader.GetString(1);
                    resultCategory.Description = reader.GetString(2);
                }
                //4th step. close the connection
                connection.Close();
            }
            catch(Exception ex)
            {
                connection.Close();
            }

            return resultCategory;
        }

        public List<Category> LoadAllCategories()
        {
            //create a list to store categories and then return it in the end
            List<Category> resultCategories = new List<Category>();
            //This is for  loading all the categories
            //shoud i sor this alphabetically?

            //1st step. SqlConnection, open and cofigure
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = "Server=DESKTOP-PVFC580\\SQLEXPRESS;Database=PWEWebShop;Integrated Security=SSPI;";
            try
            {
                //1.5th step. 
                connection.Open();
                //2nd step. SqlCommand, select SQL
                SqlCommand command = connection.CreateCommand();
                command.CommandText = "select Id, Name, Description from Category";
                //3rd step. SqlReader, loop through all of them and create objects
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Category myCategoryFromDatabase = new Category();
                    myCategoryFromDatabase.Id = reader.GetInt32(0);
                    myCategoryFromDatabase.Name = reader.GetString(1);
                    myCategoryFromDatabase.Description = reader.GetString(2);
                    //adding the category to the list
                    resultCategories.Add(myCategoryFromDatabase);
                }
                //4th step. closing the connection
                connection.Close();
            }
            catch(Exception ex)
            {
                connection.Close();
                //something is wrong
            }
            //5th step. Return the list of categories

            return resultCategories;
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
