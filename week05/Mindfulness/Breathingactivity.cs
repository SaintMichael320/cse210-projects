using System;

// Breathing Activity - guides user through paced breathing
public class BreathingActivity : Activity
{
    // Constructor
    public BreathingActivity() 
        : base("Breathing Activity", 
               "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.")
    {
    }

    // Run the breathing activity
    public override void Run()
    {
        DisplayStartingMessage();

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);

        // Alternate between breathing in and out until duration is reached
        while (DateTime.Now < endTime)
        {
            Console.WriteLine();
            Console.Write("Breathe in...");
            ShowCountDown(4);
            
            Console.WriteLine();
            Console.Write("Now breathe out...");
            ShowCountDown(6);
            Console.WriteLine();
        }

        DisplayEndingMessage();
    }
}