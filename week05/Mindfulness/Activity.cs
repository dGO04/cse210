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
        GetLoadingMessage("Loading");
    }

    private void SetActivityDuration()
    {
        bool validAnswer;
        int activityDuration = 0;

        do
        {
            try {

                validAnswer = true;
                Console.Write("How long, in seconds, would you like for your session? ");
                activityDuration = int.Parse(Console.ReadLine());    
            } catch (FormatException)
            {
                Console.WriteLine("Invalid Response. Try Again!!\n");
                validAnswer = false;
            }
            
            
        }while (validAnswer == false);

        _activityDuration = activityDuration;
    }

    public void GetLoadingMessage(string prompt)
    {
        string[] characters = ["/", "|", @"\", "—"];
        Console.Write($"{prompt} ");
        for(int i = 0; i < 15; i++)
        {
            foreach (string character in characters) 
            {
                
                Console.Write($"{character}");
                Thread.Sleep(100);
                Console.Write("\b \b");
            }
            
        }
        Console.WriteLine(); //New Line for good formating
    }

    public void DisplayGoodbyeMessage()
    {
        string goodbyeMsg = $"Well done!!\n\nYou have completed another {_activityDuration} seconds of The {_acitivityName} Activity";
        GetLoadingMessage(prompt:goodbyeMsg);
    }
}