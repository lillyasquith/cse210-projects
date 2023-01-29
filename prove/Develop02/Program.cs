using System;
using System.IO;
using System.Collections.Generic;
class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        string userChoice = "";
        Console.WriteLine("Welcome to the Journal Program!");
        Console.WriteLine("Please select one of the following choices:");

        while (userChoice != "5")
        {
            string[] choices = { "1.Write", "2.Display", "3.Load", "4.Save", "5.Quit" };
            foreach (string i in choices)
            {
                Console.WriteLine(i);
            }
            Console.Write("What would you like to do? ");
            userChoice = Console.ReadLine();
            if (userChoice == "1")
            {
                journal.AddEntry();
            }
            else if (userChoice == "2")
            {
                journal.DisplayEntry();
            }
            else if (userChoice == "3")
            {
                journal.Load();
            }
            else if (userChoice == "4")
            {
                journal.Save();
            }
        }
    }
}