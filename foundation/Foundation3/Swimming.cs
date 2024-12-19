using System;

// Class representing a swimmimg activity
// derive from the base activity class
public class Swimming : Activity
{
    // Private member variable to store the number of laps swum
    private int _laps;

    // Constructor to initialize the swimming activity
    public Swimming(int minutes, int laps) : base(minutes)
    {
        _laps = laps;
    }

    public override double GetDistance()
    {
        return (_laps * 50 / 1000.0); // Calculate distance
    }
}