using System;

class Program
{
    static void Main(string[] args)
    {

        Comment comment1 = new Comment("@lifeIsGood", "So funny!");
        Comment comment2 = new Comment("@user-darth-vader", "This cracks me up!");
        Comment comment3 = new Comment("@amy-93", "Such a cute video! Love it.");
        Video video1 = new Video("Funny babies", "Funny Guy", 125);
        video1._comments.Add(comment1);
        video1._comments.Add(comment2);
        video1._comments.Add(comment3);
        //or video1.AddComment(comment1);


        Video video2 = new Video("Giant Fruits", "Mr.Farmer", 185);


        Video video3 = new Video("My favorite Shabu Shabu", "Tanaka", 345);


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