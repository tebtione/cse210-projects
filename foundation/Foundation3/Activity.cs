using System;

public abstract class Activity // Base class
{
    protected int _minutes; // Protected membner variable to store the duration

    // Constructor to initialize the activity
    public Activity(int minutes)
    {
        _minutes = minutes;
    }

    // Abstract method to get the distance
    public abstract double GetDistance();
    public double GetSpeed() // Method to calculate speed
    {
        double distance = GetDistance();
        return distance > 0 ? (distance / _minutes) * 60 : 0;
    }
    public double GetPace() // Method to calculate pace
    {
        double distance = GetDistance();
        return distance > 0 ? _minutes / distance : 0;
    }

    public virtual string GetSummary() // Method to get a summary of the activity details
    {
        double distance = GetDistance();
        double speed = GetSpeed();
        double pace = GetPace();
        return $"Distance: {distance:F2} km, Speed: {speed:F2} km/h, Pace: {pace:F2} min/km";
    }
}