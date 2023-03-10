using System;

class EternalGoal : Goal
{

    public EternalGoal()
    {

    }

    public override int RecordEvent()
    {
        return base.RecordEvent();
    }

    public void DisplayEternalGoal()
    {
        Console.WriteLine($"[ ] {_goalName} {(_description)}");
    }

}