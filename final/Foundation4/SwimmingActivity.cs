using System;

public class SwimmingActivity : Activity
{
    protected int Laps;

    public SwimmingActivity(DateTime startTime, int durationMinutes, int laps)
        : base(startTime, durationMinutes)
    {
        Laps = laps;
    }

    public override double GetDistance()
    {
       return Laps * 50 / 1000.0; 
    }

    public override TimeSpan GetPace()
    {
        double metersPerLap = 50;

        double secondsPerMeter = DurationMinutes * 60.0 / GetDistance();

        int seconds = (int)Math.Round(secondsPerMeter * metersPerLap);

        return TimeSpan.FromSeconds(seconds);
    }

    public override double GetSpeed()
    {
        double metersPerMinute = GetDistance() / DurationMinutes;

        return metersPerMinute * 60 * 60 / 1000;
    }

    public override string GetSummary()
    {
        return $"Type: Swimming, Start Time: {StartTime}, Duration: {DurationMinutes} minutes, Laps: {Laps}, Distance: {GetDistance():N2} km, Speed: {GetSpeed():N2} km/h, Pace: {GetPace().ToString(@"mm\:ss")} per 25 meters";
    }
}   
