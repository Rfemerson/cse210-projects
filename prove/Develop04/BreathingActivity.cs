using System;

class BreathingActivity : Activity
{
    private string _breatheInMessage = "Breathe in... ";
    private string _breatheOutMessage = "Now breathe out... ";     

    private void Countdown()
    {
        for (int i = 4; i > 0; i--) 
        {
            Console.Write("\b \b" + i);
            Thread.Sleep(1000); 
        }
        Console.WriteLine("\b \b"); 
    }

    public string GetBreatheIn()
    {
        string breatheInMessage = _breatheInMessage;
        return breatheInMessage;
    }

    public string GetBreatheOut()
    {
        string breatheOutMessage = _breatheOutMessage;
        return breatheOutMessage;
    }

    public void WelcomeBrathingActivity()
    {
        Console.Clear();
        Console.WriteLine(GetInitialMessage() + "Breathing Activity!");
        Console.WriteLine();
        Console.WriteLine(GetDescriptionActivity()[0]);
        Console.WriteLine();
        Console.Write(GetAskDurationOfTheActivity());
    }

    public void StartBreathingActivity() 
    {
        string duration = Console.ReadLine();
        int durationTime = int.Parse(duration);

        DateTime startTIme = DateTime.Now;
        DateTime endTime = startTIme.AddSeconds(durationTime);

        PreparationAnimation();

        while(DateTime.Now < endTime)
        {
            Console.Write(GetBreatheIn());

            Countdown();
            
            Console.Write(GetBreatheOut());

            Countdown();   

            Console.WriteLine();     
        }

        FinalMessage(durationTime, "Breathing Activity");
    }
}