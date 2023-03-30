using System;

class Event
{
    public Address _address;
    protected string _eventTitle;
    protected string _destription;
    protected string _date;
    protected string _time;
    protected string _eventType;

    public Event(string eventTitle, string destription, string date, string time, Address address)
    {
        _eventTitle = eventTitle;
        _destription = destription;
        _date = date;
        _time = time;
        _address = address;
        _eventType = "";
    }

    public string StandardDetails()//void or string?
    {
        string standard = "";
        standard += $"{_eventTitle}";
        standard += $"{_destription}";
        standard += $"{_date}";
        standard += $"{_time}";
        standard += $"{_address}";
        return standard;
    }
    public void Display()
    {
        Console.WriteLine(StandardDetails());
        _address.DisplayAddress();
    }
    public string FullDetails()
    {
        StandardDetails();
        string full = "";
        return full;
    }
    public string ShortDescription()
    {
        return $"{_eventType} {_eventTitle} {_date}";
    }

}