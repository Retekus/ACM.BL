using ACM.BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace ACM.BLTest
{
    [TestClass]
    public class CustomerRepositoryTest
    {
        [TestMethod]
        public void RetriveValid()
        {
            var customerRepository = new CustomerRepository();
            var expected = new Customer(1)
            {
                firstName = "Bob",
                lastName = "Marley",
                emailAdress = "mariuanna@weeb.net"
            };

            var actual = customerRepository.Retrive(1);

            Assert.AreEqual(expected.firstName, actual.firstName);
        }
    }
}
