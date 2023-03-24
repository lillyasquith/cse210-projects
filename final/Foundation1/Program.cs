using System;

class Program
{
    static void Main(string[] args)
    {

        Comment comment1 = new Comment("Ms.A", "So funny!");
        Comment comment2 = new Comment("Cathy", "This cracks me up!");
        Comment comment3 = new Comment("Amy", "LOL! so fun to watch these cuties!");
        Video video1 = new Video("Funny babies", "Nicole", 125);
        // video1.DisplayVideo();
        // Console.WriteLine();
        video1._comments.Add(comment1);
        video1._comments.Add(comment2);
        video1._comments.Add(comment3);




        Video video2 = new Video("Giant Fruits", "Mr.Farmer", 185);
        // video2.DisplayVideo();
        // Console.WriteLine();

        Video video3 = new Video("My favorite Shabu Shabu", "Tanaka", 345);
        // video3.DisplayVideo();
        // Console.WriteLine();



        List<Video> videos = new List<Video>();
        videos.Add(video1);
        videos.Add(video2);
        videos.Add(video3);

        foreach (Video video in videos)
        {
            video.DisplayVideo();
            Console.WriteLine();
        }



    }
}