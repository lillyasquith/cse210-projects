using System;

class Comment
{
    private string _personName;
    private string _text;

    public Comment(string personName, string text)
    {
        _personName = personName;
        _text = text;
    }

    public void DisplayComment()
    {
        Console.WriteLine($"{_personName}");
        Console.WriteLine($"'{_text}'");
    }
}