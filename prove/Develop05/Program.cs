using System;

class Program
{
    static void LoadGoal(List<Goal> goals)// load all the goals that were saved.
    {
        string fName = "goals.txt";
        string[] lines = System.IO.File.ReadAllLines(fName);
        foreach (string line in lines)
        {
            string[] parts = line.Split(":");
            if (parts[0] == "SimpleGoal")
            {
                SimpleGoal simple = new SimpleGoal();
                simple.Deserialize(parts[1]);
                goals.Add(simple);// add simple object to the list
            }
            else if (parts[0] == "EternalGoal")
            {
                EternalGoal eternal = new EternalGoal();
                eternal.Deserialize(parts[1]);
                goals.Add(eternal);
            }
            else if (parts[0] == "ChecklistGoal")
            {
                ChecklistGoal checklist = new ChecklistGoal();
                checklist.Deserialize(parts[1]);
                goals.Add(checklist);
            }
        }
        Console.WriteLine("Press any key to exit.");
        System.Console.ReadKey();
    }
    static void SaveGoal(List<Goal> goals)
    {
        Console.Write("What is the file name? ");
        string fileName = Console.ReadLine();
        using (StreamWriter outputFile = new StreamWriter(fileName))
            foreach (Goal goal in goals)
            {
                outputFile.WriteLine(goal.Serialize());
            }
    }
    static void Main(string[] args)
    {
        int totalPoint = 0;

        //test Goal class
        Goal goal = new Goal();
        // goal.WriteGoal();
        // goal.DisplayGoal();
        // totalPoint += goal.RecordEvent();
        // goal.DisplayGoal();
        // Console.WriteLine($""Congratulations! You have earned {totalPoint} points.");
        List<Goal> goals = new List<Goal>();

        string menuChoice = "";
        string goalChoice = "";

        while (menuChoice != "6")
        {
            Console.WriteLine();
            Console.WriteLine($"You have {totalPoint} points.");
            Console.WriteLine();
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
                string[] _goalType =
                {
                    "1.Simple Goal",
                    "2.Eternal Goal",
                    "3.Checklist Goal",
                };
                foreach (string i in _goalType)
                {
                    Console.WriteLine(i);
                }
                Console.Write("The type of goal would you like to create: ");
                goalChoice = Console.ReadLine();
                if (goalChoice == "1")
                {
                    SimpleGoal simpleGoal = new SimpleGoal();
                    simpleGoal.WriteGoal();
                    goals.Add(simpleGoal);
                }
                else if (goalChoice == "2")
                {
                    EternalGoal eternalGoal = new EternalGoal();
                    eternalGoal.WriteGoal();
                    goals.Add(eternalGoal);
                }
                else if (goalChoice == "3")
                {
                    ChecklistGoal checklistGoal = new ChecklistGoal();
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
                for (int i = 0; i < goals.Count(); i++)
                {
                    int count = i + 1;
                    Console.Write($"{count}.");
                    goals[i].DisplayGoal();
                }
                // int cnt = 0;//This is another way to display
                // foreach (Goal g in goals)
                // {
                //     cnt++;
                //     g.DisplayGoal(cnt);
                // }
            }
            else if (menuChoice == "3")
            {
                SaveGoal(goals);
            }
            else if (menuChoice == "4")
            {
                LoadGoal(goals);//need to fix, it did not display any info.
            }
            else if (menuChoice == "5")
            {
                Console.WriteLine("The goals are: ");
                for (int i = 0; i < goals.Count(); i++)
                {
                    int count = i + 1;
                    Console.Write($"{count}.");
                    goals[i].DisplayGoal();
                }
                Console.Write("Which goal did you accomplish? ");
                string gChoice = Console.ReadLine();
                int goalChoiceInNumber = int.Parse(gChoice);
                totalPoint += goals[goalChoiceInNumber - 1].RecordEvent(goals);//choose only the number to record the event. 
                Console.WriteLine($"Congratulations! You have earned {totalPoint} points.");
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