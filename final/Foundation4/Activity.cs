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
        double distance = GetDistance();
        double speed = GetSpeed();
        double pace = GetPace();
        Console.WriteLine($"{_date} {_activityType} ({_length} min)- Distance {distance.ToString("F2")} miles, Speed {speed.ToString("F2")} mph, Pace: {pace.ToString("F2")} min per mile");
    }

}