using System;

class Lecture : Event
{
    private string _speakerName;
    private int _capacity;//how many people are allowed to speak?

    public Lecture(string speakerName, int capacity, string eventTitle, string destription, string date, string time, Address address) : base(eventTitle, destription, date, time, address)
    {
        _speakerName = speakerName;
        _capacity = capacity;
    }

    // public void FullDetails()
    // {
    //     StandardDetails();
    //     string full = "";
    //     full += $"{_speakerName}";
    //     full += $"{_capacity}";
    // }

}