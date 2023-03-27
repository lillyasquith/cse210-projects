using System;

class Program
{
    static void Main(string[] args)
    {
        //test-------------------------------------------------------------
        // Product product1 = new Product("Skinny Jean", "0024SJ", 45, 2);
        // product1.DisplayProduct();
        // Console.WriteLine(product1.ProductFee());
        // Address address1 = new Address("100 N 100 E", "Provo", "UT", "USA");
        // Customer customer1 = new Customer("Tony Goodman", address1);
        // customer1.DisplayCustomer();
        // Order order = new Order(customer1);
        // order.AddProduct(product1);
        // Console.WriteLine(order.ShippingCost());
        // Console.WriteLine(order.OrderTotal());

        //test---------------------------------------------------------------
        // Product product2 = new Product("Blue Sweatshirt", "0003BS", 35, 1);
        // product2.DisplayProduct();
        // Product product3 = new Product("Bomber Jacket", "001XZY", 180, 1);
        // product3.DisplayProduct();
        // Console.WriteLine(product2.ProductFee());
        // Console.WriteLine(product3.ProductFee());
        // Address address2 = new Address("123 Main Street", "Montreal", "QC", "Canada");
        // Customer customer2 = new Customer("John White", address2);
        // customer2.DisplayCustomer();
        // Order order2 = new Order(customer2);
        // order2.AddProduct(product2);
        // order2.AddProduct(product3);
        // Console.WriteLine(order2.ShippingCost());
        // // //need to add a product to a list
        // Console.WriteLine(order2.OrderTotal());

        Product product1 = new Product("Skinny Jean", "0024SJ", 45, 2);
        Address address1 = new Address("100 N 100 E", "Provo", "UT", "USA");
        Customer customer1 = new Customer("Tony Goodman", address1);
        Order order1 = new Order(customer1);
        order1.AddProduct(product1);
        order1.PackingLabel();
        Console.WriteLine($"Shipping: ${order1.ShippingCost()}");
        Console.WriteLine($"Subtotal: ${order1.OrderTotal()}");
        order1.ShippingLabel(customer1);

        Console.WriteLine();
        Console.WriteLine($"---------------------");
        Product product2 = new Product("Blue Sweatshirt", "0003BS", 35, 1);
        Product product3 = new Product("Bomber Jacket", "001XZY", 180, 1);
        Address address2 = new Address("123 Main Street", "Montreal", "QC", "Canada");
        Customer customer2 = new Customer("John White", address2);
        Order order2 = new Order(customer2);
        order2.AddProduct(product2);
        order2.AddProduct(product3);
        order2.PackingLabel();
        Console.WriteLine($"Shipping: ${order2.ShippingCost()}");
        Console.WriteLine($"Subtotal: ${order2.OrderTotal()}");
        order2.ShippingLabel(customer2);
    }
}