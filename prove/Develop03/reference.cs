using System;
class Reference
{
    private string _book;
    private int _chapter;
    private int _verseStart;
    private int _verseEnd;
    public Reference(string book, int chapter, int verse)
    {
        _book = book;
        _chapter = chapter;
        _verseStart = verse;
    }

    //adjust the responsibilities of a Reference (including handling multiple verses)
    public Reference(string book, int chapter, int verse, int verseEnd)
    {
        _book = book;
        _chapter = chapter;
        _verseStart = verse;
        _verseEnd = verseEnd;
    }
    public void Display()
    {
        Console.Write($"{_book} {_chapter}:{_verseStart}-{_verseEnd}");
    }

}
