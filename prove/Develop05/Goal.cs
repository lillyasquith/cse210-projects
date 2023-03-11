using System;
using System.IO;

class Goal
{
    protected string _goalName;
    protected string _description;
    protected int _point;
    protected bool _isComplete;
    protected string _input;
    protected string _goalType;


    public Goal()
    {

    }

    public virtual void WriteGoal()
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

    public void SaveGoal(List<Goal> goals)
    {
        Console.Write("What is the file name? ");
        string fileName = Console.ReadLine();
        using (StreamWriter outputFile = new StreamWriter(fileName))
            foreach (Goal g in goals)
            {
                outputFile.WriteLine($"{g._goalType} {g._goalName} ({g._description}) {g._point} {g._isComplete}");
            }

    }

    public void LoadGoal(List<Goal> goals)
    {
        string fName = "";
        string[] lines = System.IO.File.ReadAllLines(fName);
        foreach (string line in lines)
        {
            string[] parts = line.Split(">>");
            Goal goal = new Goal();
            goal._goalType = parts[0];
            goal._goalName = parts[1];
            goal._description = parts[2];
            goal._point = int.Parse(parts[3]);
        }
        Console.WriteLine("Press any key to exit.");
        System.Console.ReadKey();
    }

    public void GoalType()
    {
        string[] _goalType =
        {
            "1.Simple Goal",
            "2.Eternal Goal",
            "3.Checklist Goal",
        };
        foreach (string i in _goalType)
        {
            Console.WriteLine(i);
        }
    }

    public virtual int RecordEvent()
    {
        _isComplete = true;
        return _point;
    }

    public virtual void DisplayGoal(int cnt)
    {
        if (_isComplete == true)
        {
            Console.WriteLine($"{cnt}. [X] {_goalName} ({_description})");
        }
        else
            Console.WriteLine($"{cnt}. [ ] {_goalName} ({_description})");
    }

}