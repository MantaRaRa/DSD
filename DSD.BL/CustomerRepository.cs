using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSD.BL
{
    public class CustomerRepository
    {
        /// <summary>
        /// Retrieve one customer.
        /// </summary>
        public Customer Retrieve(int customerId)
        {
            /// Create the instance of the Customer class
            /// pass in the requested id
            Customer customer = new Customer(customerId);

            /// Code the retrieves the defined customer
            
            /// Temporary hard-coded values to return
            /// a populated customer
            if (customerId == 1)
            {
                customer.EmailAddress = "EverSong@gmail.com";
                customer.FirstName = "EverSong";
                customer.LastName = "Berry";
            }
            return customer;
        }
        /// <summary>
        /// Saves the current customer.
        /// </summary>
        /// <returns></returns>
        public bool Save(Customer customer)
        {
            ///Code that saves the passed in customerk

            return true;
        }
    }
}
