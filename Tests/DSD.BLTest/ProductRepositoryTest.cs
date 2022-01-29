using DSD.BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DSD.BLTest
{
    [TestClass()]
    public class ProductRepositoryTest
    {
        [TestMethod()]
        public void RetrieveTest()
        {
         //-- Arrange
            var productRepository = new ProductRepository();
            var expected = new Product(2)
            {
                CurrentPrice = 50,
                ProductDescription = "VR Learning Software",
                ProductName = "TerraSoma"
            };

         //-- Act
         var actual = productRepository.Retrieve(2);
         
         //--Assert
         Assert.AreEqual(expected.CurrentPrice, actual.CurrentPrice);
         Assert.AreEqual(expected.ProductDescription, actual.ProductDescription);
         Assert.AreEqual(expected.ProductName, actual.ProductName);
         
        }
    }
}
