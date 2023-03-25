using System;

class Order
{
    List<Product> _products = new List<Product>();
    public Customer _customer;

    public Order(Customer customer)
    {
        _customer = customer;
    }
    public int ShippingCost()//? why only return $5 for shipping
    {
        int shippingfee = 0;
        bool check = _customer.CheckAddressUSA();
        if (check == true)
        {
            shippingfee = 5;
            return shippingfee;
        }
        else
            shippingfee = 35;
        return shippingfee;
    }

    public int OrderTotal(Product product)
    {
        int orderTotal = product.ProductFee() + ShippingCost();
        return orderTotal;
    }
    public void PackingLabel()
    {

    }
    public void ShippingLabel()
    {

    }

}