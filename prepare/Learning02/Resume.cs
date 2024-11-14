using System;
//using System.Collections.Generic;

//Define the Resume class
public class Resume             
{
    private string _name;       
    private List<Job> _jobs;    //List to hold Job instances

    // Constructor to initialize the Resume object with a name
    public Resume(string name)  
    {
        _name = name;
        _jobs = new List<Job>(); //Initialize the list of jobs
    }

    // Method to add a job to the resume
    public void AddJob(Job job)
    {
        _jobs.Add(job);
    }

    // Method to display the resume details
    public void Display()
    {
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine("Jobs:");
        foreach (Job job in _jobs)
        {
            job.DisplayJobDetails();
        }
    }
}