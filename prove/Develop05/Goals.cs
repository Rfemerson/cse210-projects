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

    public string LoadSavedGoalsInFile(string fileName)
    {
        string[] lines = System.IO.File.ReadAllLines(fileName);
        foreach(string line in lines)
        {
            return line;
        }
        return"";  
    }

    public void DisplayListOfGoalInFile(string fileName)
     {
        string[] lines = System.IO.File.ReadAllLines(fileName);
        Console.WriteLine("The goals are: ");
            foreach (string line in lines)
            {
  
                string[] parts = line.Split(':');

                string goal = parts[0].Trim();
                string[] values = parts[1].Split(',');

                string goalName = values[0];
                string goalDesc = values[1];
                string goalPoints = values[2];

                Console.WriteLine($"[{" "}] {goalName} - {goalDesc} ({goalPoints} Points)");
            }
            Console.WriteLine();
    }
    
    public List<string> GetGoalTitle(string fileName)
    {
        string[] lines = File.ReadAllLines(fileName);

        List<string> goalTitle = new List<string>();

        foreach (string line in lines)
        {
            string[] parts = line.Split(':');

            string goal = parts[0].Trim();
            string[] values = parts[1].Split(',');

            goalTitle.Add(values[0].Trim());
        }
        return goalTitle;
    }

    public void RecordEvent(string fileName)
    {
        var count = 0;
        List<string> terms =  GetGoalTitle(fileName);

        foreach (string term in terms)
        {
            count += 1;
            Console.WriteLine($"{count}. {term}");
        }

        Console.WriteLine();
    }
    abstract public void EndGoal(int idGoal);
    
}