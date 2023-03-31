using System;

class Cycling : Activity
{
    private double _speed;

    public Cycling(double speed, string date, int length) : base(date, length)
    {
        _speed = speed;
        _activityType = "Cycling";
    }

    public override double GetDistance()
    {
        return GetPace() / _length;
    }
    public override double GetPace()
    {
        return 60 / _speed;
    }
    public override double GetSpeed()
    {
        return _speed;
    }
}