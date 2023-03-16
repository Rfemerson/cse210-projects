using System;

public class EternalGoals : Goals
{
    public EternalGoals()
    {
        _goalTypes = new List<int>();
        _goalTitles = new List<string>();
        _goalDescs = new List<string>();
        _goalPoints = new List<int>();
        _goalExtraPoints = new List<int>();
        _goalNumberOfChecks = new List<int>();
        _goalDones = new List<bool>();
    }

    public override void EndGoal(int idGoal)
    {

    }

    public override void ListGoals()
    {
        for (int i = 0; i < _goalTitles?.Count; i++)
        {
            
            Console.WriteLine($"[ ] {_goalTitles[i]}: {_goalDescs[i]} ({_goalPoints[i]} points)");

        }
    }
}