using System;
using System.IO;
using System.Text;
using System.Collections.Generic;

public class Entry
{
    DateTime theCurrentTime = DateTime.Now;
    Prompt prompts = new Prompt();

    public string _date;
    public string _input;
    public string _prompt;

    public void Write()
    {
        _date = theCurrentTime.ToShortDateString();
        _prompt = prompts.GetPrompt();
        Console.WriteLine(_prompt);
        _input = Console.ReadLine();
    }
}


