using System;

class Goal
{
    protected string _goalName;
    protected string _description;
    protected int _point;
    protected bool _isComplete;
    protected string _input;


    public Goal()
    {

    }

    public void WriteGoal()
    {
        Console.Write("What is the name of your goal? ");
        _input = Console.ReadLine();
        _goalName = _input;

        Console.Write("What is a short description of it? ");
        _input = Console.ReadLine();
        _description = _input;

        Console.Write("What is the amount of points associated with this goal? ");
        _input = Console.ReadLine();
        _point = int.Parse(_input);
    }

    public void SaveGoal()
    {

    }

    public void LoadGoal()
    {

    }

    public virtual int RecordEvent()
    {
        _isComplete = true;
        return _point;
    }

    public virtual void DisplayGoal()
    {
        if (_isComplete == true)
        {
            Console.WriteLine($"[X] {_goalName} ({_description})");
        }
        else
            Console.WriteLine($"[ ] {_goalName} ({_description})");
    }

}