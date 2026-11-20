using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Order 1 (USA Customer)

        Address address1 = new Address(
            "123 Main Street",
            "Phoenix",
            "Arizona",
            "USA");

        Customer customer1 = new Customer(
            "John Smith",
            address1);

        List<Product> products1 = new List<Product>()
        {
            new Product("Laptop", "P100", 800, 1),
            new Product("Mouse", "P101", 25, 2),
            new Product("Keyboard", "P102", 40, 1)
        };

        Order order1 = new Order(customer1, products1);

        // Order 2 (International Customer)

        Address address2 = new Address(
            "45 Avenida Reforma",
            "Guatemala City",
            "Guatemala",
            "Guatemala");

        Customer customer2 = new Customer(
            "Henry Lopez",
            address2);

        List<Product> products2 = new List<Product>()
        {
            new Product("Monitor", "P200", 250, 2),
            new Product("Headset", "P201", 75, 1),
            new Product("Webcam", "P202", 50, 1)
        };

        Order order2 = new Order(customer2, products2);

        DisplayOrder(order1, "ORDER 1");
        DisplayOrder(order2, "ORDER 2");
    }

    static void DisplayOrder(Order order, string orderName)
    {
        Console.WriteLine($"===== {orderName} =====");

        Console.WriteLine("\nPACKING LABEL:");
        Console.WriteLine(order.GetPackingLabel());

        Console.WriteLine("SHIPPING LABEL:");
        Console.WriteLine(order.GetShippingLabel());

        Console.WriteLine($"\nTOTAL COST: ${order.GetTotalCost():F2}");

        Console.WriteLine("\n-------------------------\n");
    }
}