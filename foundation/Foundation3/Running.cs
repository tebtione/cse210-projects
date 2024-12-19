using System;

// Class representing a running activity, 
// derived from the base Activity class
public class Running : Activity
{
    private double _distanceKm; // Private member variable

    // Constructor to initialize the running activity
    public Running(int minutes, double distanceKm) : base(minutes)
    {
        _distanceKm = distanceKm;
    }

    // Override the GetDistance method
    // to return the distance of the run
    public override double GetDistance()
    {
        return _distanceKm;
    }
}