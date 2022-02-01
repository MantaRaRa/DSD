using System.Collections.Generic;

namespace DSD.BL
{
  public class AddressRepository
  {
    /// <summary>
    /// Retrieve one address.
    /// </summary>
    public Address Retrieve(int addressId)
    {
      // Create the instance of the Address class
      // Pass in the requested Id
      Address address = new Address(addressId);

      // Code that retrieves the defined address

      // Temporary hard coded values to return 
      // a populated address
      if (addressId == 1)
      {
        address.AddressType = 1;
        address.StreetLine1 = "3230";
        address.StreetLine2 = "Martel Dr";
        address.City = "Grayson";
        address.State = "OH";
        address.Country = "USA";
        address.PostalCode = "40520";

      }
      return address;
    }

    public IEnumerable<Address> RetrieveByCustomerId(int customerId)
    {
      // Code that retrieves the defined addresses
      // for the customer.


      // Temporary hard-coded values to return 
      // a set of addresses for a customer
      var addressList = new List<Address>();
      Address address = new Address(1)
      {
        AddressType = 1,
        StreetLine1 = "3230",
        StreetLine2 = "Martel Dr",
        City = "Grayson",
        State = "OH",
        Country = "USA",
        PostalCode = "40520"
      };
      addressList.Add(address);

      address = new Address(2)
      {
        AddressType = 2,
        StreetLine1 = "150 Gray Loop",
        City = "Lexington",
        State = "CA",
        Country = "USA",
        PostalCode = "45419"
      };
      addressList.Add(address);

      return addressList;
    }

    /// <summary>
    /// Saves the current address.
    /// </summary>
    /// <returns></returns>
    public bool Save(Address address)
    {
            var success = true;

            if (address.HasChanges)
            {
                if (address.IsValid)
                {
                    if (address.IsNew)
                    {
                        // Call an Insert Stored Procedure

                    }
                    else
                    {
                        // Call an Update Stored Procedure
                    }
                }
                else
                {
                    success = false;
                }
            }
            return success;
        }
  }
}
