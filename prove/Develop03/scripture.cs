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

    // new method to check if all words are hidden
    // CheckAllWords
    //  iterate through word list
    //  call the getIsHidden method to check if the word is hidden or not
    //      if getHiddenWord == true
    //          return true
    //      else 
    //          false

}

