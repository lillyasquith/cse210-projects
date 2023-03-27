using System;

class Order
{
    public List<Product> _products = new List<Product>();
    public Customer _customer;

    public Order(Customer customer)
    {
        _customer = customer;
    }
    public int ShippingCost()
    {
        int shippingfee = 0;
        bool check = _customer.CheckAddressUSA();
        if (check == true)
        {
            shippingfee = 5;
        }
        else
            shippingfee = 35;
        return shippingfee;
    }

    public void AddProduct(Product product)//add items to the list before loop through it.
    {
        _products.Add(product);
    }
    public int OrderTotal()
    {
        int itemFee = 0;
        foreach (Product product in _products)
        {
            itemFee += product.ProductFee();
        }
        int orderTotal = itemFee + ShippingCost();
        return orderTotal;
    }
    public void PackingLabel()
    {
        foreach (Product product in _products)
        {
            product.DisplayProduct();
        }
    }
    public void ShippingLabel(Customer customer)
    {
        customer.DisplayCustomer();
    }

}