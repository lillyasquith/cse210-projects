using System;

class BreathingActivity : Activity
{
    public BreathingActivity(string name, string description, int time) : base(name, description, time)
    {

    }
    public void RunProgram()
    {
        //Display Animations
        Console.Write("+");
        Thread.Sleep(500);
        Console.Write("\b \b \b"); // Erase the + character
        Console.Write("-"); // Replace it with the - character
        //Display Activity

        {
            Console.WriteLine($"Breathe in...{_activityDuration}");
            Console.WriteLine($"Now Breathe out...{_activityDuration}");
        }

    }
    public void TimerCount()
    {
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(_activityDuration);

        Thread.Sleep(_activityDuration);

        DateTime currentTime = DateTime.Now;
        if (currentTime < futureTime)
        {
            Console.WriteLine("We have not arrived at our future time yet...");
        }
    }


}
