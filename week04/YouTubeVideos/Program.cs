using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        Video video1 = new Video("Learning C# Basics", "Code Academy", 600);
        video1.AddComment(new Comment("Alice", "Great explanation!"));
        video1.AddComment(new Comment("Bob", "Very helpful."));
        video1.AddComment(new Comment("Charlie", "Clear and simple."));
        videos.Add(video1);

        Video video2 = new Video("Understanding OOP", "Dev Tutorials", 720);
        video2.AddComment(new Comment("Diana", "This made OOP click."));
        video2.AddComment(new Comment("Ethan", "Nice examples."));
        video2.AddComment(new Comment("Fiona", "Well structured."));
        videos.Add(video2);

        Video video3 = new Video("C# Collections", "Programming Hub", 540);
        video3.AddComment(new Comment("George", "Exactly what I needed."));
        video3.AddComment(new Comment("Hannah", "Easy to follow."));
        video3.AddComment(new Comment("Ian", "Good pace."));
        videos.Add(video3);

        foreach (Video video in videos)
        {
            Console.WriteLine($"Title: {video.Title}");
            Console.WriteLine($"Author: {video.Author}");
            Console.WriteLine($"Length: {video.LengthInSeconds} seconds");
            Console.WriteLine($"Number of Comments: {video.GetNumberOfComments()}");

            foreach (Comment comment in video.GetComments())
            {
                Console.WriteLine($" - {comment.CommenterName}: {comment.CommentText}");
            }

            Console.WriteLine();
        }
    }
}
