using System;
public class Assignment
{
    protected string _studentName;
    protected string _topic;

    public Assignment()
    {
        _studentName = "Anonymus";
        _studentName = "Unknown";
    }

    public Assignment(string studentName, string topic)
    {
        _studentName = studentName;
        _topic = topic;
    }

    public string GetSummary()
    {
        return $"{_studentName} - {_topic}";
    }
}