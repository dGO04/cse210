using System;

public abstract class Activity
{
    private string _date;
    private string _name;
    protected int _activityLength;

    public Activity(string date, int activityLength, string name)
    {
        _name = name;
        _date = date;
        _activityLength = activityLength;
    }

    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract string GetPace();
    public virtual string ConvertToMinutes(double minInDecimal)
    {
        string[] parts = minInDecimal.ToString().Split(".");
        double decimalPart = minInDecimal - int.Parse(parts[0]);
        string minutes = (decimalPart * 60).ToString("F0");

        if (minutes == "0")
        {
            return parts[0];
        } else
        {
            return $"{parts[0]}:{minutes}";
        }
    }
    public virtual string GetSummary()
    {
        return $"{_date} {_name} ({_activityLength}min): Distance: {GetDistance().ToString("F2")} km, Speed: {GetSpeed().ToString("F2")} kph, Pace: {GetPace()} min per km";
    }
}