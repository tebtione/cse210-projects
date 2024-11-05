using System;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello Prep2 World!");

        //Ask the user for their grade percentage
        Console.Write("Enter your grade percentage: ");
        int gradePercentage = int.Parse(Console.ReadLine());

        string letter = "";

        //Determine the letter grade
        if (gradePercentage >= 90)

        {
            letter = "A";
        }
        else if (gradePercentage >= 80)
        {
            letter = "B";
        }
        else if (gradePercentage >= 70)
        {
            letter = "C";
        }
        else if (gradePercentage >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        //Print the letter grade once
        Console.WriteLine($"Your letter grade is {letter}.");

        if (gradePercentage >= 70)
        {
            Console.WriteLine("Congratulation! You passed the course.");
        }
        else
        {
            Console.WriteLine("You can do better! Keep trying for next time.");
        }
    }
}