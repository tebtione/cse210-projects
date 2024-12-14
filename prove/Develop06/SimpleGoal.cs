using System;

namespace EternalQuest
{
    public class SimpleGoal : Goal
    {
        // Constructor initializing the simple goal
        public SimpleGoal(string name, int points) : base(name, points)
        {

        }

        // Marks the goal as completed
        public override void RecordEvent()
        {
            IsCompleted = true;
        }

        // Returns the status of the simple goal (completed or not)
        public override string GetStatus()
        {
            return IsCompleted ? "[X] " + Name : "[ ]" + Name;
        }

        public override string GetStringRepresentation()
        {
            return $"SimpleGoal:{Name},{Points},{IsCompleted}";
        }

    }
}