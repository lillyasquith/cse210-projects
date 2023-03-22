using System;

class EternalGoal : Goal
{

    private int _trackTimes;
    public EternalGoal()
    {
        _goalType = "EternalGoal";
        _trackTimes = 0;
    }
    public override int RecordEvent(List<Goal> goals)
    {
        return _point;
    }
    public override void DisplayGoal()
    {
        Console.WriteLine($" [ ] {_goalName} ({_description}) {_trackTimes}");
    }
    public override string Serialize()
    {
        string info = "";
        info += $"{_goalType}:";
        info += $"{_goalName}>";
        info += $"{_description}>";
        info += $"{_point}>";
        info += $"{_isComplete}>";
        info += $"{_trackTimes}>";
        return info;
    }
    public override void Deserialize(string line)
    {
        string[] parts = line.Split(">");
        _goalName = parts[0];
        _description = parts[1];
        _point = int.Parse(parts[2]);
        _isComplete = bool.Parse(parts[3]);
        _trackTimes = int.Parse(parts[4]);

    }

}