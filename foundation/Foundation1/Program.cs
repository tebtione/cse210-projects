using System;

public class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello Foundation1 World!");

        // Create a list to hold multiple videos
        List<Video> videos = new List<Video>();

        // Create video objects and add comments to each
        Video video1 = new Video("Understanding Abstraction in C#", "Jane Doe", 300);
        video1.AddComment(new Comment("Alice", "Great explanation!"));
        video1.AddComment(new Comment("Bob", "Thanks for the tips."));
        video1.AddComment(new Comment("Charlie", "This was really helpful!"));

        Video video2 = new Video("OOP Concepts Explained", "John Smith", 450);
        video2.AddComment(new Comment("Dave", "Interesting content!"));
        video2.AddComment(new Comment("Eve", "I learned a lot."));
        video2.AddComment(new Comment("Frank", "Can't wait for the next video!"));

        Video video3 = new Video("C# for Beginner", "Sara Lee", 600);
        video3.AddComment(new Comment("Grace", "This is fantastic series"));
        video3.AddComment(new Comment("Heidi", "Well done!"));

        // Add the created videos objects to the list
        videos.Add(video1);
        videos.Add(video2);
        videos.Add(video3);

        //Iterate through the videos and display their information
        foreach (var video in videos)
        {
            Console.WriteLine($"Title: {video.title}");
            Console.WriteLine($"Author: {video.author}");
            Console.WriteLine($"Length: {video.length_in_seconds} seconds");
            Console.WriteLine($"Number of Comments: {video.GetCommentCount()}");

            Console.WriteLine("Comments:");

            // Iterate through each comment and display the commneter's name and text
            foreach (var comment in video.GetComments())
            {
                Console.WriteLine($"- {comment.commenter_name}: {comment.text}");
            }
            Console.WriteLine(); // Add an empty line for better readability
        }

    }
}