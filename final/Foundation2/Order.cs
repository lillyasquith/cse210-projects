using System;

class Order
{
    List<Product> _products = new List<Product>();
    public Customer _customer;

    public Order(Customer customer)
    {

    }
    public int ShippingCost(Customer customer)
    {
        Customer cux = new Customer();
        int shippingfee = 0;
        bool check = _customer.CheckAddressUSA();
        if (check == true)
        {
            shippingfee += 5;
        }
        else
            shippingfee += 35;
        return shippingfee;
    }
    public int OrderTotal(Product product)
    {
        int orderTotal = product.ProductFee() + ShippingCost(_customer);
        return orderTotal;
    }
    public void PackingLabel()
    {

    }
    public void ShippingLabel()
    {

    }

}