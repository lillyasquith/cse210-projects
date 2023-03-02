using System;
using System.Collections.Generic;
using System.Threading;
class Scripture
{
    List<Word> scriptures = new List<Word>();
    Reference _reference;
    public Scripture(Reference reference)
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

        _reference = reference;
    }
    public void Display()
    {
        _reference.Display();
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

    //This function will check if all words disappear and close the program.
    public Boolean CheckAllWords()
    {
        foreach (Word word in scriptures)
        {
            if (word.GetIsHidden() == true)
            {

            }
            else
                return false;
        }
        return true;
    }
}

