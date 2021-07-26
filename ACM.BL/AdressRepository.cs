using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class AdressRepository
    {
        public static Adress Retrive(int adressID)
        {
            Adress adress = new Adress(adressID);
            if (adressID == 1)
            {
                adress.country = "Country1";
            }
            return adress;
        }

        public IEnumerable<Adress> retriveByCustomerID(int customerID)
        {
            var adressList = new List<Adress>();
            Adress adress = new Adress(1)
            {
                country = "1"
            };
            adressList.Add(adress);

            adress = new Adress(2)
            {
                country = "2"
            };
            adressList.Add(adress);
            return adressList;
        }
        public bool Save()
        {
            return true;
        }
    }
}
