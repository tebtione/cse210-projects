using System;
using System.Collections.Generic;

public class Comment
{
    // Properties for the name of the commenter and the comment text
    public string commenter_name { get; set; }
    public string text { get; set; }

    // Constructor to initialize a comment object
    public Comment(string commenterName, string text)
    {
        commenter_name = commenterName;
        this.text = text;
    }
}