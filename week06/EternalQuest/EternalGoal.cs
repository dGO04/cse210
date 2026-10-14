using System;

public class EternalGoal : Goal
{
    
    public EternalGoal(string shortName, string description, int points) : base(shortName:shortName, description:description, points:points)
    {
        
    }

    public override int RecordEvent()
    {
        Console.WriteLine($"Comgratulations!! You have earned {_points} points");
        
        return _points;
    }

    public override bool IsComplete()
    {
        return false;
    }

    public override string GetStringRepresentation()
    {
        return $"Eternal Goal: {_shortName}|{_description}|{_points}";
    }
}