using System;

public class Swimming : Activity
{
    private int _laps;
    public Swimming(int minutes, int laps) : base(minutes)
    {
        _laps = laps;
    }

    public override double GetDistance()
    {
        return (_laps * 50 / 1000.0);
    }
}