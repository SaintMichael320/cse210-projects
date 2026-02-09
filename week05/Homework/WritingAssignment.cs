using System;

public class WritingAssignment : Assignment
{
    // Private member variable specific to WritingAssignment
    private string _title;

    // Constructor that accepts all three parameters
    public WritingAssignment(string studentName, string topic, string title)
        : base(studentName, topic)  // Call base class constructor
    {
        _title = title;
    }

    // Method to return writing information
    public string GetWritingInformation()
    {
        // Use the public GetStudentName() method from base class to access student name
        string studentName = GetStudentName();
        return $"{_title} by {studentName}";
    }
}