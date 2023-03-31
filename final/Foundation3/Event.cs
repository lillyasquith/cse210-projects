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
    public void DisplayStandardDetails()
    {
        Console.WriteLine($"Standard details:");
        Console.WriteLine($"'{_eventTitle}'");
        Console.WriteLine($"--{_destription}--");
        Console.WriteLine($"{_date} @ {_time}");
        _address.DisplayAddress();
    }
    public string DisplayFullDetails()//do I need this function?
    {
        return "";
    }
    public void DisplayShortDescription()
    {
        Console.WriteLine($"Short description:");
        Console.WriteLine($"*{_eventType}*");
        Console.WriteLine($"'{_eventTitle}'");
        Console.WriteLine($"{_date}");
    }

}