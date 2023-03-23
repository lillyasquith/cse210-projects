using System;

class Video
{
    private string _title;
    private string _author;
    private int _length;

    List<Comment> comments = new List<Comment>();

    public Video(string title, string author, int length)
    {
        _title = title;
        _author = author;
        _length = length;
    }
    public void DisplayVideo()
    {

    }
    public int NumberOfComment(List<Comment> comments)
    {
        return 0;
    }


}