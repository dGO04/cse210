using System;

public class ChecklistGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;
    public ChecklistGoal(string shortName, string description, int points, int target, int bonus) : base(shortName:shortName, description:description, points:points)
    {
        _amountCompleted = 0;
        _target = target;
        _bonus = bonus;
    }

    //This constructor is for when we populate the list of goals with a file that already has an amountCompleted value
    public ChecklistGoal(string shortName, string description, int points, int target, int bonus, int amountCompleted) : base(shortName:shortName, description:description, points:points)
    {
        _amountCompleted = amountCompleted;
        _target = target;
        _bonus = bonus;
    }

    public override int RecordEvent()
    {
        Console.WriteLine($"Comgratulations!! You have earned {_points} points");
        
        if(IsComplete())
        {
            Console.WriteLine($"Comgratulations!! You have earned {_bonus} bonus points");
            return _points + _bonus; 
            
        } else
        {
            _amountCompleted += 1;
            return _points;
        }
         
    }

    public override bool IsComplete()
    {
        if (_amountCompleted == _target)
        {
            return true;
        } else
        {
            return false;
        }
    }

    public override string GetDetailsString()
    {
        if (IsComplete())
        {
            return $"[X] {base._shortName} ({base._description}) -- Currently completed: {_amountCompleted}/{_target}";
        } else
        {
            return $"[ ] {base._shortName} ({base._description}) -- Currently completed: {_amountCompleted}/{_target}";
        }
    }

    public override string GetStringRepresentation()
    {
        return $"Checklist Goal: {_shortName}|{_description}|{_points}|{_bonus}|{_target}|{_amountCompleted}";
    }
}