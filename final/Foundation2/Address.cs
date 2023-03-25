using System;

class Address
{
    private string _street;
    private string _city;
    private string _state;
    private string _country;
    // private bool _inUSA;

    public Address(string street, string city, string state, string country)
    {
        _street = street;
        _city = city;
        _state = state;
        _country = country;
    }
    public bool InUSA()
    {
        if (_country != "USA")
        {
            return false;
        }
        else
            return true;
    }
    public void DisplayAddress()
    {
        Console.WriteLine($"{_street}");
        Console.WriteLine($"{_city}");
        Console.WriteLine($"{_state}");
        Console.WriteLine($"{_country}");
    }
    public string CustomerAddress()
    {
        string address = "";
        address += $"{_street}";
        address += $"{_city}";
        address += $"{_state}";
        address += $"{_country}";
        return address;
    }

}