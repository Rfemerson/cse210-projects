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
            ReflectionActivity reflectionActivity = new ReflectionActivity();
            reflectionActivity.WelcomeReflectionActivity();
            reflectionActivity.StartReflectionActivity();
        }

        else if (numberChoice == 3) { // Listing Activity
            ListingActivity listingActivity = new ListingActivity();
            listingActivity.WelcomeListingActivity();
            listingActivity.StartListingActivity();
        }
    
        else if (numberChoice == 4) { // Quit 
            Console.WriteLine("No problem, see you later!");
        }
        
        else { // Please start again
            Console.WriteLine("Please choose a number from 1 to 4");
        }
    }
}