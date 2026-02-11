using System;
using System.Collections.Generic;

// Listing Activity - guides user to list items in a category
public class ListingActivity : Activity
{
    // List of prompts for listing
    private List<string> _prompts;
    private int _count; // Number of items listed

    // Constructor
    public ListingActivity() 
        : base("Listing Activity", 
               "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.")
    {
        _count = 0;
        
        // Initialize prompts
        _prompts = new List<string>
        {
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?"
        };
    }

    // Get a random prompt
    public string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        return _prompts[index];
    }

    // Get list items from the user
    public List<string> GetListFromUser()
    {
        List<string> items = new List<string>();
        
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);

        // Keep accepting items until duration is reached
        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            string item = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(item))
            {
                items.Add(item);
            }
        }

        return items;
    }

    // Run the listing activity
    public override void Run()
    {
        DisplayStartingMessage();

        Console.WriteLine("List as many responses as you can to the following prompt:");
        Console.WriteLine($" --- {GetRandomPrompt()} ---");
        Console.Write("You may begin in: ");
        ShowCountDown(5);
        Console.WriteLine();

        List<string> items = GetListFromUser();
        _count = items.Count;

        Console.WriteLine($"You listed {_count} items!");

        DisplayEndingMessage();
    }
}