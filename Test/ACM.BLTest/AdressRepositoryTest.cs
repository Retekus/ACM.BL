using ACM.BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace ACM.BLTest
{
    [TestClass]
    public class AdressRepositoryTest
    {
        [TestMethod]
        public void RetriveExistingWithAdress()
        {
            //--Arrange
            var customerRepository = new CustomerRepository();
            var expected = new Customer(1)
            {
                emailAdress = "Dock@pes.dog",
                adressList = new List<Adress>()
                {
                    new Adress()
                    {
                        country = "1"
                    },
                    new Adress()
                    {
                        country = "2"
                    }

                }
            };
            //--Act
            var actual = customerRepository.Retrive(1);
            //--Assert
            Assert.AreEqual(expected.emailAdress, actual.emailAdress);
            for (int i = 0; i < 1; i++)
            {
                Assert.AreEqual(expected.adressList[i].country, actual.adressList[i].country);
            }
        }
    }
}
