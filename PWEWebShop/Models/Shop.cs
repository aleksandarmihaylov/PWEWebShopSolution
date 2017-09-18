using PWEWebShop.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PWEWebShop.Models
{
    public class Shop
    {
        //creating the properties together with encapsulation
        public string Name { get; set; }
        public string Address { get; set; }
        public string Zip { get; set; }
        public string City { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string CVR { get; set; }
        public List<Category> Categories;
        public List<Customer> Customers;

        //creating the constructor for the Shop class
        public Shop()
        {
            Categories = new List<Category>();
            Customers = new List<Customer>();
        }

        public void AddCustomer (Customer customer)
        {
            Customers.Add(customer);
        }

        public Customer FindCustomer (int Id)
        {
            foreach (Customer myFoundCustomer in Customers)
            {
                if(myFoundCustomer.Id == Id)
                {
                    return myFoundCustomer;
                }
            }
            return null;
        }
    }
}
