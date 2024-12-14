using System;
using System.Collections.Generic;

namespace MindfulnessProgram
{
    // Class for the Listing Activity
    public class ListingActivity : MindfulnessActivity
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

        public ListingActivity() : base("List Activity", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.")
        {

        }
        // Executes the listing activity
        public override void Execute()
        {
            StartActivity();
            Random rand = new Random();
            string prompt = _prompts[rand.Next(_prompts.Count)];
            Console.WriteLine(prompt);
            ShowSpinner(5);
            Console.WriteLine("Start listing items (press enter after each item, type 'done' to finish):");

            List<string> items = new List<string>();
            // Set end time based on duration
            DateTime endTime = DateTime.Now.AddSeconds(_durationInSeconds);

            while (DateTime.Now < endTime) // Loop until time is up
            {
                string item = Console.ReadLine();
                if (item.ToLower() == "done")
                    break;
                items.Add(item);
            }
            Console.WriteLine($"You listed {items.Count} items.");
            EndActivity(); // Call to end the activity
        }
    }
}