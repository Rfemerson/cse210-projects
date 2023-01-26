using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Journal Program ");

        while (true)
        {
            Display newDisplay = new Display();
            newDisplay.Menuoptions();

            int choice = int.Parse(Console.ReadLine());
            // Write
            if (choice == 1)
            {

            }
            // Display
            else if (choice == 2)
            {

            }
            // load
            else if (choice == 3)
            {

            }
            // Save
            else if (choice == 4)
            {

            }
            // Quit
            else if (choice == 5)
            {
                break;
            }
        }
    }
}