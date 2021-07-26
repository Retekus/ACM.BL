using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class CustomerRepository
    {
        public CustomerRepository()
        {
            adressRepository = new AdressRepository(); //collavorative
        }
        private AdressRepository adressRepository { get; set; }

        public Customer Retrive(int customerID)
        {
            Customer customer = new Customer(customerID);
            if(customerID == 1)
            {
                customer.firstName = "Bob";
                customer.lastName = "2";
                customer.emailAdress = "Dock@pes.dog";
                customer.adressList = adressRepository.retriveByCustomerID(customerID).ToList(); //collavorative
            }
            return customer;
        }
        public bool Save()
        {
            return true;
        }
    }
}
