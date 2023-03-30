using System;

class Program
{
    static void Main(string[] args)
    {

        Address address = new Address("123 N 100 E", "Provo", "UT", "USA");
        Event ev = new Event("Why babies cry", "abc", "04/01/2023", "14:00 P.M", address);
        ev.Display();

    }
}