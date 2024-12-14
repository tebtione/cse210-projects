using System;
using System.Collections.Generic;
using System.IO;

namespace EternalQuest
{
    public class Program
    {
        private static List<Goal> _goals = new List<Goal>();
        private static int _totalScore = 0;
        private static int _level = 1;
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello Develop06 World!");
            LoadGoals();
            ShowMenu();
        }

        private static void ShowMenu()
        {
            while (true)
            {
                Console.WriteLine("\nEternal Quest Menu:");
                Console.WriteLine("1. Add Goal");
                Console.WriteLine("2. Record Event");
                Console.WriteLine("3. Show Goals");
                Console.WriteLine("4. Show Score and Level");
                Console.WriteLine("5. Save Goals");
                Console.WriteLine("6. Exit");
                Console.Write("Choose an option: ");

                string choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        AddGoal();
                        break;
                    case "2":
                        RecordEvent();
                        break;
                    case "3":
                        ShowGoals();
                        break;
                    case "4":
                        ShowScore();
                        break;
                    case "5":
                        SaveGoals();
                        break;
                    case "6":
                        return;
                    default:
                        Console.WriteLine("Invalid choice. Try Next time.");
                        break;
                }
            }
        }

        private static void AddGoal()
        {
            Console.Write("Enter goal type (simple/eternal/checklist/negative): ");
            string type = Console.ReadLine().ToLower();
            Console.Write("Enter goal name: ");
            string name = Console.ReadLine();
            Console.Write("Enter points: ");
            int points = int.Parse(Console.ReadLine());

            switch (type)
            {
                case "simple":
                    _goals.Add(new SimpleGoal(name, points));
                    break;
                case "eternal":
                    _goals.Add(new EternalGoal(name, points));
                    break;
                case "checklist":
                    Console.Write("Enter target number of completions: ");
                    int target = int.Parse(Console.ReadLine());
                    Console.Write("Enter bonus points: ");
                    int bonus = int.Parse(Console.ReadLine());
                    _goals.Add(new ChecklistGoal(name, points, target, bonus));
                    break;
                case "negative":
                    _goals.Add(new NegativeGoal(name, points));
                    break;
                default:
                    Console.WriteLine("Unknown goal type.");
                    break;
            }
        }

        private static void RecordEvent()
        {
            Console.Write("Enter goal index to record even (0 to {0})", _goals.Count - 1);
            int index = int.Parse(Console.ReadLine());
            if (index >= 0 && index < _goals.Count)
            {
                _goals[index].RecordEvent();
                _totalScore += _goals[index].Points;
                UpdateLevel();
                Console.WriteLine("Event recorded!");
            }
            else
            {
                Console.WriteLine("Invalid index.");
            }
        }

        private static void UpdateLevel()
        {
            _level = _totalScore / 1000 + 1;
        }

        private static void ShowGoals()
        {
            for (int i = 0; i < _goals.Count; i++)
            {
                Console.WriteLine($"{i}: {_goals[i].GetStatus()}");
            }
        }

        private static void ShowScore()
        {
            Console.WriteLine($"Total Score: {_totalScore}");
            Console.WriteLine($"Current Level: {_level}");
        }

        private static void SaveGoals()
        {
            using (StreamWriter writer = new StreamWriter("goals.txt"))
            {
                foreach (var goal in _goals)
                {
                    writer.WriteLine(goal.GetStringRepresentation());
                }
                writer.WriteLine($"Score:{_totalScore}");
                writer.WriteLine($"Level:{_level}");
            }
            Console.WriteLine("Goals saved.");
        }

        private static void LoadGoals()
        {
            if (File.Exists("goal.txt"))
            {
                string[] lines = File.ReadAllLines("goals.txt");
                foreach (string line in lines)
                {
                    string[] parts = line.Split(':');
                    switch (parts[0])
                    {
                        case "SimpleGoal":
                            string[] simpleDetails = parts[1].Split(','); _goals.Add(new SimpleGoal(simpleDetails[0], int.Parse(simpleDetails[1]))
                            { IsCompleted = bool.Parse(simpleDetails[2]) });
                            break;

                        case "EternalGoal":
                            string[] eternalDetails = parts[1].Split(',');
                            _goals.Add(new EternalGoal(eternalDetails[0], int.Parse(eternalDetails[1])));
                            break;

                        case "ChecklistGoal":
                            string[] checklistDetails = parts[1].Split(',');
                            var checklistGoal = new ChecklistGoal(checklistDetails[0], int.Parse(checklistDetails[1]), int.Parse(checklistDetails[3]), int.Parse(checklistDetails[4]))
                            {
                                TimesCompleted = int.Parse(checklistDetails[2]),
                                IsCompleted = bool.Parse(checklistDetails[5])
                            };
                            _goals.Add(checklistGoal);
                            break;

                        case "NegativeGoal":
                            string[] negativeDetails = parts[1].Split(',');
                            _goals.Add(new NegativeGoal(negativeDetails[0], int.Parse(negativeDetails[1]))
                            { IsCompleted = bool.Parse(negativeDetails[2]) });
                            break;

                        case "Score":
                            _totalScore = int.Parse(parts[1]);
                            break;
                        case "Level":
                            _level = int.Parse(parts[1]);
                            break;
                    }
                }
            }
        }
    }
}