using System;

public class Assignment
{
    // Private member variables
    private string _studentName;
    private string _topic;

    // Constructor that receives student name and topic
    public Assignment(string studentName, string topic)
    {
        _studentName = studentName;
        _topic = topic;
    }

    // Public getter method for student name (needed by derived classes)
    public string GetStudentName()
    {
        return _studentName;
    }

    // Method to return summary
    public string GetSummary()
    {
        return $"{_studentName} - {_topic}";
    }
}