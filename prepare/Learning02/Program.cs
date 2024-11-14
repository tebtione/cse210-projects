using System;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello Learning02 World!");
    
        //Create Job instances
        Job job1 = new Job("Softwar Engineer", "Micrsoft", 2019, 2022);
        Job job2 = new Job("Manager", "Apple", 2022, 2023);

        //Create Resume instance
        Resume myResume = new Resume("Allision Rose");

        myResume.AddJob(job1);
        myResume.AddJob(job2);

        //Display the resume
        myResume.Display();
    }
}