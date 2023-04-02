using System;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>();

        RunningActivity running = new RunningActivity(DateTime.Parse("2023-03-20 10:00:00"), 60, 6.2);
        activities.Add(running);

        CyclingActivity cycling = new CyclingActivity(DateTime.Parse("2023-03-20 13:00:00"), 90, 20);
        activities.Add(cycling);

        SwimmingActivity swimming = new SwimmingActivity(DateTime.Parse("2023-03-20 17:00:00"), 45, 20);
        activities.Add(swimming);

        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
            Console.WriteLine();
        }
    }
}