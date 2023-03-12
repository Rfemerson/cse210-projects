using System;

public class EternalGoals : Goals
{
    public override void AddGoal(int goalType, string goalTitle, string goalDesc, string points, string goalExtraPoints = "0", string goalNumberOfChecks = "0", bool done = false)
    {
        
    }

    // override public void AddGoal(int goalType, string goalTitle, string goalDesc, string points)
    // {
    //     _goalTypes.Add(goalType);
    //     _goalTitles.Add($"EternalGoal: {goalTitle}");
    //     _goalDescs.Add(goalDesc);
    //     _goalPoints.Add(points);

    // }
    public override void EndGoal(int idGoal)
    {
        
    }
}