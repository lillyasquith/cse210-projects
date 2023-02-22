using System;
class Reference
{
    private string _book;
    private int _chapter;
    private int _verseStart;
    private int _verseEnd;
    public Reference(string book, int chapter, int verse5)
    {
        _book = book;
        _chapter = chapter;
        _verseStart = verse5;
    }
    public Reference(string book, int chapter, int verse5, int verse6)
    {
        _book = book;
        _chapter = chapter;
        _verseStart = verse5;
        _verseEnd += verse6;
    }
    public void Display()
    {
        Console.Write($"{_book} {_chapter}:{_verseStart}-{_verseEnd}");
    }

}