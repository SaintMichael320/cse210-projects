using System;
using System.Threading;

// Base class for all mindfulness activities
public class Activity
{
    // Protected member variables (accessible by derived classes)
    protected string _name;
    protected string _description;
    protected int _duration; // in seconds

    // Constructor
    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
        _duration = 0;
    }

    // Display the starting message common to all activities
    public void DisplayStartingMessage()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the {_name}.");
        Console.WriteLine();
        Console.WriteLine(_description);
        Console.WriteLine();
        Console.Write("How long, in seconds, would you like for your session? ");
        _duration = int.Parse(Console.ReadLine());
        
        Console.Clear();
        Console.WriteLine("Get ready...");
        ShowSpinner(3);
    }

    // Display the ending message common to all activities
    public void DisplayEndingMessage()
    {
        Console.WriteLine();
        Console.WriteLine("Well done!!");
        ShowSpinner(3);
        
        Console.WriteLine();
        Console.WriteLine($"You have completed another {_duration} seconds of the {_name}.");
        ShowSpinner(3);
    }

    // Show a spinner animation for a given number of seconds
    public void ShowSpinner(int seconds)
    {
        List<string> animationStrings = new List<string>();
        animationStrings.Add("|");
        animationStrings.Add("/");
        animationStrings.Add("-");
        animationStrings.Add("\\");
        animationStrings.Add("|");
        animationStrings.Add("/");
        animationStrings.Add("-");
        animationStrings.Add("\\");

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(seconds);

        int i = 0;

        while (DateTime.Now < endTime)
        {
            string s = animationStrings[i];
            Console.Write(s);
            Thread.Sleep(250);
            Console.Write("\b \b"); // Erase the character

            i++;

            if (i >= animationStrings.Count)
            {
                i = 0;
            }
        }
    }

    // Show a countdown animation
    public void ShowCountDown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b"); // Erase the number
        }
    }

    // Run method to be overridden by derived classes
    public virtual void Run()
    {
        DisplayStartingMessage();
        DisplayEndingMessage();
    }
}