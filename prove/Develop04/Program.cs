using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        //test Activity class.
        // Activity activity = new Activity("", "", 0);
        // activity.WelcomeMessageDisplay();
        // activity.DescriptionDisplay();
        // activity.ActivityDuration();
        // activity.PauseSpinner();
        // activity.EndingMessageDisplay();
        Console.WriteLine("Menu Options:");
        string userChoice = "";
        string[] choices =
        {
        "1.Start breathing activity",
        "2.Start refecting activity",
        "3.Start listing activity",
        "4.Quit"
        };
        foreach (string i in choices)
        {
            Console.WriteLine(i);
        }
        Console.Write("Select a choice from the menu: ");
        userChoice = Console.ReadLine();

        if (userChoice != "4")
        {

            if (userChoice == "1")
            {
                BreathingActivity activity1 = new BreathingActivity("Breathing Activity", "\nThis activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.");
                activity1.WelcomeMessageDisplay();
                activity1.DescriptionDisplay();
                activity1.ActivityDuration();
                activity1.Animation();
                activity1.RunProgram();
                activity1.EndingMessageDisplay();
            }
            else if (userChoice == "2")
            {
                RefectingActivity activity2 = new RefectingActivity("Refecting Activity", "\nThis activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");
                activity2.WelcomeMessageDisplay();
                activity2.DescriptionDisplay();
                activity2.ActivityDuration();
                activity2.Animation();
                activity2.GetRandomPrompt();
                activity2.ToBegin2();
                activity2.GetRandomQuestion();
                activity2.EndingMessageDisplay();
            }
            else if (userChoice == "3")
            {
                ListingActivity activity3 = new ListingActivity(0, "Listing Activity", "\nThis activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");
                activity3.WelcomeMessageDisplay();
                activity3.DescriptionDisplay();
                activity3.ActivityDuration();
                activity3.Animation();
                activity3.RandomListingPrompt();
                activity3.ToBegin3();
                activity3.CountAnswer();
                activity3.EndingMessageDisplay();
            }
            else
            {
                Console.WriteLine("Invalid option. Please choose again!");
            }
        }
        else
        {
            Console.WriteLine("See you again!");
        }
    }
}
