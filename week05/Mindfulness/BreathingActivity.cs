public class BreathingActivity : Activity
{

    public BreathingActivity(string activityDescription, string activityName = "Breathing") : base(activityName:activityName, activityDescription:activityDescription)
    {
        
    }

    public void Breathing()
    {
        int breathingDuration = _activityDuration / 3;

        BreathingAnimation("Breath in");

        for(int i = 1; i < 4; i++)
        {
            Console.WriteLine("\nBreath in...");
            Thread.Sleep((breathingDuration / 2) * 1000);
            Console.WriteLine("Breath out...");
            Thread.Sleep((breathingDuration / 2) * 1000);
        }
    }

    public void BreathingAnimation(string prompt)
    {
        Console.Write($"{prompt}...");

        for(int i = 4; i >= 1; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }
}