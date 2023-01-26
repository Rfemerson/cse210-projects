using System;


class JournalEntry
{
    public string question;
    public string answer;
    public DateTime date;

    public JournalEntry(string question, string answer)
    {
        this.question = question;
        this.answer = answer;
        this.date = DateTime.Now;
    }
}
