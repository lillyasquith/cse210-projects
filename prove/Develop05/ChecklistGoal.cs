using System;

class ChecklistGoal : Goal
{

    private int _timeAccomplish;
    private int _bonus;
    private string _inputC;
    //private int _track;?

    public ChecklistGoal()
    {

    }

    public void WriteCheclistGoal()
    {
        WriteGoal();
        Console.Write("How many times does this goal need to be accomplished for a bonus? ");
        _inputC = Console.ReadLine();
        _timeAccomplish = int.Parse(_inputC);
        Console.Write("What is the bonus for accomplishing it that many times? ");
        _inputC = Console.ReadLine();
        _bonus = int.Parse(_inputC);
    }
    public void CheckBonus()
    {
        foreach (int i in Enumerable.Range(0, _timeAccomplish))
        {
            Console.WriteLine(i + $"/{_timeAccomplish}");
        }

    }

    public override int RecordEvent()
    {
        return base.RecordEvent();

    }
    public override void DisplayGoal()
    {

        if (_isComplete == true)
        {
            Console.WriteLine($"[X] {_goalName} {(_description)} -- Curruntly completed: {_timeAccomplish}");
        }
        else
            Console.WriteLine($"[ ] {_goalName} {(_description)} -- Curruntly completed: {_timeAccomplish}");
    }
}