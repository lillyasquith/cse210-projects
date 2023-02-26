using System;
class ListingActivity : Activity
{
    List<string> _prompts = new List<string>();
    private int _numberOfAnwser = 1;
    private string _userInput;

    public ListingActivity(int numberOfAnswer, string name, string description) : base(name, description)
    {
        _numberOfAnwser = numberOfAnswer;
    }
    public void RandomListingPrompt()
    {

        Console.WriteLine("Consider the following promt:");
        Random rd = new Random();
        _prompts.Add("Who are people that you appreciate?");
        _prompts.Add("What are personal strengths of yours?");
        _prompts.Add("Who are people that you have helped this week?");
        _prompts.Add("When have you felt the Holy Ghost this month?");
        _prompts.Add("Who are some of your personal heroes?");
        int index = rd.Next(_prompts.Count);
        Console.WriteLine();
        Console.WriteLine($"---{_prompts[index]}---");


        Console.Write($"You may begin in...");
        Random rad = new Random();
        CountDown(rad.Next(2, 5));

    }
    public void CountAnswer()
    {
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(_activityDuration);
        Console.WriteLine("List as many responses you can to the following prompt:");
        while (DateTime.Now <= futureTime)
        {
            _userInput = Console.ReadLine();
            _numberOfAnwser += 1;
        }
        Console.WriteLine($"You listed {_numberOfAnwser} items!");
    }

}