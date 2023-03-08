using System;

class Goal
{
    protected string _typeOfGoal;
    protected string _goalName;
    protected string _description;
    private int _point;
    private bool _checkmark;
    private string _input;
    public List<Goal> _goals = new List<Goal>();

    public Goal()
    {

    }

    public void WriteGoal()
    {
        _goalName = "What is the name of your goal? ";
        Console.WriteLine(_goalName);
        _input = Console.ReadLine();
        _description = "What is a short description of it? ";
        Console.WriteLine(_description);
        _input = Console.ReadLine();
        Console.Write($"What is the amount of points associated with this goal? {_point}");
        _input = Console.ReadLine();
    }

    public void AddGoal()
    {
        Goal goal = new Goal();
        goal.WriteGoal();
        _goals.Add(goal);
    }

    public void SaveGoal()
    {

    }

    public void LoadGoal()
    {

    }

    public void RecordEvent()
    {

    }
    public void DisplayGoal()
    {
        Console.WriteLine($"{_checkmark} {_goalName} {(_description)}");
    }


}