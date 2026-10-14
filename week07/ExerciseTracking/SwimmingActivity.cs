using System;

public class SwimmingActivity : Activity
{
    private int _numberOfLaps;

    public SwimmingActivity(string date, int activityLength, int numberOfLaps, string name) : base(date:date, activityLength:activityLength, name:name)
    {
        _numberOfLaps = numberOfLaps;
    }

    public override double GetDistance()
    {
        double distance = (double)(_numberOfLaps * 50) / 1000;
        return distance;
    }

    public override double GetSpeed()
    {
        double speed = (GetDistance() / base._activityLength) * 60;
        return speed;
    }

    public override string GetPace()
    {
        double decimalPace = base._activityLength / GetDistance();
        string paceInMinutes = ConvertToMinutes(decimalPace);
        return paceInMinutes;
    }
}