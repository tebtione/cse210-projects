using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello Prep4 World!");

        List<int> numbers = new List<int>();

        Console.WriteLine("Enter a list of numbers, type 0 when done.");

        while (true)
        {
            Console.Write("Enter the number: ");
            int input = int.Parse(Console.ReadLine());

            if (input == 00)
            {
                break;
            }

            numbers.Add(input);
        }

        //Compute the sum
        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }
        Console.WriteLine($"The sume is: {sum}");

        //Compute the average
        double average = (double)sum / numbers.Count;
        Console.WriteLine($"The average is: {average}");

        //Find the max
        int maxNumber = numbers[0]; //Assume the first number is the max
        foreach (int number in numbers)
        {
            if (number > maxNumber)
            {
                maxNumber = number; //Upadte the maxNumber if is found
            }
        }
        Console.WriteLine($"The max number is: {maxNumber}");
    }
}