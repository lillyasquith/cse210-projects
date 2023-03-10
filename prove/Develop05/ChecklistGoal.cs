using System;

class ChecklistGoal : Goal
{

    private int _timesOfAccomplish;
    private int _trackAccomplish;
    private int _bonus;

    public ChecklistGoal()
    {

    }

    public void WriteCheclistGoal()
    {
        WriteGoal();
        Console.Write("How many times does this goal need to be accomplished for a bonus? ");
        string _inputC = Console.ReadLine();
        _timesOfAccomplish = int.Parse(_inputC);
        Console.Write("What is the bonus for accomplishing it that many times? ");
        _inputC = Console.ReadLine();
        _bonus = int.Parse(_inputC);
    }

    public override int RecordEvent()
    {
        return TrackAccomplish();
    }

    public int TrackAccomplish()
    {
        if (_trackAccomplish != _timesOfAccomplish)
        {
            return _point;
        }
        else
        {
            return _point + _bonus;
        }

    }

    public override void DisplayGoal()
    {
        if (_isComplete == true)
        {
            Console.WriteLine($"[X] {_goalName} {(_description)} -- Curruntly completed: {_trackAccomplish}/{_timesOfAccomplish}");
        }
        else
            Console.WriteLine($"[ ] {_goalName} {(_description)} -- Curruntly completed: {_trackAccomplish}/{_timesOfAccomplish}");


    }
}