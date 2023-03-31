using System;

class Program
{
    static void Main(string[] args)
    {

        Address address = new Address("Provo Event Center: 123 N 100 E", "Provo", "UT", "USA");
        // Event ev = new Event("Why babies cry", "abc", "04/01/2023", "14:00 P.M", address);
        // ev.DisplayStandardDetails();
        // Console.WriteLine();
        // ev.DisplayFullDetails();
        // Console.WriteLine();
        // ev.DisplayShortDescription();

        Lecture lecture = new Lecture("Dr.Expert", 50, "Help chilren build emotional skills", "Children can become more successful when they understand their feeling...Let's talk about why and how", "04/02/2023", "17:30 P.M", address);
        lecture.DisplayStandardDetails();
        Console.WriteLine();
        lecture.LectureFullDetails();
        Console.WriteLine();
        lecture.DisplayShortDescription();

        Console.WriteLine();
        Console.WriteLine($"---------------");
        Reception reception = new Reception("awesomecouple@gmail.com", "Rachel and Justin", "Please join us to celebrate the love and marriage of Rachel and Justin", "05/02/2023", "18:30 P.M", address);
        reception.DisplayStandardDetails();
        Console.WriteLine();
        reception.ReceptionFullDetails();
        Console.WriteLine();
        reception.DisplayShortDescription();

        Console.WriteLine();
        Console.WriteLine($"---------------");
        Outdoor outdoor = new Outdoor("50°F", "Easter Egg Hunt", "This event is FREE! Bring your kiddos for the fun game. With over 3,000 eggs to find, nobody will leave empty handed!", "04/08/2023", "10:30 A.M", address);
        outdoor.DisplayStandardDetails();
        Console.WriteLine();
        outdoor.OutdoorFullDetails();
        Console.WriteLine();
        outdoor.DisplayShortDescription();

    }
}