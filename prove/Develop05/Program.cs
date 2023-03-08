using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Menu Options:");
        string userChoice = "";
        string goalType = "";

        while (userChoice != "6")
        {
            Console.WriteLine();
            string[] choices =
            {
            "1.Create New Goal",
            "2.List Goals",
            "3.Save Goals",
            "4.Load Goals",
            "5.Record Event",
            "6.Quit"
            };
            foreach (string i in choices)
            {
                Console.WriteLine(i);
            }
            Console.Write("Select a choice from the menu: ");
            userChoice = Console.ReadLine();

            if (userChoice == "1")
            {
                Console.WriteLine("The types of Goals are: ");
                string[] goals =
                {
                "1.Simple Goal",
                "2.Eternal Goal",
                "3.Checklist Goal",
                };
                foreach (string i in goals)
                {
                    Console.WriteLine(i);
                }
                goalType = Console.ReadLine();

            }
            else if (userChoice == "2")
            {

            }
            else if (userChoice == "3")
            {

            }
            else if (userChoice == "4")
            {

            }
            else if (userChoice == "5")
            {

            }
            else if (userChoice == "6")
            {
                Console.WriteLine("See you again!");
            }
            else
            {
                Console.WriteLine("Invalid option. Please choose again!");
            }


        }
    }
}