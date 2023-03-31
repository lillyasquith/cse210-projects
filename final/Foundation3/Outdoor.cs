using System;

class Outdoor : Event
{
    private string _weather;

    public Outdoor(string weather, string eventTitle, string destription, string date, string time, Address address) : base(eventTitle, destription, date, time, address)
    {
        _weather = weather;
        _eventType = "Outdoor";
    }
    public void OutdoorFullDetails()
    {
        Console.WriteLine($"Full details:");
        Console.WriteLine($"*{_eventType}*");
        Console.WriteLine($"'{_eventTitle}'");
        Console.WriteLine($"--{_destription}--");
        Console.WriteLine($"{_weather}");
        Console.WriteLine($"{_date} @ {_time}");
        _address.DisplayAddress();
    }
}