using ACM.BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace ACM.BLTest
{
    [TestClass]
    public class CustomerTest
    {
        [TestMethod]
        public void FullNameTestValid()
        {
            //--Arrange
            Customer customer = new Customer
            {
                firstName = "Clown",
                lastName = "AmogUS"
            };
            string expected = "Clown, AmogUS";
            //--Act
            string actual = customer.fullName;
            //--Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void FullNameFirstNameTestValid()
        {
            //--Arrange
            Customer customer = new Customer
            {
                firstName = "Clown",
            };
            string expected = "Clown";
            //--Act
            string actual = customer.fullName;
            //--Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void FullNameLastNameTestValid()
        {
            //--Arrange
            Customer customer = new Customer
            {
                lastName = "AmogUS"
            };
            string expected = "AmogUS";
            //--Act
            string actual = customer.fullName;
            //--Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CustomerInstanceCountTestValid()
        {
            //--Arrange
            var customer1 = new Customer();
            customer1.firstName = "Dok";
            Customer.instanceCount += 1;

            var customer2 = new Customer();
            customer2.firstName = "Dok1";
            Customer.instanceCount += 1;

            var customer3 = new Customer();
            customer3.firstName = "Dok2";
            Customer.instanceCount += 1;
            //--Act
            //--Assert
            Assert.AreEqual(3, Customer.instanceCount);
        }

        [TestMethod]
        public void ValidateValid()
        {
            //--Arrange
            var customer = new Customer
            {
                lastName = "Bob",
                emailAdress = "bob@pes.dog"
            };

            var expected = true;
            //--Act
            var actual = customer.Validate();
            //--Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
