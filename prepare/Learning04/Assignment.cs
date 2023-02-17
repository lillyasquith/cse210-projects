using System;

class Assignment
{
    private string _studentName;
    private string _topic;

    //using constructor to display
    public Assignment(string name, string topic)
    {
        _studentName = name;
        _topic = topic;
    }
    public void Display1()
    {
        Console.WriteLine($"{_studentName} - {_topic}");
    }

    //--------------------------------------
    //using Getters and Setters to display 
    public string GetName()
    {
        return _studentName;
    }
    public void SetName(string name)
    {
        _studentName = name;
    }
    // public string GetTopic()
    // {
    //     return _topic;
    // }

    // public void SetTopic(string topic)
    // {
    //     _topic = topic;
    // }

    // public string GetSummary()
    // {

    //     return $"{_studentName} - {_topic}";
    // }

    //--------------------------------------
    //using GetSumary function to display
    // public string GetSummary()
    // {
    //     _studentName = "Samuel Bennett";
    //     _topic = "Multiplication";
    //     return $"{_studentName} - {_topic}";
    // }

}