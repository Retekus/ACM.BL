using Retekus.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class Customer : EntityBase, ILoggable
    {
        public Customer() : this(0)
        {

        }
        public Customer(int inputCustomerID)
        {
            customerID = inputCustomerID;
            adressList = new List<Adress>();
        }

        public List<Adress> adressList { get; set; }

        public string firstName { get; set; }

        public string lastName { get; set; }

        public string fullName
        {
            get
            {
                string fullName = firstName;
                if (!string.IsNullOrWhiteSpace(lastName))
                {
                    if (!string.IsNullOrWhiteSpace(fullName))
                    {
                        fullName += ", ";
                    }
                    fullName += lastName;
                }
                return fullName;
            }
        }

        public string emailAdress { get; set; }

        public int customerID { get; private set; }

        public int customerType { get; set; }

        public static int instanceCount { get; set; }

        public string log() =>
            $" {customerID}: {fullName} Email: {emailAdress} Status: {entityState.ToString()}";

        ///<summary>
        /// Validates the customer data
        /// </summary>
        /// <returns></returns>
        public override bool Validate()
        {
            var isValid = true;

            if (string.IsNullOrWhiteSpace(lastName)) isValid = false;
            if (string.IsNullOrWhiteSpace(emailAdress)) isValid = false;

            return isValid;
        }

        public bool Save()
        {
            return true;
        }

        public Customer Retrive(int customerID)
        {
            return new Customer(customerID);
        }

        public List<Customer> Retrive()
        {
            return new List<Customer>()
                ;
        }
    }
}
