using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Journal Program ");
        int choice = 0;
        Journal newJournal = new Journal();
        while (choice != 5)
        {   
            Display newDisplay = new Display();
            newDisplay.Menuoptions();

            choice = int.Parse(Console.ReadLine());
            // Write
            if (choice == 1)
            {
                string question = Journal.RandomPrompt();
                Console.WriteLine("Prompt: " + question);
                string answer = Console.ReadLine();
                Console.WriteLine("What is your name?");
                string name = Console.ReadLine();
                Console.WriteLine("How old are you?");
                string age = Console.ReadLine();
                newJournal.AddEntry(question, answer, name, age);
                Console.WriteLine("Entry added successfully");      
                }
            // Display
            else if (choice == 2)
            {
                newJournal.DisplayJournal();
            }
            // load
            else if (choice == 3)
            {
                Console.WriteLine("Enter file name: ");
                string filename = Console.ReadLine();
                newJournal.LoadFile(filename);
                Console.WriteLine("Diary loaded successfully");                
            }
            // Save
            else if (choice == 4)
            {
                Console.WriteLine("Enter file name: ");
                string filename = Console.ReadLine();
                newJournal.SaveFile(filename);
                Console.WriteLine("Diary saved successfully");
            }
            // Quit
            else 
            {
                Console.WriteLine("Goodbye");
            }
        }
    }
}