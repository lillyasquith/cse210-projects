using System;

class Address
{
    private string _street;
    private string _city;
    private string _state;
    private string _province;
    private string _country;
    private bool _inUSA;

    public Address(string street, string city, string state, string province, string country)
    {
        _street = street;
        _city = city;
        _state = state;
        _province = province;
        _country = country;
    }
    public Boolean InUSA()
    {
        if (_inUSA == true)
        {
            return true;
        }
        else
            return false;
    }

    public string DisplayAddress()
    {
        string address = "";
        address += $"{_street}";
        address += $"{_city}";
        address += $"{_state}";
        address += $"{_province}";
        address += $"{_country}";
        return address;
    }
}