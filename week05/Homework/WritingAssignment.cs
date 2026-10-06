using System;

public class WritingAssignment : Assignment
{
    private string _assignmentTitle;
    
    public WritingAssignment() : base()
    {
        _assignmentTitle = "Unknown";
    }

    public WritingAssignment(string studentName, string topic, string assignmentTitle) : base(studentName, topic)
    {
        _assignmentTitle = assignmentTitle;
    }

    public string GetWritingInfo()
    {
        return $"{_assignmentTitle} by {_studentName}";
    }

}