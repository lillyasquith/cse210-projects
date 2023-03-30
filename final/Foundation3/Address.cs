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
    public void DisplayAddress()
    {
        Console.WriteLine($"{_street} {_city} {_state} {_country}.");
    }
    public string AddressInfo()
    {
        string address = "";
        address += $"{_street}";
        address += $"{_city}";
        address += $"{_state}";
        address += $"{_country}";
        return address;
    }
}