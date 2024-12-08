using System;
using System.Threading;

namespace MindfulnessProgram
{
    public class MindfulnessProgram
    {
        protected int _durationInSeconds;
        protected string _activityName;
        protected string _description;

        public void StartActivity(string activityName, string description)
        {
            _activityName = activityName;
            _description = description;

            Console.Clear();
            Console.WriteLine($"--- {_activityName} ---");
            Console.WriteLine(_description);
            Console.WriteLine("Enter duration in seconds: ");
            _durationInSeconds = int.Parse(Console.ReadLine());
            Console.WriteLine("Get ready...");
            ShowCountdown(5);
        }
        
        public void ShowCountdown(int seconds)
        {
            for (int i = seconds; i > 0; i==)
            {
                Console.Write(i + " ");
                Thread.Sleep(1000);
            }
            Console.WriteLine();
        }

        protected void EndActivity()
        {
           Console.WriteLine("Well done!");
           Console.WriteLine($"You completed the (_activityName) for {_durationInSeconds} seconds");
           ShowCountdown(5) 
        }
    }
}