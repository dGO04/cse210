using System;

public class SimpleGoal : Goal
{
    private bool _isComplete;
    public SimpleGoal(string shortName, string description, int points) : base(shortName:shortName, description:description, points:points)
    {
        _isComplete = false;
    }

    //This constructor is for when we populate the list of goals with a file that already has a isComplete value
    public SimpleGoal(string shortName, string description, int points, bool isComplete) : base(shortName:shortName, description:description, points:points)
    {
        _isComplete = isComplete;
    }

    public override int RecordEvent()
    {
        Console.WriteLine($"Comgratulations!! You have earned {_points} points");
        _isComplete = true;

        return _points;
    }

    public override bool IsComplete()
    {
        return _isComplete;
    }

    public override string GetStringRepresentation()
    {
        return $"Simple Goal: {_shortName}|{_description}|{_points}|{_isComplete}";
    }
}