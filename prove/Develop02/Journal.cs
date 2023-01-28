using System;

public class Journal
{

    static List<Entry> entries = new List<Entry>();
    static List<string> prompts = new List<string>() {"How did you feel today?", "What did you do today?",
    "What was the best thing that happened today?", "What was the worst thing that happened today?",
    "What did you learn today?"};

    public Journal()
    {
        entries = new List<Entry>();
    }

    public void AddEntry(string question, string answer, string name, string age)
    {
        Entry entry = new Entry(question, answer, name, age); 
        entries.Add(entry);
    }

    public void DisplayJournal()
    {
        foreach (Entry entry in entries)
        {
            Console.WriteLine($"Date: {entry.date} - Name: {entry.userName} - Age: {entry.ageUser} - Question: {entry.questionProgram} - Journal: {entry.answerUser}");
            // Console.WriteLine($"Question: {entry.questionProgram}");
            // Console.WriteLine($"Journal: {entry.answerUser}");
            Console.WriteLine();
        }
    }

    public void LoadFile(string filename)
    {
        entries = new List<Entry>();
        string[] lines = File.ReadAllLines(filename);
        for (int i = 0; i < lines.Length - 1; i += 4)
        {
            entries.Add(new Entry(lines[i], lines[i + 1], lines[i + 2], lines[i + 3]));
            Console.WriteLine(lines[i]);
            Console.WriteLine(lines[i + 1]);
            Console.WriteLine(lines[i + 2]);
            Console.WriteLine(lines[i + 3]);
            Console.WriteLine(lines[i + 4]);
            Console.WriteLine();
        }
    }

    public void SaveFile(string filename)
    {
        List<string> lines = new List<string>();
        foreach (Entry entry in entries)
        {
            lines.Add(entry.date.ToString());
            lines.Add(entry.userName);
            lines.Add(entry.ageUser);
            lines.Add(entry.questionProgram);
            lines.Add(entry.answerUser);
        }
        File.WriteAllLines(filename, lines);
    }

    public static string RandomPrompt()
    {
        Random rnd = new Random();
        int index = rnd.Next(prompts.Count);
        return prompts[index];
    }
}