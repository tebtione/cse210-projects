using System;

namespace EternalQuest
{
    public class NegativeGoal : Goal
    {
        // Constructor initializing the negative goal
        public NegativeGoal(string name, int points) : base(name, points)
        {

        }

        // Record an event
        public override void RecordEvent()
        {
            IsCompleted = true;
            Points = Math.Abs(Points); // Deduct points
        }

        public override string GetStatus()
        {
            return IsCompleted ? "[X] " + Name : "[ ]" + Name;
        }

        // Return a string representative for saving/loading
        public override string GetStringRepresentation()
        {
            return $"NegativeGoal:{Name},{Points},{IsCompleted}";
        }
    }
}