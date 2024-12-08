using System;
using System.Collections.Generic;

namespace MindfulnessProgram
{   
    // Class for the Reflection Activity
    public class ReflectionActivity : MindfulnessProgram
    {   
        // Prompts for reflection
        private List<string> _prompts = new List<string>
        {
            "Think of a time when you stood up for someone else.",
            "Think of a time when you did something really difficult.",
            "Think of a time when you helped someone in need.",
            "Think of a time when you did something truly selfless."
        };

        // Questions for deeper reflections
        private List<string> _questions = new List<string>
        {
            "Why was this experience meaningful to you?",
            "Have you ever done anything like this before?",
            "How did you get started?",
            "How did you feel when it was complete?",
            "What made this time different than other times when you were not as successful?",
            "What is your favorite thing about this experience?",
            "What could you learn from this experience that applies to other situations?",
            "What did you learn about yourself through this experience?",
            "How can you keep this experience in mind in the future?"
        };

        // Execute the reflection activity
        public void ExecuteActivity()
        {
            Random rand = new Random();
            string prompt = _prompts[rand.Next(_prompts.Count)];

            Console.WriteLine(prompt);
            ShowCountdown(5);

            DateTime endTime = DateTime.Now.AddSeconds(_durationInSecond);

            while (DateTime.Now < endTime)
            {
                string question = _questions[rand.Next(_questions.Count)];
                Console.WriteLine(question);
                ShowSpinner(3);
            }
            EndActivity(); // Call to end the activity
        }

        private void ShowSpinner(int seconds)
        {
            string[] spinner = {"/", "-", "\\", "|"}; // Spinner characters
            for (int i = 0; i < seconds; i++) // Loop for the specified seconds
            {
                foreach (var s in spinner)
                {
                    Console.Write(s + "\r"); // Display spinner
                    Thread.Sleep(250); // Pause briefly
                }
            }
        }
    }
}