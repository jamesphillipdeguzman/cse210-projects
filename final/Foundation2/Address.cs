namespace Foundation2;
//  - Contains a string for the street address, the city, state/province, and country.

public class Address
{
    private string _address;
    private string _city;
    private string _provinceOrState;
    private string _country;

    public Address() { }
    // Has a method to return a string all of its fields together in one string
    // (with newline characters where appropriate)
    public void GetAddress() { }

    // Has a method that can return whether it is in the USA or not.
    public bool IsInUSA()
    {
        return false;
    }


}
