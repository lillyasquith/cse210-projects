class Activity
{
    private string _introMessage;
    private string _explanationMessage;
    private int _time;
    private string _outroMessage;

    public Activity(string introMessage, string explanationMessage, int time, string outroMessage)
    {
        _introMessage = introMessage;
        _explanationMessage = explanationMessage;
        _time = time;
        _outroMessage = outroMessage;
    }
    public void WelcomeMessageDisplay()
    {
        Console.WriteLine($"{_introMessage}");
    }
    public void DescriptionDisplay()
    {
        Console.WriteLine($"{_explanationMessage}");
    }
    public int ActivityDuration()
    {
        Console.Write("How long, in second, would you like for your session? ");
        int time = int.Parse(Console.ReadLine());
        return time;
    }
    public void EndingMessageDisplay()
    {
        Console.WriteLine($"{_outroMessage} {_time}");
    }

}