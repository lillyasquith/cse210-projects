class Activity
{
    protected string _activityName;
    private string _introMessage;
    protected string _activityDescription;
    protected int _activityDuration;
    private string _outroMessage;

    public Activity(string name, string description)
    {
        _activityName = name;
        _introMessage = "\nWelcome to the";
        _activityDescription = description;
        _outroMessage = "Weldone!!";
    }
    public void ActivityDuration()
    {
        Console.Write("\nHow long, in second, would you like for your session? ");
        int t = int.Parse(Console.ReadLine());
        _activityDuration = t;
    }
    public void Animation()
    {
        Console.WriteLine("Get Ready...\n");
        DateTime currentTime = DateTime.Now;
        DateTime futureTime = currentTime.AddSeconds(1);
        while (currentTime < futureTime)
        {
            currentTime = DateTime.Now;
            Console.Write("|");
            Thread.Sleep(500);
            Console.Write("\b \b");
            Console.Write("/");
            Thread.Sleep(500);
            Console.Write("\b \b");
            Console.Write("-");
            Thread.Sleep(500);
            Console.Write("\b \b");
            Console.Write("\\");
            Thread.Sleep(500);
            Console.Write("\b \b");
        }
    }
    protected void CountDown(int numberOfSecond)
    {
        // int numberOfSecond = 5;
        // DateTime startTime = DateTime.Now;
        // DateTime futureTime = startTime.AddSeconds(_activityDuration);

        // Console.Write("We have not arrived at our future time yet...");
        // while (numberOfSecond >= 1)
        // {
        //     Console.Write($"{numberOfSecond}");
        //     Thread.Sleep(1000);
        //     Console.Write("\b \b");
        //     numberOfSecond = numberOfSecond - 1;
        // }
        while (numberOfSecond >= 1)
        {
            Console.Write($"{numberOfSecond}");
            Thread.Sleep(1000);
            Console.Write("\b \b");
            numberOfSecond = numberOfSecond - 1;
        }
    }
    public void WelcomeMessageDisplay()
    {
        Console.WriteLine($"{_introMessage} {_activityName}!");
    }
    public void DescriptionDisplay()
    {
        Console.WriteLine($"{_activityDescription}");
    }
    public void EndingMessageDisplay()
    {
        Console.WriteLine($"{_outroMessage}");
        Console.WriteLine($"\nYou have completed another {_activityDuration} seconds of the {_activityName}.");
    }


}



