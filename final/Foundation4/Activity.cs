using System;

class Activity
{
    protected int _date;
    protected int _length;//in minutes
    protected string _activityType;

    public Activity()
    {

    }
    public virtual int GetDistance()
    {
        return 0;
    }

    public virtual int GetSpeed()
    {
        return 0;
    }

    public virtual int GetPace()
    {
        return 0;
    }

    public void GetSummary()
    {

    }

}