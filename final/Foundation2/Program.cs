using System;

class Program
{
    static void Main(string[] args)
    {
        Product product = new Product("Skinny Jean", "0024SJ", 45, 2);
        product.DisplayProduct();
        Console.WriteLine(product.ProductFee());

        Address address = new Address("100 N 100 E", "Provo", "UT", "USA");
        Customer customer = new Customer("Tony Goodman", address);
        customer.DisplayCustomer();

        Order order = new Order(customer);
        Console.WriteLine(order.OrderTotal(product));
    }
}