using System;

class Program
{
    static void Main(string[] args)
    {
        SimpleGoals simpleGoals = new SimpleGoals();
        EternalGoals eternalGoals = new EternalGoals();
        var totalPoints = 0;

        while (true)
        {
            

            Console.WriteLine($"You have {totalPoints} points");
            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Create New Goal");
            Console.WriteLine("  2. List Goals");
            Console.WriteLine("  3. Save Goals");
            Console.WriteLine("  4. Load Goals");
            Console.WriteLine("  5. Record Event");
            Console.WriteLine("  6. Quit");
            Console.WriteLine("Select a choice from the menu: ");
            string  option = Console.ReadLine();
            int menuoption = int.Parse(option);

            if (menuoption == 1) 
            {
                Console.WriteLine("The types of Goals are:\n 1. Simple Goal\n 2. Eternal Goal\n 3. Checklist Goal");
                
                Console.Write("Which type of goal would you like to create? ");
                string submenuOption = Console.ReadLine();
                int optionMenu = int.Parse(submenuOption);

                Console.Write("What is the name of your goal? ");
                string goalName = Console.ReadLine();

                Console.Write("\nWhat is a short description of it? ");
                string goalDescription = Console.ReadLine();

                Console.Write("\nWhat is the amount of points associated with this goal? ");
                string associatedPoints = Console.ReadLine();
                int numberAssociatePoints = int.Parse(associatedPoints);

                if (optionMenu == 1)
                {
                    simpleGoals.AddGoal(1, goalName, goalDescription, numberAssociatePoints);
                }

                else if (optionMenu == 2)
                {
                    eternalGoals.AddGoal(2, goalName, goalDescription, numberAssociatePoints);
                }

                else if (optionMenu == 3)
                {
                    Console.Write("\n Falta fazer ");
                }
            
            }

            else if (menuoption == 2) 
            {
                simpleGoals.ListGoals();
                eternalGoals.ListGoals();
                //checklistGoals.ListGoals();
            }
            
            else if (menuoption == 3) 
            {
                Console.WriteLine("What is filename for the goal file?");
                string filename = Console.ReadLine();
                simpleGoals.SaveGoalsInFile(filename);
                eternalGoals.SaveGoalsInFile(filename);
                
            }

            else if (menuoption == 4) 
            {

            }

            else if (menuoption == 5) 
            {

            }

            else if (menuoption == 6) 
            {
                break;
            }
        }
    }
}