using System;

public class Cycling : Activity
{
    private double _distanceKm;
    public Cycling(int minutes, double distanceKm) : base(minutes)
    {
        _distanceKm = distanceKm;
    }

    public override double GetDistance()
    {
        return _distanceKm;
    }
}