using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using Retekus.Common;
using ACM.BL;

namespace Retekus.MainTest
{
    [TestClass]
    public class LoggingServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            //--Arrange
            var changeItems = new List<ILoggable>();
            var customer = new Customer(3)
            {
                emailAdress = "Email1",
                firstName = "bob",
                lastName = "tod",
                adressList = null
            };
            changeItems.Add(customer);

            var product = new Product(2)
            {
                productName = "sun",
                productDescription = "sadfsdf",
                currentPrice = 34M
            };
            changeItems.Add(product);

            //--Act
            LoggingService.WriteToFile(changeItems);

            //--Assert
        }
    }
}
