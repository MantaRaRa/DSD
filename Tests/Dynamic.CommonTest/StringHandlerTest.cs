using Dynamic.Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Dynamic.CommonTest
{
    [TestClass]
    public class StringHandlerTest
    {
        [TestMethod]
        public void InsertSpacesTestValid()
        {
            //Arrange
            var source = "DynamicSelfDefense";
            var expected = "Dynamic Self Defense";
            var handler = new StringHandler();

            // Act
            var actual = handler.InsertSpaces(source);

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void InsertSpacesTestWithExistingSpace()
        {
            //Arrange
            var source = "Dynamic Self Defense";
            var expected = "Dynamic Self Defense";
            var handler = new StringHandler();

            // Act
            var actual = handler.InsertSpaces(source);

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
