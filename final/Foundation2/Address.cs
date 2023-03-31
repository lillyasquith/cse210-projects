using System;

class Address
{
    private string _street;
    private string _city;
    private string _state;
    private string _country;

    public Address(string street, string city, string state, string country)
    {
        _street = street;
        _city = city;
        _state = state;
        _country = country;
    }
    public bool InUSA()
    {
        if (_country == "USA")
        {
            return true;
        }
        else
            return false;
    }
    public void DisplayAddress()
    {
        Console.WriteLine($"{_street}");
        Console.WriteLine($"{_city}");
        Console.WriteLine($"{_state}");
        Console.WriteLine($"{_country}.");
    }
    public string CustomerAddress()//why do I need this function 
    {
        string address = "";
        address += $"{_street}";
        address += $"{_city}";
        address += $"{_state}";
        address += $"{_country}";
        return address;
    }
    //The address should have a method to return a string all of its fields together in one string.

}