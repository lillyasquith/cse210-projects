using System;

class Program
{
    static void Main(string[] args)
    {
        Product product = new Product("skinny Jean", "0024SJ", 45, 1);
        product.DisplayProduct();
        Console.WriteLine(product.ProductFee());

    }
}