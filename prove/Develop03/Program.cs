using System;
using System.Collections.Generic;

namespace ScriptureMemorizer
{

    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello Develop03 World!");

            var scripture1 = new Scripture(new Reference("Proverbs", 3, 5, 6), "Trust in the Lord with all thine heart; and lean not unto thine own understanding. In all thy ways acknowledge him, and he shall direct thy paths.");
            //var scripture2 = new Scripture(new Reference("John", 3, 26), "For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life.”);

            var currentScripture = scripture1;

            while (true)
            {
                Console.Clear();
                Console.WriteLine(currentScripture.GetDisplayText());
                Console.WriteLine("Press Enter to hide a word or type 'quit' to exit.");

                var input = Console.ReadLine();
                if (input?.ToLower() == "quit")
                {
                    break;
                }

                currentScripture.HideRandomWords(1);
                if (currentScripture.IsCompletelyHidden())
                {
                    Console.Clear();
                    Console.WriteLine(currentScripture.GetDisplayText());
                    Console.WriteLine("All words are now hidden. Press Enter to exit.");
                    Console.ReadLine();
                    break;
                }
            }
        }
    }
}