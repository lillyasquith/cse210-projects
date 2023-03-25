using System;

class Product
{
    private string _productName;
    private string _ID;
    private int _unitPrice;
    private int _quantity;

    public Product(string name, string ID, int unitPrice, int quantity)
    {
        _productName = name;
        _ID = ID;
        _unitPrice = unitPrice;
        _quantity = quantity;
    }
    public void DisplayProduct()
    {
        Console.WriteLine($"ID: '{_ID}'-- Name: {_productName} -- Price: ${_unitPrice} x {_quantity}");
    }
    public int ProductFee()
    {
        return (_unitPrice * _quantity);
    }
}