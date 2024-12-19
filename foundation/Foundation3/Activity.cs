using System;

public abstract class Activity
{
    protected int _minutes;
    public Activity(int minutes)
    {
        _minutes = minutes;
    }

    public abstract double GetDistance();
    public double GetSpeed()
    {
        double distance = GetDistance();
        return distance > 0 ? (distance / _minutes) * 60 : 0;
    }
    public double GetPace()
    {
        double distance = GetDistance();
        return distance > 0 ? _minutes / distance : 0;
    }

    public virtual string GetSummary()
    {
        double distance = GetDistance();
        double speed = GetSpeed();
        double pace = GetPace();
        return $"Distance: {distance:F2} km, Speed: {speed:F2} km/h, Pace: {pace:F2} min/km";
    }
}