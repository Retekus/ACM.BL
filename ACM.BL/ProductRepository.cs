using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class ProductRepository
    {

        public Product Retrive(int productID)
        {
            Product product = new Product(productID);
            if (productID == 2)
            {
                product.productName = "Gum";
            }
            WriteLines(product);
            return product;
        }


        public bool Save(Product product)
        {
            var success = true;

            if (product.hasChanges)
            {
                if (product.isValid)
                {
                    if (product.isNew)
                    {
                        //call the insert stored operation
                    }
                    else
                    {
                        //call update stored operation
                    }
                }
                else
                {
                    success = false;
                }
            }
            return success;
        }

        public void WriteLines(Product product)
        {
            Object myObject = new Object();
            Console.WriteLine($"Product: {myObject.ToString()}");
            Console.WriteLine($"Product: {product.ToString()}");
        }
        
    }
}
