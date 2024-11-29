using System;
using System.Collections.Generic;

public class Video
{
    // Properties for the video's title, author, and length in seconds
    public string title { get; set; }
    public string author { get; set; }
    public int length_in_seconds { get; set; }

    // Private list to store comments
    private List<Comment> comments;

    // Constructor to initiliaze a video object
    public Video(string title, string author, int lenghtInSeconds)
    {
        this.title = title;
        this.author = author;
        length_in_seconds = lenghtInSeconds;
        comments = new List<Comment>();
    }

    // Method to add a comment to the video
    public void AddComment(Comment comment)
    {
        comments.Add(comment);
    }

    // Method to get the number of comments
    public int GetCommentCount()
    {
        return comments.Count;
    }

    // Method to get all comments
    public List<Comment> GetComments()
    {
        return comments;
    }
}