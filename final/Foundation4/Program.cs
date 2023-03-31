using System;

class Program
{
    static void Main(string[] args)
    {
        Running running = new Running(3.0, "01 Nov 2022", 30);
        Cycling cycling = new Cycling(40, "02 Nov 2022", 30);
        Swimming swimming = new Swimming(100, "03 Nov 2022", 30);

        List<Activity> activities = new List<Activity>();
        activities.Add(running);
        activities.Add(cycling);
        activities.Add(swimming);

        foreach (Activity a in activities)
        {
            a.GetSummary();
        }

    }
}