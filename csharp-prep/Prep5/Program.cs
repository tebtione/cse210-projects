using System;

namespace Prep5
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello Prep5 World!");

            Console.WriteLine("Welcome to the Program!");
            Console.Write("Please enter your name: ");
            string name = Console.ReadLine();

            Console.Write("Please entery your favourite number: ");
            int number = int.Parse(Console.ReadLine());

            int squared = number * number;
            Console.WriteLine($"{name}, the square of your number is {squared}");
        }
    }
}