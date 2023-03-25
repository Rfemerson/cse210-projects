using System;

class Program
{
    static void Main(string[] args)
    {
        Product product1 = new Product("Widget", 1, 2.50m, 2);
        Product product2 = new Product("Gizmo", 2, 1.75m, 3);
        Product product3 = new Product("Thingamajig", 3, 3.00m, 1);

        Address address1 = new Address("123 Main St", "Anytown", "CA", "USA");
        Address address2 = new Address("456 Oak St", "Somewhere", "BC", "Canada");

        Customer customer1 = new Customer("Emerson", address1);
        Customer customer2 = new Customer("Ana", address2);

        Order order = new Order(customer1);
        order.AddProduct(product1);
        order.AddProduct(product2);
        order.AddProduct(product3);

        Order order2 = new Order(customer2);
        order2.AddProduct(product2);
        order2.AddProduct(product3);

        Console.WriteLine("Packing labels:");
        Console.WriteLine(order.GetPackingLabel());
        Console.WriteLine(order2.GetPackingLabel());

        Console.WriteLine("Shipping labels:");
        Console.WriteLine(order.GetShippingLabel());
        Console.WriteLine(order2.GetShippingLabel());

        Console.WriteLine($"Total price of order 1: {order.CalculateTotalCost():C}");
        Console.WriteLine($"Total price of order 2: {order2.CalculateTotalCost():C}");

        Console.ReadLine();
    }
}