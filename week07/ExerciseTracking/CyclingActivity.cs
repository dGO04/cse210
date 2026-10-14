using System;

public class CyclingActivity : Activity
{
    private int _speed;

    public CyclingActivity(string date, int activityLength, int speed, string name) : base(date:date, activityLength:activityLength, name:name)
    {
        _speed = speed;
    }

    public override double GetDistance()
    {
        double distance = (GetSpeed() / 60) * base._activityLength;
        return distance;
    }

    public override double GetSpeed()
    {
        return _speed;
    }

    public override string GetPace()
    {
        double decimalPace = base._activityLength / GetDistance();
        string paceInMinutes = ConvertToMinutes(decimalPace);
        return paceInMinutes;
    }
}