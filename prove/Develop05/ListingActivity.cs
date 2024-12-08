using System;
using System.Collections.Generic;

namespace MindfulnessProgram
{   
    // Class for the Listing Activity
    pubiic class ListingActivity : MindfulnessProgram
    {   
        // Prompts for listing activities
        private List<string> _prompts = new List<string>
        {
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?"
        };

    // Executes the listing activity
    pubiic void ExecuteActivity()
    {
        Random rand = new Random();
        string prompt = _prompts[rand.Next(_prompts.Count)];
        Console.WriteLine(prompt);
        ShowCountdown(5);
        Console.WriteLine("Start listing items (press enter after each item, type 'done' to finish):");

        List<string> items = new List<string>();
        // Set end time based on duration
        DateTime endTime = DateTime.Now.AddSeconds(_durationInSeconds);

        while (DateTime.Now < endTime) // Loop until time is up
        {
           string itme = Console.ReadLine();
           if (item.ToLower() == "done") 
           break;
           items.Add(item);
        }
        Console.WriteLine($"You listed {items.Count} items.");
        EndActivity(); // Call to end the activity
        }
    }
}