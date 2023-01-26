using System;

public class Journal
{

    private List<Entry> entries;
    private static string[] prompts = {"How did you feel today?", "What did you do today?",
    "What was the best thing that happened today?", "What was the worst thing that happened today?",
    "What did you learn today?"};

    public void Diary()
    {
        entries = new List<Entry>();
    }

    public void AddEntry(string question, string answer)
    {
        entries.Add(new Entry(question, answer));
    }

    public static string RandomPrompt()
    {
        Random rnd = new Random();
        int index = rnd.Next(prompts.Length);
        return prompts[index];
    }


}