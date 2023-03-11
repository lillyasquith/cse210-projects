using System;

class Program
{
    static void Main(string[] args)
    {
        int totalPoint = 0;
        Console.WriteLine($"You have {totalPoint} points.");
        Console.WriteLine();

        //test Goal class
        Goal goal = new Goal();
        // goal.WriteGoal();
        // goal.DisplayGoal();
        // totalPoint += goal.RecordEvent();
        // goal.DisplayGoal();
        // Console.WriteLine($"You have {totalPoint} points.");

        SimpleGoal simpleGoal = new SimpleGoal();
        EternalGoal eternalGoal = new EternalGoal();
        ChecklistGoal checklistGoal = new ChecklistGoal();
        // checklistGoal.WriteCheclistGoal();
        // checklistGoal.DisplayGoal();
        // totalPoint += checklistGoal.RecordEvent();
        // Console.WriteLine($"Congratulations! You have earned {totalPoint} points.");

        List<Goal> goals = new List<Goal>();
        //goals.Add(simpleGoal);
        //goals.Add(eternalGoal);
        //goals.Add(checklistGoal);

        string menuChoice = "";
        string goalChoice = "";

        while (menuChoice != "6")
        {
            Console.WriteLine("Menu Options:");
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
            menuChoice = Console.ReadLine();

            if (menuChoice == "1")
            {
                Console.WriteLine("The types of Goals are: ");
                goal.GoalType();
                Console.Write("The type of goal would you like to create: ");
                goalChoice = Console.ReadLine();
                if (goalChoice == "1")
                {
                    simpleGoal.WriteGoal();
                    goals.Add(simpleGoal);
                }
                else if (goalChoice == "2")
                {
                    eternalGoal.WriteGoal();
                    goals.Add(eternalGoal);
                }
                else if (goalChoice == "3")
                {
                    checklistGoal.WriteGoal();
                    goals.Add(checklistGoal);
                }
                else
                {
                    Console.WriteLine("Invalid option. Please choose again!");
                }

            }
            else if (menuChoice == "2")
            {
                Console.WriteLine("The goals are: ");
                int cnt = 0;
                foreach (Goal g in goals)
                {
                    cnt++;
                    g.DisplayGoal(cnt);
                }

            }
            else if (menuChoice == "3")
            {
                goal.SaveGoal(goals);
            }
            else if (menuChoice == "4")
            {
                goal.LoadGoal(goals);
            }
            else if (menuChoice == "5")
            {
                Console.Write("Which goal did you accomplish? ");
                goalChoice = Console.ReadLine();
                if (goalChoice == "1")
                {
                    simpleGoal.RecordEvent();
                }
                else if (goalChoice == "2")
                {
                    eternalGoal.RecordEvent();
                }
                else if (goalChoice == "3")
                {
                    checklistGoal.RecordEvent();
                }
                else
                {
                    Console.WriteLine("Invalid option. Please choose again!");
                }
                int cnt = 0;
                foreach (Goal g in goals)
                {
                    cnt++;
                    g.DisplayGoal(cnt);
                    totalPoint += g.RecordEvent();
                }
                Console.WriteLine($"Congratulations! You have earned {totalPoint} points.");
                Console.WriteLine();
            }
            else if (menuChoice == "6")
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