using System;

public abstract class Activity
{
    protected DateTime StartTime;
    protected int DurationMinutes;

    public Activity(DateTime startTime, int durationMinutes)
    {
        StartTime = startTime;
        DurationMinutes = durationMinutes;
    }

    public abstract double GetDistance();

    public abstract double GetSpeed();

    public abstract TimeSpan GetPace();

    public virtual string GetSummary()
    {
        return $"Start Time: {StartTime}, Duration: {DurationMinutes} min, Distance: {GetDistance()} km, Speed: {GetSpeed()} km/h, Pace: {GetPace()} min/km";
    }
}