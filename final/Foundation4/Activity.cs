using System;

class Activity
{
    protected string _date;
    protected int _length;//in minutes
    protected string _activityType;

    public Activity(string date, int minute)
    {
        _date = date;
        _length = minute;
    }
    public virtual double GetDistance()
    {
        return 1;
    }

    public virtual double GetSpeed()
    {
        return 1;
    }

    public virtual double GetPace()
    {
        return 1;
    }

    public void GetSummary()
    {
        Console.WriteLine($"{_date} {_activityType} ({_length} min)- Distance {GetDistance()} miles, Speed {GetSpeed()} mph, Pace: {GetPace()} min per mile");
    }

}