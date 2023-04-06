using System;
using System.IO;

class Goal
{
    protected string _goalName;
    protected string _description;
    protected int _point;
    protected bool _isComplete;
    protected string _goalType;//this is different than goalType in Main

    public Goal()
    {

    }
    public virtual void WriteGoal()
    {
        Console.Write("What is the name of your goal? ");
        string _input = Console.ReadLine();
        _goalName = _input;

        Console.Write("What is a short description of it? ");
        _input = Console.ReadLine();
        _description = _input;

        Console.Write("What is the amount of points associated with this goal? ");
        _input = Console.ReadLine();
        _point = int.Parse(_input);
    }

    //Added Serialize() and Deserialize() in all classes for Save and Load functions.
    public virtual string Serialize()
    {
        return "";
    }
    public virtual void Deserialize(string line)
    {

    }
    public virtual int RecordEvent(List<Goal> goals)
    {
        _isComplete = true;
        return _point;
    }

    public virtual void DisplayGoal()
    {
        if (_isComplete == true)
        {
            Console.WriteLine($" [X] {_goalName} ({_description})");
        }
        else
            Console.WriteLine($" [ ] {_goalName} ({_description})");
    }
}