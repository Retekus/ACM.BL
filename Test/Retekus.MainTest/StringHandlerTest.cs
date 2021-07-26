using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Retekus.Common;

namespace Retekus.MainTest
{
    [TestClass]
    public class StringHandlerTest
    {
        [TestMethod]
        public void InsertSpacesValidTest()
        {
            var source = "Somic Screw Pew";
            var expected = "Somic Screw Pew";


            var actual = source.InsertSpaces();

            Assert.AreEqual(expected, actual); 
        }
    }
}
