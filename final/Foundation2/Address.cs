namespace Foundation2;
//  - Contains a string for the street address, the city, state/province, and country.

public class Address
{
    private string _address;
    private string _city;
    private string _provinceOrState;
    private string _postCode;
    private string _country;

    public Address() { }
    // Has a method to return a string all of its fields together in one string
    // (with newline characters where appropriate)
    public string GetAddress()
    {
        string theAddress = $"{_address}\n{_city}, {_provinceOrState}, {_postCode}, {_country}";
        
        return theAddress;
    }

    public void SetAddress(string address, string city, string provinceOrState, string postCode, string country)
    {
        _address = address;
        _city = city;
        _provinceOrState = provinceOrState;
        _postCode = postCode;
        _country = country;

    }

    // Has a method that can return whether it is in the USA or not.
    public bool IsInUSA(string country)
    {
        if(country != "USA")
        {
            return false;
        }
        else
        {
            return true;
        }

    }


}
