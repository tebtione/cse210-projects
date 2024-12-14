using System;
using System.Threading;

namespace MindfulnessProgram
{
    // Base class for mindfulness activities
    public abstract class MindfulnessActivity
    {
        protected int _durationInSeconds; // Duration of the activity in seconds
        protected string _activityName;
        protected string _description;

        public MindfulnessActivity(string activityName, string description)
        {
            _activityName = activityName;
            _description = description;
        }
        // Starts the activity by displaying its name and description
        public void StartActivity()
        {
            Console.Clear();
            Console.WriteLine($"Starting: --- {_activityName} ---\n");
            Console.WriteLine(_description);
            Console.WriteLine("Enter duration in seconds: ");
            _durationInSeconds = int.Parse(Console.ReadLine());
            Console.WriteLine("Get ready...");
            ShowSpinner(5);
        }

        // End the activity and gives feedback to the user
        protected void EndActivity()
        {
            Console.WriteLine("Well done!");
            Console.WriteLine($"You completed the {_activityName} for {_durationInSeconds} seconds");
            ShowSpinner(5);
        }

        // Display a countdown
        public void ShowSpinner(int seconds)
        {
            for (int i = 0; i < seconds; i++)
            {
                Console.Write(".");
                Thread.Sleep(1000);
            }
            Console.WriteLine();
        }

        public abstract void Execute();
    }
}