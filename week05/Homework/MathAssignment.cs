using System;

public class MathAssigment : Assignment
{
    private string _textbookSection;
    private string _problems;

    public MathAssigment() : base()
    {
        _textbookSection = "Unknown";
        _problems = "Unknown";
    }

    public MathAssigment(string studentName, string topic, string textbookSection, string problems) : base(studentName, topic)
    {
        _textbookSection = textbookSection;
        _problems = problems;
    }

    public string HomeworkList()
    {
        return $"Section {_textbookSection} Problems {_problems}";
    }
}