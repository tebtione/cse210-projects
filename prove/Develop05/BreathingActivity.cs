using System;

namespace MindfulnessProgram
{
    // Class for the Breathing Activity
    public class BreathingActivity : MindfulnessActivity
    {
        public BreathingActivity() : base("Breathing Activity", "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.")
        {

        }
        public override void Execute()
        {
            StartActivity();
            // Set end time based on duration
            DateTime endTime = DateTime.Now.AddSeconds(_durationInSeconds);

            while (DateTime.Now < endTime)
            {
                Console.WriteLine("Breathe in...");
                ShowSpinner(4);
                Console.WriteLine("Breathe out...");
                ShowSpinner(4);
            }
            EndActivity(); // Call to end the activity
        }
    }
}