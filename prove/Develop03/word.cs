using System;

class Word
{
    private string _word;
    private string _visibleWord;
    private string _hiddenWord;
    private bool _isHidden;

    public Word(string word)
    {
        _isHidden = false;
        _visibleWord = word;
        _hiddenWord = "_";

    }
    public void WriteWord()
    {
        if (_isHidden == false)
        {
            _word = _visibleWord;
            Console.Write($" {_visibleWord} ");
        }
        else
        {
            _word = _hiddenWord;
            Console.Write($" {_hiddenWord} ");
        }
    }
    public void HideWord()
    {
        _isHidden = true;
    }
    // Practice with Getters and Setters
    // public string GetVisibleWord()
    // {
    //     return _visibleWord;
    // }
    // public void SetVisibleWord(string visibleWord)
    // {
    //     _visibleWord = visibleWord;
    // }
    // public string GetHiddenWord()
    // {
    //     return _hiddenWord;
    // }
    // public void SetHiddenWord(string hiddenWord)
    // {
    //     _hiddenWord = hiddenWord;
    // }

}