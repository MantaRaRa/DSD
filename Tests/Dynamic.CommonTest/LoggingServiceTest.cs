using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Dynamic.Common;
using DSD.BL;

namespace Dynamic.CommonTest
{
    [TestClass]
    public class LoggingServiceTest
    {
        [TestMethod]
        public void WriteToFileTest()
        {
            // Arrange
            var changedItems = new List<ILoggable>();

            var customer = new Customer(1)
            {
                EmailAddress = "eversong@gmail.com",
                FirstName = "EverSong",
                LastName = "Berry",
                AddressList = null
            };
            changedItems.Add(customer);

            var product = new Product(2)
            {
                ProductName = "TerraSoma",
                ProductDescription = "VR Learning Software",
                CurrentPrice = 45
            };
            changedItems.Add(product);

            // Act
            LoggingService.WriteToFile(changedItems);

            // Assert
            // Nothing here to assert
        }
    }
}
