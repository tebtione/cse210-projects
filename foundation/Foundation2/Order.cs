using System.Collections.Generic;

public class Order
{
    // Private member variables
    private List<Product> _products;
    private Customer _customer;

    // Constructor to initialize order with a customer
    public Order(Customer customer)
    {
        _customer = customer;
        _products = new List<Product>();
    }

    // Method to add a product to the order
    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    // Method to calculate the total price of the order
    public decimal CalculateTotalPrice()
    {
        decimal total = 0;
        foreach (var product in _products) // List all products in the packing label
        {
            total += product.TotalCost();
        }
        total += _customer.LivesInUSA() ? 5.00m : 35.00m;
        return total;
    }

    // Method to generate the packing label for the order
    public string GetPackingLabel()
    {
        string label = "Packing Label:\n";
        foreach (var product in _products)
        {
            label += $"{product.Name} (ID: {product.ProductId})\n";
        }
        return label.Trim(); // Remove trailing newline  
    }

    // Method to generate the shipping label for the order
    public string GetShippingLabel()
    {
        return $"Shipping Label:\n{_customer.Name}\n{_customer.Address.FullAddress()}";
    }
}