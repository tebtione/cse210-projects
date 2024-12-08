using System;

namespace MindfulnessProgram
{
    public class BreathingActivity : MindfulnessProgram
    {
        public void ExecuteActivity()
        {
            DateTime endTime = DateTime.Now.AddSeconds(_durationInSeconds);
            
            while (DateTime.Now < endTime)
            {
                Console.WriteLine("Breathe in...");
                ShowCountdown(4);
                Console.WriteLine("Breathe out...");
                ShowCountdown(4);
            }
            EndActivity();
        }
    }
}