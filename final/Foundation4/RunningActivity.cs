using System;

public class RunningActivity : Activity
{
    protected double _distance;

    public RunningActivity(DateTime startTime, int durationMinutes, double distance)
        : base(startTime, durationMinutes)
    {
        _distance = distance;
    }

    public override double GetDistance()
    {
        return _distance;
    }

    public override double GetSpeed()
    {
        TimeSpan duration = TimeSpan.FromMinutes(DurationMinutes);
        return _distance / duration.TotalHours;
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
            return TimeSpan.FromMinutes(1 / speed);
        }
    }

    public override string GetSummary()
    {
        return $"Type: Running, {base.GetSummary()}";
    }
}