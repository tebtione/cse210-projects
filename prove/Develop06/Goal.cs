using System;

namespace EternalQuest
{
    // Properties for the goal's name, points, and completion status
    public abstract class Goal
    {
        public string Name { get; protected set; }
        public int Points { get; protected set; }
        public bool IsCompleted { get; protected set; }

        // Constructor initializing the goal's name and points
        protected Goal(string name, int points)
        {
            Name = name;
            Points = points;
            IsCompleted = false;
        }

        // Abstract methods
        public abstract void RecordEvent();
        public abstract string GetStatus();
        public abstract string GetStringRepresentation();
    }
}