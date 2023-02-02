using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction f1 = new Fraction();
        Console.WriteLine(f1.GetFractionString());
        Console.WriteLine(f1.GetDecimalValue());
        // f1.SetTop(1);
        // f1.SetBottom(1);
        // Console.WriteLine(f1.GetTop());
        // Console.WriteLine(f1.GetBottom());
        // f1.DisplayFraction();

        Fraction f2 = new Fraction(5);
        Console.WriteLine(f2.GetFractionString());
        Console.WriteLine(f2.GetDecimalValue());
        // f2.SetTop(6);
        // f2.SetBottom(1);
        // Console.WriteLine(f2.GetTop());
        // Console.WriteLine(f2.GetBottom());
        // f2.DisplayFraction();

        Fraction f3 = new Fraction(3, 4);
        Console.WriteLine(f3.GetFractionString());
        Console.WriteLine(f3.GetDecimalValue());
        // f3.SetTop(6);
        // f3.SetBottom(7);
        // Console.WriteLine(f3.GetTop());
        // Console.WriteLine(f3.GetBottom());
        // f3.DisplayFraction();

        Fraction f4 = new Fraction(1, 3);
        Console.WriteLine(f4.GetFractionString());
        Console.WriteLine(f4.GetDecimalValue());

    }
}