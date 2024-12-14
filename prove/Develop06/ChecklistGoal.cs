using System;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;

namespace EternalQuest
{
    public class ChecklistGoal : Goal
    {
        public int TimesCompleted { get; private set; }
        public int CompletionTarget { get; private set; }
        public int BonusPoints { get; private set; }

        public ChecklistGoal(string name, int points, int target, int bonus) : base(name, points)
        {
            CompletionTarget = target;
            BonusPoints = bonus;
            TimesCompleted = 0;
        }

        public override void RecordEvent()
        {
            if (!IsCompleted)
            {
                TimesCompleted++;
                Points += Points;
                if (TimesCompleted >= CompletionTarget)
                {
                    Points += BonusPoints;
                    IsCompleted = true;
                }
            }
        }

        public override string GetStatus()
        {
            return $"{(IsCompleted ? "[X]" : "[ ]")} {Name} (Completed {TimesCompleted}/{CompletionTarget} times)";
        }

        public override string GetStringRepresentation()
        {
            return $"CheckedlistGoal:{Name},{Points},{TimesCompleted},{CompletionTarget},{BonusPoints},{IsCompleted}";
        }
    }
}