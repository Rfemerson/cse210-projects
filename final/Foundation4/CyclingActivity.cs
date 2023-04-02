using System;

public class CyclingActivity : Activity
{
    protected double _speed;

    public CyclingActivity(DateTime startTime, int durationMinutes, double speed)
        : base(startTime, durationMinutes)
    {
        _speed = speed;
    }

    public override double GetSpeed()
    {
        return _speed;
    }

    public override double GetDistance()
    {
        TimeSpan duration = TimeSpan.FromMinutes(DurationMinutes);
        return duration.TotalHours * _speed;
    }

    public override TimeSpan GetPace()
    {
        double speed = GetSpeed();
        if (speed == 0)
        {
            return TimeSpan.MaxValue;
        }
        else
        {
            return TimeSpan.FromMinutes(60 / speed);
        }
    }

    public override string GetSummary()
    {
        return $"Type: Cycling, {base.GetSummary()}";
    }
}