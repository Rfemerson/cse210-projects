using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Menu Options:");
        Console.WriteLine("  1. Start Breathing Activity");
        Console.WriteLine("  2. Start Reflection Activity");
        Console.WriteLine("  3. Start Listing Activity");
        Console.WriteLine("  4. Quit");
        Console.Write("Select a choice from the menu: ");
        string activityChoice = Console.ReadLine();

        int numberChoice = int.Parse(activityChoice);

        if (numberChoice == 1) { // Breathing Activity
            BreathingActivity breathingActivity = new BreathingActivity();
            breathingActivity.WelcomeBrathingActivity();
            breathingActivity.StartBreathingActivity();
        }

        else if (numberChoice == 2) { //Reflection Activity

        }

        else if (numberChoice == 3) { // Listing Activity

        }
    
        else if (numberChoice == 4) { // Quit 
            
        }
        
        else { // Please start again

        }
    }
}