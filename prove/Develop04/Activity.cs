class Activity
{
    private string _activityName;
    private string _introMessage;
    private string _explanationMessage;
    private int _duration;
    private string _outroMessage;

    public Activity(string name, string description, int time, string outro)
    {
        _activityName = "Breathing Activity";
        _introMessage = "Welcome to the ";
        _explanationMessage = description;
        _duration = time;
        _outroMessage = "Weldone!!";
    }
    public void WelcomeMessageDisplay()
    {
        Console.WriteLine($"{_introMessage} {_activityName}!");
    }
    public void DescriptionDisplay()
    {
        Console.WriteLine($"{_explanationMessage}");
    }
    public int ActivityDuration()
    {
        Console.Write("\nHow long, in second, would you like for your session? ");
        int time = int.Parse(Console.ReadLine());
        return time;
    }
    public void EndingMessageDisplay()
    {
        Console.WriteLine($"{_outroMessage}");
        Console.WriteLine($"\nYou have completed another {_duration} seconds of the {_activityName}.");

    }

}