using System;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello Foundation2 World!");

        Address address1 = new Address("123 Steve Road", "Steve City", "Wisconsin", "United States");
        Customer customer1 = new Customer("Steve", address1);
        Product product11 = new Product("Milk", "2313", 3.99, 2);
        Product product12 = new Product("Eggs", "1927", 5.99, 1);
        List<Product> products1 = [product11, product12];
        Order order1 = new Order(customer1, products1, 0, "37135", "222-313");
        Console.WriteLine($"Packaging Label: {order1.GetPackagingLabel()}");
        Console.WriteLine($"Shipping Label: {order1.GetShippingLabel()}");
        Console.WriteLine($"Total Cost: {order1.CalcualteCost()}");
        
        Address address2 = new Address("123 Taco Road", "Mexico City", "Mexico City", "Mexico");
        Customer customer2 = new Customer("Jose", address2);
        Product product21 = new Product("Milk", "2313", 3.99, 2);
        Product product22 = new Product("Eggs", "1927", 5.99, 1);
        Product product23 = new Product("Cheese", "2519", 2.99, 3);
        List<Product> products2 = [product21, product22, product23];
        Order order2 = new Order(customer2, products2, 0, "47832", "845-935");
        Console.WriteLine($"Packaging Label: {order2.GetPackagingLabel()}");
        Console.WriteLine($"Shipping Label: {order2.GetShippingLabel()}");
        Console.WriteLine($"Total Cost: {order2.CalcualteCost()}");
    }
}