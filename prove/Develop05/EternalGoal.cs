using System;
using System.IO;

class EternalGoal : Goal
{
    public EternalGoal()
    {
        _goalType = "EternalGoal";
    }
    public override int RecordEvent(List<Goal> goals)
    {
        return _point;
    }
    public override void DisplayGoal()
    {
        Console.WriteLine($" [ ] {_goalName} ({_description})");
    }

    //Added Serialize() and Deserialize()
    public override string Serialize()
    {
        string info = "";
        info += $"{_goalType}:";
        info += $"{_goalName}>";
        info += $"{_description}>";
        info += $"{_point}>";
        info += $"{_isComplete}>";
        return info;
    }
    public override void Deserialize(string line)
    {
        string[] parts = line.Split(">");
        _goalName = parts[0];
        _description = parts[1];
        _point = int.Parse(parts[2]);
        _isComplete = bool.Parse(parts[3]);
    }

}