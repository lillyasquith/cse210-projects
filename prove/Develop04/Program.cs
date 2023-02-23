using System;

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
        Activity activity = new Activity("", "\nThis activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.", 30, "");
        activity.WelcomeMessageDisplay();
        activity.DescriptionDisplay();
        activity.ActivityDuration();
        activity.EndingMessageDisplay();

    }
}