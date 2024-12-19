using System;

public class Cycling : Activity
{
    // Private member variables to store the distance
    private double _distanceKm;

    // Constructor to initialize the cyclying activity
    public Cycling(int minutes, double distanceKm) : base(minutes)
    {
        _distanceKm = distanceKm;
    }

    // Override the GetDistance method
    // to return the distance of the ride
    public override double GetDistance()
    {
        return _distanceKm;
    }
}