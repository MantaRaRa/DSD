using System;

namespace DSD.BL
{
    public class OrderRepository
    {
        /// <summary>
        /// Retrieve one order.
        /// </summary>
        public Order Retrieve(int orderId)
        {
            /// Create the instance of the Order class
            /// pass in the requested id
            Order order = new Order(orderId);

            /// Code the retrieves the defined order
            
            /// Temporary hard-coded values to return
            /// a populated order
            if (orderId == 10)
            {
                // Use current year in hard-coded data
                order.OrderDate = new DateTimeOffset
                    (DateTime.Now.Year, 4, 14, 10, 22, 22, new TimeSpan(7, 0, 0));
            }
            return order;
        }
        /// <summary>
        /// Saves the current product.
        /// </summary>
        /// <returns></returns>
        public bool Save(Order order)
        {
            ///Code that saves the passed in order

            return true;
        }
    }
}
