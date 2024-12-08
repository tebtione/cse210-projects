using System;

namespace MindfulnessProgram
{   
    // Class for the Breathing Activity
    public class BreathingActivity : MindfulnessProgram
    {
        public void ExecuteActivity()
        {   
            // Set end time based on duration
            DateTime endTime = DateTime.Now.AddSeconds(_durationInSeconds);

            while (DateTime.Now < endTime)
            {
                Console.WriteLine("Breathe in...");
                ShowCountdown(4);
                Console.WriteLine("Breathe out...");
                ShowCountdown(4);
            }
            EndActivity(); // Call to end the activity
        }
    }
}