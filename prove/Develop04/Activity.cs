class Activity
{
    protected string _activityName;
    private string _introMessage;
    protected string _activityDescription;
    protected int _activityDuration;
    private string _outroMessage;

    public Activity(string name, string description, int time)
    {
        _activityName = name;
        _introMessage = "Welcome to the";
        _activityDescription = description;
        _activityDuration = time;
        _outroMessage = "Weldone!!";
    }
    // public string GetActivityName()
    // {
    //     return _activityName;
    // }
    // public string GetActivityDescription()
    // {
    //     return _activityDescription;
    // }
    public int ActivityDuration()
    {
        Console.Write("\nHow long, in second, would you like for your session? ");
        int time = int.Parse(Console.ReadLine());
        return time;
    }
    public void PauseSpinner()
    {
        Console.WriteLine("Get Ready...");
        Thread.Sleep(1000);
        // Console.WriteLine("I'm back!!");
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