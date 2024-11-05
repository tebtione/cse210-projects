using System;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello Prep2 World!");

        //Ask the user for grade percentage
        Console.Write("Enter your grade percentage: ");
        int gradePercentage = int.Parse(Console.ReadLine());

        //Determin the letter grade
        if (gradePercentage >= 90)

        {
            Console.WriteLine("Your letter grade is A.");
        }
        else if (gradePercentage >= 80)
        {
            Console.WriteLine("Your letter grade is B.");
        }
        else if (gradePercentage >= 70)
        {
            Console.WriteLine("Your letter grade is C.");
        }
        else if (gradePercentage >= 60)
        {
            Console.WriteLine("Your letter grade is D.");
        }
        else
        {
            Console.WriteLine("Your letter grade is F.");
        }
        if (gradePercentage >= 70)
        {
            Console.WriteLine("Congratulation! You passed the course.");
        }
        else
        {
            Console.WriteLine("This is not it! Keep trying for next time.");
        }
    }
}