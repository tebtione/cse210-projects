using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Foundation3 World!");

        List<Activity> activities = new List<Activity>
        {
            new Running(30, 5),
            new Cycling(45, 15),
            new Swimming(20, 30),
        };

        foreach (var activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}