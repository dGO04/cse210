using System;
using System.Diagnostics;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> _activities = new List<Activity>();

        DateTime currentDate = DateTime.Now;
        string formatedDate = currentDate.ToString("dd MMM yyyy");

        RunningActivity running = new RunningActivity(name:"Running", date:formatedDate, activityLength:45, distance:12.7);
        CyclingActivity cycling = new CyclingActivity(name:"Cycling", date:formatedDate, activityLength:75, speed:20);
        SwimmingActivity swimming = new SwimmingActivity(name:"Swimming", date:formatedDate, activityLength:25, numberOfLaps:10);
        _activities.Add(running);
        _activities.Add(cycling);
        _activities.Add(swimming);

        foreach(Activity activity in _activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}


