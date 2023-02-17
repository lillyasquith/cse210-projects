using System;

class MathAssignment : Assignment
{
    private string _textbookSection;
    private string _problems;

    //using constructor to display
    public MathAssignment(string name, string topic, string textbook, string problems) : base(name, topic)
    {
        _textbookSection = textbook;
        _problems = problems;
    }
    public void Display2()
    {
        Console.WriteLine($"{_textbookSection} {_problems}");
    }

    //------------------------------------
    //using Getters and Setters to display 
    // public MathAssignment() : base()
    // {

    // }
    // public string GetTextbookSection()
    // {
    //     return _textbookSection;
    // }
    // public void SetTextbookSection(string textbook)
    // {
    //     _textbookSection = textbook;
    // }
    // public string GetProblems()
    // {
    //     return _problems;
    // }
    // public void SetProblems(string problems)
    // {
    //     _problems = problems;
    // }

    // public string GetHomeworkList()
    // {
    //     return $"{_textbookSection} - {_problems}";
    // }

    //--------------------------------------
    //using GetHomeworkList function to display
    // public MathAssignment() : base()
    // {

    // }
    // public string GetHomeworkList()
    // {
    //     _textbookSection = "Section 7.3";
    //     _problems = "Problems 8-19";
    //     return $"{_textbookSection} {_problems}";
    // }


}