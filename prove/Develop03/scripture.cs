using System;
using System.Collections.Generic;
using System.Threading;
class Scripture
{
    List<Word> scriptures = new List<Word>();
    Reference reference = new Reference("Proverbs", 3, 5, 6);
    public Scripture()
    {
        string text = "";
        text += "Trust in the Lord with all thine heart and lean not unto thine own understanding; in all thy ways acknowledge him, and he shall direct thy paths.";
        string[] words = text.Split(' ');

        foreach (string word in words)
        {
            //Add text from words array to scriptures list
            Word unit = new Word(word);
            scriptures.Add(unit);
        }
    }
    public void Display()
    {
        reference.Display();
        foreach (Word word in scriptures)
        {
            word.WriteWord();
        }
    }
    public void HideRandomText()
    {
        Random randomText = new Random();
        int i = randomText.Next(scriptures.Count());
        scriptures[i].HideWord();
    }

}
