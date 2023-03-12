using System;

public abstract class Goals
{
    protected List<int> _goalTypes;
    protected List<string> _goalTitles;
    protected List<string> _goalDescs;
    protected List<int> _goalPoints;
    protected List<string> _goalExtraPoints;
    protected List<string> _goalNumberOfChecks;
    protected List<bool> _goalDones;
    
    abstract public void AddGoal(int goalType, string goalTitle, string goalDesc, int points,string goalExtraPoints = "0",
                                 string goalNumberOfChecks = "0",
                                 bool done = false);
    public void ListGoals()
    {
        for (int i = 0; i < _goalTitles.Count; i++)
        {
            if (_goalDones[i] == false && _goalTypes[i] != 2)
            {
                Console.WriteLine($"[ ] {_goalTitles[i]}");
            }
            else if (_goalDones[i]  == true && _goalTypes[i] != 2)
            {
                Console.WriteLine($"[X] {_goalTitles[i]}");
            }
            else if (_goalTypes[i] == 2)
            {
                Console.WriteLine($"{_goalTitles[i]}");
            }
            
        }
    }
    public void SaveGoalsInFile(string filename)
    {
        List<string> lines = new List<string>();
        for (int i = 0; i < _goalTitles.Count; i++)
        {
            if (_goalTypes[i] == 1)
            {
                lines.Add($"{_goalTitles[i]}, {_goalDescs[i]}, {_goalPoints[i]}, {_goalDones[i]}");
            }
            else if (_goalTypes[i] == 2)
            {
                
                lines.Add($"{_goalTitles[i]}, {_goalDescs[i]}, {_goalPoints[i]}");
            }
            else if (_goalTypes[i] == 3)
            {
                
                lines.Add($"{_goalTitles[i]}, {_goalDescs[i]}, {_goalPoints[i]}, {_goalExtraPoints[i]}, {_goalNumberOfChecks[i]}, {_goalDones[i]}");
            }
            

        }
        File.WriteAllLines(filename, lines);

    }

    public void LoadSavedGoalsInFile()
    {
        
    }
    abstract public void EndGoal(int idGoal);
}