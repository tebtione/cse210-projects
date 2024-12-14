using System;

namespace EternalQuest
{
    public class NegativeGoal : Goal
    {
        public NegativeGoal(string name, int points) : base(name, points)
        {

        }

        public override void RecordEvent()
        {
            IsCompleted = true;
            Points = Math.Abs(Points);
        }

        public override string GetStatus()
        {
            return IsCompleted ? "[X] " + Name : "[ ]" + Name;
        }

        public override string GetStringRepresentation()
        {
            return $"NegativeGoal:{Name},{Points},{IsCompleted}";
        }
    }
}