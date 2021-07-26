using Retekus.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class Product : EntityBase, ILoggable
    {
        public Product()
        {
        }
        public Product(int inputProductID)
        {
            productID = inputProductID;
        }
        public decimal? currentPrice { get; set; }
        public int productID { get; private set; }
        public string productDescription { get; set; }
        private string _productName;
        public string productName
        {
            get
            {
                return _productName.InsertSpaces();
            }
            set
            {
                _productName = value;
            }
        }
        public override string ToString() => productName;

        public Product Retrive(int productID)
        {
            return new Product();
        }

        public List<Product> Retrive()
        {
            return new List<Product>();
        }

        public bool Save()
        {
            return true;
        }

        public string log() =>
    $" {productID}: {productName} Description: {productDescription} Status: {entityState.ToString()}";


        public override bool Validate()
        {
            var isValid = true;

            if (string.IsNullOrWhiteSpace(productDescription)) isValid = false;
            if (currentPrice == null) isValid = false;

            return isValid;
        }

    }
}
