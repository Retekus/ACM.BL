using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class Adress
    {
        public Adress()
        {
                
        }
        public Adress( int inputAdressID)
        {
            adressID = inputAdressID;
        }
        public int adressID { get; private set; }
        public int adressType { get; set; }
        public string country { get; set; }
        public string city { get; set; }
        public string postalCode { get; set; }
        public string state { get; set; }
        public string streetLine1 { get; set; }
        public string streetLine2 { get; set; }

        public bool Validate()
        {
            var isValid = true;

            if (postalCode == null) isValid = false;

            return isValid;
        }
    }
}
