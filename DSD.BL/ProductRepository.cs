using System;

namespace DSD.BL
{
    public class ProductRepository
    {
        /// <summary>
        /// Retrieve one product.
        /// </summary>
        public Product Retrieve(int productId)
        {
            /// Create the instance of the Product class
            /// pass in the requested id
            Product product = new Product(productId);

            /// Code the retrieves the defined product
            
            /// Temporary hard-coded values to return
            /// a populated product
            if (productId == 2)
            {
                product.ProductName = "TerraSoma";
                product.ProductDescription = "VR Learning Software";
                product.CurrentPrice = 45;
            }
            return product;
        }
        /// <summary>
        /// Saves the current product.
        /// </summary>
        /// <returns></returns>
        public bool Save(Product product)
        {
            ///Code that saves the passed in product

            return true;
        }
    }
}
