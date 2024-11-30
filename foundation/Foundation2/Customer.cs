public class Customer
{   

    // Private member variables for customer details
    private string _name;
    private Address _address;

    // Constructor to initialize customer details
    public Customer(string name, Address address)
    {
        _name = name;
        _address = address;
    }
    
    // Method to check if the customer resides in the USA
    public bool LivesInUSA()
    {
        return _address.IsInUSA();
    }
    
    // Public properties to access private mmeber variables
    public string Name => _name;
    public Address Address => _address;
}