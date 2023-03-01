using System;

class ReflectionActivity : Activity
{
    private List<string> _ponderQuestions = new List<string>
        {
            "Why was this experience meaningful to you?",
            "Have you ever done anything like this before?",
            "How did you get started?",
            "How did you feel when it was complete?",
            "What made this time different than other times when you were not as successful?",
            "What is your favorite thing about this experience?",
            "What could you learn from this experience that applies to other situations?",
            "What did you learn about yourself through this experience?",
            "How can you keep this experience in mind in the future?"
        };
    private void RandomPrompts()
    {
        List<string> prompt = new List<string>
        {
            "Think of a time when you stood up for someone else.",
            "Think of a time when you did something really difficult.",
            "Think of a time when you helped someone in need.",
            "Think of a time when you did something truly selfless."
        };

        Random random = new Random();
        int index = random.Next(prompt.Count);

        Console.WriteLine("Consider the following prompt:");

        Console.WriteLine($"--- {prompt[index]} ---");

        Console.Write("When you have something in mind, press enter to continue. ");
    }

    private void PrepationMessage()
    {   
        Console.WriteLine("Now ponder on each of the following questions as they related to this experience");
        Console.Write("You may begin in:  ");

        for (int i = 5; i > 0; i--) 
        {
            Console.Write("\b" + i);
            Thread.Sleep(1000); 
        }
        Console.WriteLine("\b \b");
    }

    public void WelcomeReflectionActivity()
    {
        Console.Clear();
        Console.WriteLine(GetInitialMessage() + "Reflection Activity!");
        Console.WriteLine();
        Console.WriteLine(GetDescriptionActivity()[1]);
        Console.WriteLine();
        Console.Write(GetAskDurationOfTheActivity());
    }
    public void StartReflectionActivity()
    {
        List<string> ponderQuestions = _ponderQuestions;
        string duration = Console.ReadLine();
        int durationTime = int.Parse(duration);

        DateTime startTIme = DateTime.Now;
        DateTime endTime = startTIme.AddSeconds(durationTime);

        PreparationAnimation();

        RandomPrompts();
        string answer = Console.ReadLine();
        PrepationMessage();
        Console.Clear();

        int i = -1;
        while (DateTime.Now < endTime) {
            i += 1;
            Console.Write($"{ponderQuestions[i]} ");
            Animation();
        }
    }
}