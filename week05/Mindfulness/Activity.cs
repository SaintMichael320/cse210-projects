using System;
using System.Threading;

// Base class for all mindfulness activities
public class Activity
{
    // Private member variables - only _duration is protected because derived classes need it for their timer loops
    private string _name;
    private string _description;
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
        List<string> animationStrings = new List<string> { "|", "/", "-", "\\", "|", "/", "-", "\\" };

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

    // Show a countdown animation — correctly erases numbers of any digit length
    public void ShowCountDown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            string numStr = i.ToString();
            Console.Write(numStr);
            Thread.Sleep(1000);
            // Erase each character written (handles 1- and 2-digit numbers correctly)
            Console.Write(new string('\b', numStr.Length));
            Console.Write(new string(' ', numStr.Length));
            Console.Write(new string('\b', numStr.Length));
        }
    }

    // Run method to be overridden by derived classes
    public virtual void Run()
    {
        DisplayStartingMessage();
        DisplayEndingMessage();
    }
}