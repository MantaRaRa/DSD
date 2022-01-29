using DSD.BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace DSD.BLTest
{
    [TestClass]
    public class CustomerRepositoryTest
    {
        [TestMethod]
        public void RetrieveValid()
        {
         //-- Arrange
            var customerRepository = new CustomerRepository();
            var expected = new Customer(1)
            {
                EmailAddress = "EverSong@gmail.com",
                FirstName = "EverSong",
                LastName = "Berry"
            };

         //-- Act
         var actual = customerRepository.Retrieve(1);
         
         //--Assert
         Assert.AreEqual(expected.CustomerId, actual.CustomerId);
         Assert.AreEqual(expected.EmailAddress, actual.EmailAddress);
         Assert.AreEqual(expected.FirstName, actual.FirstName);
         Assert.AreEqual(expected.LastName, actual.LastName);
        }
    }
}
