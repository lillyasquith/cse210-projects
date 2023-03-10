using System;

class Program
{
    static void Main(string[] args)
    {
        List<Goal> _goals = new List<Goal>();


        int totalPoint = 0;
        Console.WriteLine($"You have {totalPoint} points.");
        Console.WriteLine();

        //test Goal class
        // Goal goal = new Goal();
        // goal.WriteGoal();
        // goal.DisplayGoal();
        // totalPoint += goal.RecordEvent();
        // goal.DisplayGoal();
        // Console.WriteLine($"You have {totalPoint} points.");

        // SimpleGoal simpleGoal = new SimpleGoal();
        // simpleGoal.WriteGoal();
        // simpleGoal.DisplaySimpleGoal();
        // totalPoint += simpleGoal.RecordEvent();
        // simpleGoal.DisplaySimpleGoal();
        // Console.WriteLine($"Congratulations! You have earned {totalPoint} points.");

        // EternalGoal eternalGoal = new EternalGoal();
        // eternalGoal.WriteGoal();
        // eternalGoal.DisplayEternalGoal();
        // totalPoint += eternalGoal.RecordEvent();
        // eternalGoal.DisplayEternalGoal();
        // Console.WriteLine($"Congratulations! You have earned {totalPoint} points.");

        Console.WriteLine();
        ChecklistGoal checklistGoal = new ChecklistGoal();
        checklistGoal.WriteCheclistGoal();
        checklistGoal.DisplayGoal();
        checklistGoal.CheckBonus();



        // Console.WriteLine("Menu Options:");
        // string userChoice = "";
        // string goalType = "";

        // while (userChoice != "6")
        // {
        //     Console.WriteLine();
        //     string[] choices =
        //     {
        //     "1.Create New Goal",
        //     "2.List Goals",
        //     "3.Save Goals",
        //     "4.Load Goals",
        //     "5.Record Event",
        //     "6.Quit"
        //     };
        //     foreach (string i in choices)
        //     {
        //         Console.WriteLine(i);
        //     }
        //     Console.Write("Select a choice from the menu: ");
        //     userChoice = Console.ReadLine();

        //     if (userChoice == "1")
        //     {
        //         Console.WriteLine("The types of Goals are: ");
        //         string[] goals =
        //         {
        //         "1.Simple Goal",
        //         "2.Eternal Goal",
        //         "3.Checklist Goal",
        //         };
        //         foreach (string i in goals)
        //         {
        //             Console.WriteLine(i);
        //         }
        //         goalType = Console.ReadLine();
        //         if (goalType == "1")
        //         {

        //         }

        //     }
        //     else if (userChoice == "2")
        //     {

        //     }
        //     else if (userChoice == "3")
        //     {

        //     }
        //     else if (userChoice == "4")
        //     {

        //     }
        //     else if (userChoice == "5")
        //     {

        //     }
        //     else if (userChoice == "6")
        //     {
        //         Console.WriteLine("See you again!");
        //     }
        //     else
        //     {
        //         Console.WriteLine("Invalid option. Please choose again!");
        //     }


        // }
    }
}