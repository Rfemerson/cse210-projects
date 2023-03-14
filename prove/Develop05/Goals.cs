using System;

public abstract class Goals
{
    protected List<int> _goalTypes = new List<int>();
    protected List<string> _goalTitles;
    protected List<string> _goalDescs;
    protected List<int> _goalPoints;
    protected List<int> _goalExtraPoints;
    protected List<int> _goalNumberOfChecks;
    protected List<bool> _goalDones;

    public void AddGoal(int goalType, string goalTitle, string goalDesc, int points, int goalExtraPoints, int goalNumberOfChecks)
    {
        var done = false;
        _goalTypes.Add(goalType);
        _goalTitles.Add(goalTitle);
        _goalDescs.Add(goalDesc);
        _goalPoints.Add(points);
        _goalExtraPoints.Add(goalExtraPoints);
        _goalNumberOfChecks.Add(goalNumberOfChecks);
        _goalDones.Add(done);
    }
    public abstract void ListGoals();
    //public void CreateFile(string fileName)
    //{
    //    StreamWriter outputFile = new StreamWriter(fileName);
    //}
    public void SaveGoalsInFile(string fileName)
    {
        using (StreamWriter outputFile = File.AppendText(fileName))
        {
            for (int i = 0; i < _goalTitles.Count; i++)
            {
                if (_goalTypes[i] == 1)
                {
                    outputFile.WriteLine($"Simple Goal: {_goalTitles[i]}, {_goalDescs[i]}, {_goalPoints[i]}, {_goalDones[i]}");
                }
                else if (_goalTypes[i] == 2)
                {

                    outputFile.WriteLine($"Eternal Goal: {_goalTitles[i]}, {_goalDescs[i]}, {_goalPoints[i]}");
                }
                else if (_goalTypes[i] == 3)
                {

                    outputFile.WriteLine($"Checklist Goal: {_goalTitles[i]}, {_goalDescs[i]}, {_goalPoints[i]}, {_goalExtraPoints[i]}, {_goalNumberOfChecks[i]}, {_goalDones[i]}");
                }


            }
        }

    }

    public void LoadSavedGoalsInFile(string fileName)
    {
        string[] lines = System.IO.File.ReadAllLines(fileName);
        foreach (string line in lines)
        {
            string[] parts = line.Split(",");
            string first = parts[0];
            Console.WriteLine(first);
        }
    }
    abstract public void EndGoal(int idGoal);
    
}