using System;

class ListingActivity : Activity
{
    private void RandomQuestion()
    {
        List<string> question = new List<string>
        {
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?"
        };

        Random random = new Random();
        int index = random.Next(question.Count);

        Console.WriteLine("List as many responses you can to the following prompt:");

        Console.WriteLine($" --- {question[index]} ---");

        Console.Write("You may begin in:  ");

        for (int i = 5; i > 0; i--) 
        {
            Console.Write("\b" + i);
            Thread.Sleep(1000); 
        }
        Console.WriteLine("\b \b");
    }
    public void WelcomeListingActivity()
    {
        Console.Clear();
        Console.WriteLine(GetInitialMessage() + "Reflection Activity!");
        Console.WriteLine();
        Console.WriteLine(GetDescriptionActivity()[2]);
        Console.WriteLine();
        Console.Write(GetAskDurationOfTheActivity());
    }

    public void StartListingActivity()
    {
        string duration = Console.ReadLine();
        int durationTime = int.Parse(duration);

        DateTime startTIme = DateTime.Now;
        DateTime endTime = startTIme.AddSeconds(durationTime);

        PreparationAnimation();

        RandomQuestion();

        
        int i = -1;
        while (DateTime.Now < endTime) {
            i += 1;
            Console.Write("> ");
            Console.ReadLine();
        }

        Console.WriteLine($"You listed {i} items!");

        Console.WriteLine();    

        FinalMessage(durationTime, "Listing Activity");
    }
}