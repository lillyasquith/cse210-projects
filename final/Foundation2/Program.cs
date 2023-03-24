using System;

class Program
{
    static void Main(string[] args)
    {
        Product product = new Product("skinny Jean", "0024SJ", 45, 1);
        product.DisplayProduct();
        Console.WriteLine(product.ProductFee());

        Address address = new Address("100 N 100 E", "Provo", "UT", "USA");
        //address.DisplayAddress();
        Customer customer = new Customer("Tony", address);
        customer.DisplayCustomer();
    }
}