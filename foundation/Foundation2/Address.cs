public class Address
{   
    // Private member variables for address details
    private string _streetAddress;
    private string _city;
    private string _stateProvince;
    private string _country;

    // Constructor to initialize address details
    public Address(string streetaddress, string city, string stateProvince, string country)
    {
        _streetAddress = streetaddress;
        _city = city;
        _stateProvince = stateProvince;
        _country = country;
    }

    // Method to determine if the address is in the USA
    public bool IsInUSA()
    {
        return _country.Equals("USA", StringComparison.OrdinalIgnoreCase);
    }

    // Method to return the full adddress as a formatted string
    public string FullAddress()
    {
        return $"{_streetAddress}\n{_city}, {_stateProvince}\n{_country}";
    }
}