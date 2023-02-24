using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Menu Options:");
        // string userChoice = "";
        // string[] choices =
        // {
        // "1.Start breathing activity",
        // "2.Start refecting activity",
        // "3.Start listing activity",
        // "4.Quit"
        // };
        // foreach (string i in choices)
        // {
        //     Console.WriteLine(i);
        // }
        // Console.WriteLine("Select a choice from the menu: ");
        // userChoice = Console.ReadLine();

        //test Activity class.
        // Activity activity1 = new Activity("", "", 0);
        // activity1.WelcomeMessageDisplay();
        // activity1.DescriptionDisplay();
        // activity1.ActivityDuration();
        // activity1.PauseSpinner();
        // activity1.EndingMessageDisplay();

        //test Breathing Activity class.
        // BreathingActivity activity2 = new BreathingActivity("Breathing Activity", "\nThis activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.", 0);
        // activity2.WelcomeMessageDisplay();
        // activity2.DescriptionDisplay();
        // activity2.ActivityDuration();
        // activity2.PauseSpinner();
        // activity2.RunProgram();
        // activity2.PauseSpinner();
        // activity2.TimerCount();
        // activity2.EndingMessageDisplay();

        RefectionActivity activity3 = new RefectionActivity("RefectionActivity", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.", 0);
        activity3.WelcomeMessageDisplay();
        activity3.DescriptionDisplay();
        activity3.ActivityDuration();
        activity3.PauseSpinner();
        activity3.GetRandomPrompt();
        // activity3.DisplayPrompt();
        activity3.EndingMessageDisplay();
    }
}