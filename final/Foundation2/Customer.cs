using System.Diagnostics.Contracts;

namespace Foundation2;
// Contains a name and an address.
// The name is a string, but the Address is a class.
// Should have a method that can return whether they live in the USA or not.
// (Hint this should call a method on the address to find this.)

public class Customer
{
    private string _name;

    private Address _address = new Address();

    private string _recipient;
    private Address _address2 = new Address();

    public Customer() {}

    public Customer(string name, Address address, string recipient, Address address2)
    {
        string locatedInUSA = "";
        // _recipient = recipient;
        // _address2 = address2;
        SetCustomerInfo(name, address);
        string theAddress = _address.GetAddress();
        string[] parts = theAddress.Split(",");
        string country = parts[3].Trim();
        // Address address1 = new Address();
        bool isInUSA = address.IsInUSA(country);

        SetRecipientInfo(recipient, address2);
        string theAddress2 = _address2.GetAddress();
        string[] parts2 = theAddress2.Split(",");
        string country2 = parts2[3].Trim();
        // Address address3 = new Address();
        bool isInUSA2 = address2.IsInUSA(country2);

        if (isInUSA == true)
        {
            locatedInUSA = "Yes";
        }
        else
        {
            locatedInUSA = "No";
        }

        string customerInfo = $"{name}\n{theAddress}\nLocated in US: {locatedInUSA}";
        string customerInfo2 = $"{name}\n{theAddress}";

        Console.WriteLine(customerInfo2);

    }

    public string GetCustomerAddress()
    {
        return _address.GetAddress();
    }

    public string GetCustomerName()
    {
        return _name;
    }


    public void SetCustomerInfo(string name, Address address)
    {
        _name = name;
        _address = address;
    }

    public string GetRecipientAddress()
    {
        return _address2.GetAddress();
    }

    public string GetRecipientName()
    {
        return _recipient;
    }

    public void SetRecipientInfo(string recipient, Address address2)
    {
        _recipient = recipient;
        _address2 = address2;
    }

    // A method that returns whether the customer lives in the USA or not.
    public bool IsInUSA(string country)
    {
        if (country != "USA")
        {
            return false;
        }
        else
        {
            return true;
        }

    }
}
