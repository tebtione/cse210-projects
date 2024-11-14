using System;

public class Job //Deifne the Job class
{
    //Private member variable for job details
    private string _jobTitle;
    private string _company;
    private int _startYear;
    private int _endYear;

    //Step 3:2 The is the public class Job syntax
    //Constructor to initialize the Job object with job details
    public Job(string jobTitle, string company, int startYear, int endYear)

    {
        _jobTitle = jobTitle;
        _company = company;
        _startYear = startYear;
        _endYear = endYear;
    }

    public void DisplayJobDetails() //Method to display job details in a formatted string
    {
        Console.WriteLine($"{_jobTitle} ({_company}) {_startYear}-{_endYear}");
    }
}

