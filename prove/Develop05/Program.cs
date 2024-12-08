using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Develop05 World!");

        // Main loop for choosing activities
        while (true)
        {
            Console.Clear();
            Console.WriteLine("Choose an activity:");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflection Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Exit");

            string choice = Console.ReadLine(); // Read user choice
            switch (choice) // Handle user choice
            {
                case "1": 
                BreathingActivity breathingActivity = new BreathingActivity();
                // Create instance of BreathingActivity

                breathingActivity.StartActivity(); // Start the activity
                breathingActivity.ExecuteActivity();
                break;

                case "2":
                ReflectionActivity reflectionActivity = new ReflectionActivity();

                reflectionActivity.StartActivity();
                reflectionActivity.ExecuteActivity();
                break;

                case "3":
                ListingActivity listActivity = new ListingActivity();

                listActivity.StartActivity();
                listActivity.ExecuteActivity(); // Execute the activity
                break;

                case "4":
                return; // Exit the program

                default:
                Console.WriteLine("Invalid choice. Please try again.");
                break;
            }
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey(); // Wait for the user input
            
        }
    }
}