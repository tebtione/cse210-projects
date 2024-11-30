public class Product
{   
    // Private member variables for product details
    private string _name;
    private string _productId;
    private decimal _price;
    private int _quantity;

    // Constructor to initialize product details
    public Product(string name, string productId, decimal price, int quantity)
    {
        _name = name;
        _productId = productId;
        _price = price;
        _quantity = quantity;
    }
    
    // Method to calculate the total cost of the product
    public decimal TotalCost()
    {
        return _price * _quantity;
    }

    // Public properties to accesss private member variables
    public string Name => _name;
    public string ProductId => _productId;
}