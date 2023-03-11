using System;

class ChecklistGoal : Goal
{
    private int _timesOfAccomplish;
    private int _trackTimes;
    private int _bonus;

    public ChecklistGoal()
    {

    }
    public override void WriteGoal()
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
        Console.Write("How many times does this goal need to be accomplished for a bonus? ");
        string _inputC = Console.ReadLine();
        _timesOfAccomplish = int.Parse(_inputC);
        Console.Write("What is the bonus for accomplishing it that many times? ");
        _inputC = Console.ReadLine();
        _bonus = int.Parse(_inputC);
        _trackTimes = 0;
    }

    public override int RecordEvent()
    {
        return TrackAccomplish();
    }
    public int TrackAccomplish()
    {
        if (_trackTimes != _timesOfAccomplish)
        {
            return _point;
        }
        else
        {
            return _point + _bonus;
        }
    }
    public override void DisplayGoal(int cnt)
    {
        if (_isComplete == true)
        {
            Console.WriteLine($"{cnt}. [X] {_goalName} ({_description}) -- Curruntly completed: {_trackTimes}/{_timesOfAccomplish}");
        }
        else
            Console.WriteLine($"{cnt}. [ ] {_goalName} ({_description}) -- Curruntly completed: {_trackTimes}/{_timesOfAccomplish}");
    }
}