using System;

namespace EternalQuest
{
    public abstract class Goal
    {
        public string Name { get; protected set; }
        public int Points { get; protected set; }
        public bool IsCompleted { get; protected set; }

        protected Goal(string name, int points)
        {
            Name = name;
            Points = points;
            IsCompleted = false;
        }

        public abstract void RecordEvent();
        public abstract string GetStatus();
        public abstract string GetStringRepresentation();
    }
}