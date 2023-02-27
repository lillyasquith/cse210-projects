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
        _introMessage = "Welcome to the";
        _activityDescription = description;
        _outroMessage = "Weldone!!";
    }
    public void ActivityDuration()
    {
        Console.Write("\nHow long, in second, would you like for your session? ");
        int t = int.Parse(Console.ReadLine());
        _activityDuration = t;
        Console.Write("Get Ready...");
        Console.WriteLine();
    }

    public void Animation()
    {
        DateTime currentTime = DateTime.Now;
        DateTime futureTime = currentTime.AddSeconds(1); ;
        while (currentTime < futureTime)
        {
            currentTime = DateTime.Now;
            Console.Write("|");
            Thread.Sleep(1000);
            Console.Write("\b \b");
            Console.Write("/");
            Thread.Sleep(1000);
            Console.Write("\b \b");
            Console.Write("-");
            Thread.Sleep(1000);
            Console.Write("\b \b");
            Console.Write("\\");
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }
    protected void CountDown(int numberOfSecond)
    {
        //test
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
        Console.WriteLine();
        Console.WriteLine($"{_introMessage} {_activityName}!");
    }
    public void DescriptionDisplay()
    {
        Console.WriteLine();
        Console.WriteLine($"{_activityDescription}");
    }
    public void EndingMessageDisplay()
    {
        Console.WriteLine();
        Console.WriteLine($"{_outroMessage}");
        Animation();
        Console.WriteLine($"\nYou have completed another {_activityDuration} seconds of the {_activityName}.");
        Animation();
    }


}



