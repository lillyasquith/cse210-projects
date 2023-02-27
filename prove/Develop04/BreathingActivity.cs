using System;

class BreathingActivity : Activity
{
    public BreathingActivity(string name, string description) : base(name, description)
    {

    }
    public void RunProgram()
    {
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(_activityDuration);
        while (DateTime.Now <= futureTime)
        {
            BreathCycle("\nBreathe in...");
            Console.WriteLine();
            BreathCycle("Now breathe out...");
            Console.WriteLine();
        }
    }
    private void BreathCycle(string text)
    {
        Random rd = new Random();
        // int numberOfSecond = rd.Next(2, 3);
        Console.Write($"{text}");
        CountDown(rd.Next(2, 5));
    }





}
