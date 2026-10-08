public class Activity
{
    protected string _acitivityName;
    protected string _activityDescription;
    protected int _activityDuration;

    public Activity()
    {
        _acitivityName = "Unknown";
        _activityDescription = "Empty";
    }

    public Activity(string activityName, string activityDescription)
    {
        _acitivityName = activityName;
        _activityDescription = activityDescription;
    }

    public void DisplayStartingMessage()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to The {_acitivityName} Activity.\n\n{_activityDescription}\n");
        SetActivityDuration();
        Console.Clear();
        GetLoadingMessage("Loading", durationSeconds:5000);
    }

    private void SetActivityDuration()
    {
        bool validAnswer;
        int activityDuration = 0;

        do
        {
            try {

                validAnswer = true;
                Console.Write($"How long, in seconds, would you like for your session? ");
                activityDuration = int.Parse(Console.ReadLine());    
            } catch (FormatException)
            {
                Console.WriteLine("Invalid Response. Try Again!!\n");
                validAnswer = false;
            }
            
        }while (validAnswer == false);

        _activityDuration = activityDuration;
    }

    protected void GetLoadingMessage(string prompt, int durationSeconds)
    {

        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(durationSeconds/1000);
        bool timeFinished = false;

        string[] characters = ["/", "|", @"\", "—"];
        Console.Write($"{prompt} ");
        
        while (timeFinished == false)
        {
            for(int i = 0; i < 10; i++)
            {
                foreach (string character in characters) 
                {

                    Console.Write($"{character}");
                    Thread.Sleep(100);
                    Console.Write("\b \b");
                }

                DateTime currentTime = DateTime.Now;

                if (currentTime >= futureTime)
                {
                    timeFinished = true;
                    break;
                }
            }
        }
        Console.WriteLine(); //New Line for good formating
    }

    protected void CountdownAnimation(string prompt, int durationSeconds)
    {
        Console.Write($"{prompt}...");

        for(int i = durationSeconds/1000; i >= 1; i--)
        {
            Console.Write(i);
            Thread.Sleep(durationSeconds/(durationSeconds/1000));
            if (i > 9)
            {
                Console.Write("\b\b  \b\b");
            } else
            {
                Console.Write("\b \b");   
            }
        }
        Console.WriteLine(); //New line for good formating
    }

    public void DisplayGoodbyeMessage()
    {
        GetLoadingMessage(prompt:"\nWell done!!", durationSeconds:5000);
        GetLoadingMessage(prompt:$"\nYou have completed another {_activityDuration} seconds of The {_acitivityName} Activity", durationSeconds:5000);
    }
}