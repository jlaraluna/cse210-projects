using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the YouTubeVideos Project.");

        Video video1 = new Video();
        video1.title = "The Chosen";
        video1.author = "Entertainment Media";
        video1.length = 60;
        video1.comments.Add(new Comment("Alice", "Amazing video!"));
        video1.comments.Add(new Comment("Bob", "Very emotional."));
        video1.comments.Add(new Comment("Charlie", "Can't wait for the next episode!"));

        Video video2 = new Video();
        video2.title = "Space Exploration";
        video2.author = "Science Daily";
        video2.length = 300;
        video2.comments.Add(new Comment("Dana", "I love this channel."));
        video2.comments.Add(new Comment("Eli", "Great explanation of space travel."));
        video2.comments.Add(new Comment("Fay", "Thanks for the visuals!"));

        Video video3 = new Video();
        video3.title = "Pasta Recipe";
        video3.author = "Chef Mario";
        video3.length = 180;
        video3.comments.Add(new Comment("Grace", "Delicious and simple!"));
        video3.comments.Add(new Comment("Hank", "I made this for dinner."));
        video3.comments.Add(new Comment("Ivy", "Add garlic next time!"));

        List<Video> videoList = new List<Video> { video1, video2, video3 };

        foreach (Video v in videoList)
        {
            Console.WriteLine($"\nTitle: {v.title}");
            Console.WriteLine($"Author: {v.author}");
            Console.WriteLine($"Length: {v.length} seconds");
            Console.WriteLine($"Number of comments: {v.GetNumberOfComments()}");
            Console.WriteLine("Comments:");
            foreach (Comment c in v.comments)
            {
                Console.WriteLine($"- {c.name}: {c.text}");
            }
        }
    }
}
