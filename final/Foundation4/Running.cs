using System;

class Running : Activity
{
    private double _distance;

    public Running(double distance, string date, int length) : base(date, length)
    {
        _distance = distance;
        _activityType = "Running";
    }

    public override double GetDistance()
    {
        return _distance;
    }

    public override double GetSpeed()
    {
        double speed = (_distance / _length) * 60;
        return speed;
    }
    public override double GetPace()
    {
        return _length / _distance;
    }


}