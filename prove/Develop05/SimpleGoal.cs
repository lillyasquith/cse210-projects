using System;

class SimpleGoal : Goal
{

    public SimpleGoal()
    {

    }

    public override int RecordEvent()
    {
        return base.RecordEvent();
    }

    public void DisplaySimpleGoal()
    {
        DisplayGoal();
    }

}