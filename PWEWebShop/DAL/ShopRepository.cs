using PWEWebShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PWEWebShop.DAL
{
    //classes build to help us build stuff
    public class ShopRepository
    {
        private List<Shop> allShops;

        public ShopRepository()
        {
            allShops = new List<Shop>();
        }

        public void Save(Shop shop)
        {
            //saving the shop
            allShops.Add(shop);
        }

        public Shop FindShop(string name)
        {
            //for each loop to find the shop
            if(allShops == null)
            {
                //this is broken the list is null
                //i know its an error
                throw new Exception("This list is null");
            }
            //continue
            foreach (Shop myFoundShop in allShops)
            {
                if(myFoundShop.Name == name)
                {
                    return myFoundShop;
                }
            }
            return null;
        }

        public void  EditShop(string name, string newName, string newAddress, string newZip, string newCity, string newPhone, string newEmail, string newCVR)
        {
            Shop shopToEdit = FindShop(name);
            shopToEdit.Name = newName;
            shopToEdit.Address = newAddress;
            shopToEdit.Zip = newZip;
            shopToEdit.City = newCity;
            shopToEdit.Phone = newPhone;
            shopToEdit.Email = newEmail;
            shopToEdit.CVR = newCVR;
        }

        public void DeleteShop(string name)
        {
            Shop shopToDelete = FindShop(name);
            allShops.Remove(shopToDelete);
        }
    }
}
