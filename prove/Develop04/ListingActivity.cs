using System;
class ListingActivity : Activity
{
    private int _numberOfAnwser;

    public ListingActivity(int numberOfAnswer, string name, string description, int time) : base(name, description, time)
    {
        _numberOfAnwser = numberOfAnswer;
    }
    // public string RandomListingPrompt()
    // {

    // }
    // public void CountAnswer()
    // {

    // }

}