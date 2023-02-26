using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
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

        if (userChoice == "1")
        {
            BreathingActivity activity2 = new BreathingActivity("Breathing Activity", "\nThis activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.");
            activity2.WelcomeMessageDisplay();
            activity2.DescriptionDisplay();
            activity2.ActivityDuration();
            activity2.Animation();
            activity2.RunProgram();
            activity2.EndingMessageDisplay();
        }

        //test Activity class.
        // Activity activity1 = new Activity("", "", 0);
        // activity1.WelcomeMessageDisplay();
        // activity1.DescriptionDisplay();
        // activity1.ActivityDuration();
        // activity1.PauseSpinner();
        // activity1.EndingMessageDisplay();

        //test Breathing Activity class.
        // 

        // RefectionActivity activity3 = new RefectionActivity("RefectionActivity", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.", 0);
        // activity3.WelcomeMessageDisplay();
        // activity3.DescriptionDisplay();
        // activity3.ActivityDuration();
        // activity3.TimerCount();
        // activity3.GetRandomPrompt();
        // activity3.EndingMessageDisplay();
        if (userChoice == "3")
        {
            ListingActivity activity3 = new ListingActivity(0, "ListingActivity", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");
            activity3.WelcomeMessageDisplay();
            activity3.DescriptionDisplay();
            activity3.ActivityDuration();
            activity3.Animation();
            activity3.RandomListingPrompt();
            activity3.CountAnswer();
            activity3.EndingMessageDisplay();
        }

    }
}
