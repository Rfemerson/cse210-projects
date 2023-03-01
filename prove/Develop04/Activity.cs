using System;

class Activity
{
    private string _initialMessage = "Welcome to the ";

    private List<string> _descriptionActivity = new List<string> {
        "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.",
        "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.",
        "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area."
    };
    private string _askDurationOfTheActivity = "How long, in seconds, would you like for your session? ";

    private List<string> animationString =new List<string>() { "|", "/", "-", "\\", "|", "/", "-", "\\" };

    private int _durationActivity;

    private string _activityName;

    public string GetInitialMessage() 
    {
        string initialMessage = _initialMessage;
        return initialMessage;
    }
    public List<string> GetDescriptionActivity() 
    {
        List<string> descriptionActivity = _descriptionActivity;
        return descriptionActivity;
    }
    public string GetAskDurationOfTheActivity() 
    {
        string askDurationOfTheActivity = _askDurationOfTheActivity;
        return _askDurationOfTheActivity; 
    }

    // public int GetDuration(int gduration) 
    // {
        
    //     string duration = Console.ReadLine();
    //     int durationTime = int.Parse(duration);

    //     DateTime startTIme = DateTime.Now;
    //     DateTime endTime = startTIme.AddSeconds(durationTime);
    //     return gduration;
        
    // }

    // public string GetActivityName(string ActivityName) 
    // {
    //     _activityName = ActivityName;
    //     return ActivityName;
    // }
    
    public void PreparationAnimation()
    {
        Console.Clear();
        Console.WriteLine("Get ready...");

        DateTime startTIme = DateTime.Now;
        DateTime endTime = startTIme.AddSeconds(10);

        int i = 0;

        while(DateTime.Now < endTime)
        {
            string s = animationString[i];
            Console.Write(s);
            Thread.Sleep(1000);
            Console.Write("\b \b");

            i++;

            if (i >= animationString.Count)
            {
                i = 0;
            }
        }

        Console.WriteLine();
    }

    public void Animation() 
    {
        DateTime startTIme = DateTime.Now;
        DateTime endTime = startTIme.AddSeconds(10);

        int i = 0;

        while(DateTime.Now < endTime)
        {
            string s = animationString[i];
            Console.Write(s);
            Thread.Sleep(1000);
            Console.Write("\b \b");

            i++;

            if (i >= animationString.Count)
            {
                i = 0;
            }
        }
        Console.WriteLine();

    }

    public void FinalMessage(int duration, string activityName)
    {
        _durationActivity = duration;
        _activityName = activityName;
        Console.WriteLine("Well done!!");
        Animation();

        Console.WriteLine($"Your have completed {_durationActivity} seconds of the {activityName}");
        Animation();
    }
}