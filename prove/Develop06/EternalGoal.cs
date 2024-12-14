using System;

namespace EternalQuest
{
    public class EternalGoal : Goal
    {
        public EternalGoal(string name, int points) : base(name, points)
        {

        }

        public override void RecordEvent()
        {
            Points += 1; // Points are awarded each time when goal is recorded
        }

        public override string GetStatus()
        {
            return "[ ] " + Name + " (Eternal)";
        }

        public override string GetStringRepresentation()
        {
            return $"EternalGoal:{Name},{Points}";
        }
    }
}