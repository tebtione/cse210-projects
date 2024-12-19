using System;

public class Running : Activity
{
    private double _distanceKm;
    public Running(int minutes, double distanceKm) : base(minutes)
    {
        _distanceKm = distanceKm;
    }

    public override double GetDistance()
    {
        return _distanceKm;
    }
}