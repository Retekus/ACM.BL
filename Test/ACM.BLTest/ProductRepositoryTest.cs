using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ACM.BL;

namespace ACM.BLTest
{
    [TestClass]
    public class ProductRepositoryTest
    {
        [TestMethod]
        public void RetriveValid()
        {
            var productRepository = new ProductRepository();
            var expected = new Product(1)
            {
                productName = "Gum"
            };

            var actual = productRepository.Retrive(2);

            Assert.AreEqual(expected.productName, actual.productName);
        }
        [TestMethod()]
        public void SaveTestValid()
        {
            var productRepository = new ProductRepository();
            var updatedProduct = new Product(2)
            {
                productDescription = "ABOBUS",
                currentPrice = 10M,
                productName = "123",
                hasChanges = true
            };

            var actual = productRepository.Save(updatedProduct);

            Assert.AreEqual(true, actual);
        }

    }
}
