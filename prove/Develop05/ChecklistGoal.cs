using System;
using System.IO;
class ChecklistGoal : Goal
{
    private int _timesOfAccomplish;
    private int _trackTimes;
    private int _bonus;

    public ChecklistGoal()
    {
        _goalType = "ChecklistGoal";
    }
    public override void WriteGoal()
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
        Console.Write("How many times does this goal need to be accomplished for a bonus? ");
        _input = Console.ReadLine();
        _timesOfAccomplish = int.Parse(_input);
        Console.Write("What is the bonus for accomplishing it that many times? ");
        _input = Console.ReadLine();
        _bonus = int.Parse(_input);
    }

    public override int RecordEvent(List<Goal> goals)
    {
        if (_trackTimes >= _timesOfAccomplish)//the user can not earn more points if he finish this goal.>>Not sure if it counts as exceed core requirements
        {
            Console.WriteLine($"You only need to accomplish {_timesOfAccomplish} for a bonus.");
            return 0;//because the goal is done, no more points.
        }

        else//if the goals are not completed comparing to _timesOfAccomplish
            _trackTimes++;
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
            _isComplete = true;
            return _point + _bonus;
        }
    }
    public override void DisplayGoal()
    {
        if (_isComplete == true)
        {
            Console.WriteLine($" [X] {_goalName} ({_description}) -- Curruntly completed: {_trackTimes}/{_timesOfAccomplish}");
        }
        else
            Console.WriteLine($" [ ] {_goalName} ({_description}) -- Curruntly completed: {_trackTimes}/{_timesOfAccomplish}");
    }

    public override string Serialize()
    {
        string info = "";
        info += $"{_goalType}:";
        info += $"{_goalName}>";
        info += $"{_description}>";
        info += $"{_point}>";
        info += $"{_bonus}>";
        info += $"{_isComplete}>";
        info += $"{_timesOfAccomplish}>";
        info += $"{_trackTimes}>";
        return info;
    }
    public override void Deserialize(string line)
    {
        string[] parts = line.Split(">");
        _goalName = parts[0];
        _description = parts[1];
        _point = int.Parse(parts[2]);
        _bonus = int.Parse(parts[3]);
        _isComplete = bool.Parse(parts[4]);
        _timesOfAccomplish = int.Parse(parts[5]);
        _trackTimes = int.Parse(parts[6]);
    }
}