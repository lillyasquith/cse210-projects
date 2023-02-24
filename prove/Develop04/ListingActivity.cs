using System;
class ListingActivity : Activity
{
    List<string> _prompts = new List<string>();
    private int _numberOfAnwser = 1;
    private string _userInput;

    public ListingActivity(int numberOfAnswer, string name, string description, int time) : base(name, description, time)
    {
        _numberOfAnwser = numberOfAnswer;
    }
    public string RandomListingPrompt()
    {
        Console.WriteLine("List as many responses you can to the following prompt:");
        Console.WriteLine("You may begin in...");
        Random rd = new Random();
        _prompts.Add("Who are people that you appreciate?");
        _prompts.Add("What are personal strengths of yours?");
        _prompts.Add("Who are people that you have helped this week?");
        _prompts.Add("When have you felt the Holy Ghost this month?");
        _prompts.Add("Who are some of your personal heroes?");
        int index = rd.Next(_prompts.Count);
        Console.WriteLine($"---{_prompts[index]}---");
        _userInput = Console.ReadLine();
        return (_prompts[index]);
    }
    public void CountAnswer()
    {

        // while ()
        // {
        //     _numberOfAnwser += 1;
        //     Console.WriteLine($"You listed {_numberOfAnwser} items!");
        // }


    }

}