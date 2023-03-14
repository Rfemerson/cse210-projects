using System;

public class ChecklistGoals : Goals
{
    public ChecklistGoals()
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
        _goalDones[idGoal] = true;
    }

    public override void ListGoals()
    {
        for (int i = 0; i < _goalTitles?.Count; i++)
        {
            if (_goalDones[i] == false)
            {
                Console.WriteLine($"[ ] {_goalTitles[i]}: {_goalDescs[i]} ({_goalPoints[i]} points)");
            }
            else if (_goalDones[i] == true)
            {
                Console.WriteLine($"[X] {_goalTitles[i]}: {_goalDescs[i]} ({_goalPoints[i]} points)");
            }

        }
    }
}