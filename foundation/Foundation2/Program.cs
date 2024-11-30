using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Foundation2 World!");

        // Create addresses for customers
        Address address1 = new Address("123 Elm St", "Springfield", "IL", "USA");
        Address address2 = new Address("321 Lehi St", "Utah", "UT", "USA");

        // Create customers with their address
        Customer customer1 = new Customer("John Doe", address1);
        Customer customer2 = new Customer("Jane Smith", address2);

        // Create products with their details
        Product product1 = new Product("Widget A", "001", 3.00m, 5);
        Product product2 = new Product("Widget B", "002", 4.50m, 3);
        Product product3 = new Product("Gadget C", "003", 10.00m, 2);

        // Create orders for each customer
        Order order1 = new Order(customer1);
        order1.AddProduct(product1);
        order1.AddProduct(product2);

        Order order2 = new Order(customer2);
        order2.AddProduct(product3);

        // Display the details of each order
        DisplayOrderDetails(order1);
        DisplayOrderDetails(order2);
    }

    // Method to display packing label, shipping label, and
    // total price of an order
    public static void DisplayOrderDetails(Order order)
    {
        //Console.WriteLine("Packing Label:");
        Console.WriteLine(order.GetPackingLabel());
        //Console.WriteLine("Shipping Label:");
        Console.WriteLine(order.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order.CalculateTotalPrice():F2}");
        
        Console.WriteLine(); // Add a blank line for better separation
    }
}