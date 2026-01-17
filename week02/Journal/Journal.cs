using System;
using System.Collections.Generic;
using System.IO;

public class Journal
{
    // Member variable
    private List<Entry> _entries;

    // Constructor
    public Journal()
    {
        _entries = new List<Entry>();
    }

    // Add a new entry to the journal
    public void AddEntry(Entry entry)
    {
        _entries.Add(entry);
    }

    // Display all entries
    public void DisplayAll()
    {
        foreach (Entry entry in _entries)
        {
            entry.Display();
        }
    }

    // Save entries to a file
    public void SaveToFile(string filename)
    {
        using (StreamWriter writer = new StreamWriter(filename))
        {
            foreach (Entry entry in _entries)
            {
                writer.WriteLine($"{entry}");
                // Optional: customize format for saving
            }
        }
    }

    // Load entries from a file
    public void LoadFromFile(string filename)
    {
        // Implementation stub for now
        // You will later read file, parse lines, and create Entry objects
    }
}
