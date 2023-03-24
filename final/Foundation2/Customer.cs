using System;

class Customer
{
    private string _customerName;
    public Address _address;
    public Customer(string name, Address address)
    {
        _customerName = name;
        _address = address;
    }
    public bool CheckAddressUSA()
    {
        bool inUSA = _address.InUSA();
        return inUSA;
    }
    public void DisplayCustomer()
    {
        Console.WriteLine($"{_customerName}");
        _address.DisplayAddress();
    }
}