using System;

public class Entry
{
    // Member variables
    private string _date;
    private string _promptText;
    private string _entryText;

    // Constructor
    public Entry(string date, string promptText, string entryText)
    {
        _date = date;
        _promptText = promptText;
        _entryText = entryText;
    }

    // Method to display this entry
    public void Display()
    {
        Console.WriteLine($"Date: {_date}");
        Console.WriteLine($"Prompt: {_promptText}");
        Console.WriteLine($"Entry: {_entryText}");
        Console.WriteLine("--------------------------");
    }

    // Optionally, getters and setters could be added if needed
}
