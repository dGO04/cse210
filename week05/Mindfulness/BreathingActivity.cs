public class BreathingActivity : Activity
{

    public BreathingActivity(string activityDescription, string activityName = "Breathing") : base(activityName:activityName, activityDescription:activityDescription)
    {
        
    }

    public void Breathing()
    {
        int breathingDuration = _activityDuration / 3;

        BreathingCycle(durationSeconds:6000);

        for(int i = 1; i < 4; i++)
        {
            BreathingCycle(durationSeconds:breathingDuration*1000);
        }
    }

    private void BreathingCycle(int durationSeconds)
    {
        CountdownAnimation(prompt:"\nBreath in", durationSeconds:durationSeconds/2);
        CountdownAnimation(prompt:"Now breath out", durationSeconds:durationSeconds/2);
    }
}