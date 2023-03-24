using System;

class Customer
{
    private string _customerName;
    Address _address;
    public Customer(string name, Address address)
    {
        _customerName = name;
        _address = address;
    }
    public Boolean CheckAddressUSA()
    {
        return true;
    }
    public void DisplayCustomer()
    {
        Console.WriteLine($"{_customerName}");
        Console.WriteLine($"{_address}");
    }
}