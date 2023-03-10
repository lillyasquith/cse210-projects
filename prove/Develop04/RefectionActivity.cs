using System;
using System.Collections.Generic;
class RefectingActivity : Activity
{
    List<string> _reflectionStatements = new List<string>();
    List<string> _reflectionPrompts = new List<string>();
    public RefectingActivity(string name, string description) : base(name, description)
    {

    }
    public void GetRandomPrompt()
    {
        Random random = new Random();
        _reflectionPrompts.Add("Think of a time when you stood up for someone else.");
        _reflectionPrompts.Add("Think of a time when you did something really difficult.");
        _reflectionPrompts.Add("Think of a time when you helped someone in need.");
        _reflectionPrompts.Add("Think of a time when you did something truly selfless.");
        int index = random.Next(_reflectionPrompts.Count);
        Console.WriteLine("Consider the following promt:");
        Console.WriteLine($"--- {_reflectionPrompts[index]} ---");

    }
    public void ToBegin2()
    {
        Console.WriteLine("When you have something in mind, press enter to continue.");
        Console.ReadLine();
        Console.WriteLine("Now ponder on each of the following questions as they related to this experience.");
        Console.Write("You may begin in...");
        Random rad = new Random();
        CountDown(rad.Next(4, 5));
    }
    public void GetRandomQuestion()
    {
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(_activityDuration);
        while (DateTime.Now <= futureTime)
        {
            Random rd = new Random();
            _reflectionStatements.Add("Why was this experience meaningful to you?");
            _reflectionStatements.Add("Have you ever done anything like this before?");
            _reflectionStatements.Add("How did you get started?");
            _reflectionStatements.Add("How did you feel when it was complete?");
            _reflectionStatements.Add("What made this time different than other times when you were not as successful?");
            _reflectionStatements.Add("What is your favorite thing about this experience?");
            _reflectionStatements.Add("What could you learn from this experience that applies to other situations?");
            _reflectionStatements.Add("What did you learn about yourself through this experience?");
            _reflectionStatements.Add("How can you keep this experience in mind in the future?");

            int index = rd.Next(_reflectionStatements.Count);
            Console.Write($"\n> {_reflectionStatements[index]} ");
            Animation();
            Thread.Sleep(1000);
            Console.WriteLine();
            if (DateTime.Now == futureTime)
            {
                break;
            }

        }
    }

}