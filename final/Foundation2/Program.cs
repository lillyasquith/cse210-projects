using System;

class Program
{
    static void Main(string[] args)
    {
        Product product1 = new Product("Skinny Jean", "0024SJ", 45, 2);
        product1.DisplayProduct();
        Console.WriteLine(product1.ProductFee());
        Address address1 = new Address("100 N 100 E", "Provo", "UT", "USA");
        Customer customer1 = new Customer("Tony Goodman", address1);
        customer1.DisplayCustomer();
        Order order = new Order(customer1);
        Console.WriteLine(order.OrderTotal(product1));

        Product product2 = new Product("Blue Sweatshirt", "0003BS", 35, 1);
        product2.DisplayProduct();
        Product product3 = new Product("Bomber Jacket", "001XZY", 180, 1);
        product3.DisplayProduct();
        Console.WriteLine(product2.ProductFee());
        Address address2 = new Address("123 Main Street", "Montreal", "QC", "Canada");
        Customer customer2 = new Customer("John White", address2);
        customer2.DisplayCustomer();
        Order order2 = new Order(customer2);
        //need to add a product to a list
        Console.WriteLine(order.OrderTotal(product2));


    }
}