using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Foundation3 World!");

        // Create a list to store different types of activities
        List<Activity> activities = new List<Activity>
        {
            new Running(30, 5), // Create a running activity
            new Cycling(45, 15), // Create a cycling activity
            new Swimming(20, 30), // Create a swimming activity
        };

        // Iterate through the list of activities and print
        foreach (var activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}