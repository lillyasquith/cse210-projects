using System;

class EternalGoal : Goal
{

    public EternalGoal()
    {

    }
    public override void DisplayGoal(int cnt)
    {
        Console.WriteLine($"{cnt}. [ ] {_goalName} ({_description})");
    }

}