using System;
using System.Runtime.CompilerServices;

class Program
{
    private static Journal journal = new Journal(); // Instance of the Journal class
    private static readonly string[] prompts = { // Array of prompt for a user entries
        "What is one thing I learned today that I can apply to my life moving forward?",
        "Who inspired me today, and what about their actions or words had an impact on me?",
        "How did I see the hand of the Lord in my life today?",
        "What challenges did I face today, and how did I overcome them?",
        "In what ways did I practice gratitude today?",
        "What did I learn about myself or others today?"
    };
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello Develop02 World!");
        while (true) // Infinite loop for menu interaction
        {
            Console.WriteLine("\n1. Write a new entry\n2. Display journal\n3. Save journal\n4. Load journal\n5. Exit");
            switch (Console.ReadLine())
            {
                case "1": WriteNewEntry(); break; // Option to write a new entry
                case "2": journal.DisplayEntries(); break; // Option to display all entries
                case "3": SaveJournal(); break; // Option to save entries to a file
                case "4": LoadJournal(); break; // Option to load entries from a file
                case "5": return; // Exit the program
            }
        }

    }
    static void WriteNewEntry()
    {
        string prompt = prompts[new Random().Next(prompts.Length)]; // Select a random prompt
        Console.WriteLine(prompt);
        Console.Write("Your response: ");
        journal.AddEntry(new Entry { Prompt = prompt, Response = Console.ReadLine(), Date = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") }) // Add the new entry
;
    }
    static void SaveJournal()
    {
        Console.Write("Enter filename to save: ");
        journal.SaveToFile(Console.ReadLine()); // Save journal entries to a file
    }
    static void LoadJournal()
    {
        Console.Write("Enter filenem to load: ");
        journal.LoadFromFile(Console.ReadLine()); // Load journal entries from a file
    }
}