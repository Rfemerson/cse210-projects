using System;

public class Entry
{
    public string questionProgram;
    public string answerUser;
    public string userName;
    public string ageUser;
    public DateTime date;

    public Entry(string question, string answer, string name, string age)
    {
        userName = name;
        ageUser = age;
        questionProgram = question ;
        answerUser = answer;
        date = DateTime.Now;
    }
}