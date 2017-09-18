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
        private List<Category> categories;
        private List<Customer> customers;

        //creating the constructor for the Shop class
        public Shop()
        {
            categories = new List<Category>();
            customers = new List<Customer>();
        }
    }
}
