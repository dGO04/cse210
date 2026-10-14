using System;
using System.Diagnostics;

public class RunningActivity : Activity
{
    private double _distance;

    public RunningActivity(string date, int activityLength, string name, double distance) : base(date:date, activityLength:activityLength, name:name)
    {
        _distance = distance;
    }

    public override double GetDistance()
    {
        return _distance;
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