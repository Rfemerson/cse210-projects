using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percent? ");
        string grade = Console.ReadLine();
        int gradeNamber = int.Parse(grade);

        string letter = "";

        if (gradeNamber >= 90)
        {
            letter = "A";
        }
        
        else if (gradeNamber >= 80)
        {
            letter = "B";
        }

        else if (gradeNamber >= 70)
        {
            letter = "c";
        }
        
        else if (gradeNamber >= 60)
        {
            letter = "D";
        }

        else 
        {
            letter = "F";
        }

        string sign = "";

        int last_digit = gradeNamber % 10;

        if (last_digit >= 7)
        {
            sign = "+";
        }

        else if (last_digit < 3)
        {
            sign = "-";
        }

        else
        {
            sign = "";
        }

        if (gradeNamber >= 93)
        {
            sign = "";
        }

        if (letter == "F")
        {
            sign = "";
        }

        Console.WriteLine($"Your letter grade is: {letter}{sign}");

        if (gradeNamber >= 70)
        {
            Console.WriteLine("Congratulations! You passed the class!");
        }

        else
        {
            Console.WriteLine("Stay focused and you'll get it next time!");
        }
    }
}