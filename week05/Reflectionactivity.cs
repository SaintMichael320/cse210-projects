using System;
using System.Collections.Generic;

// Reflection Activity - guides user through reflection on past experiences
public class ReflectionActivity : Activity
{
    // List of prompts for reflection
    private List<string> _prompts;
    
    // List of questions to ask about the experience
    private List<string> _questions;

    // Constructor
    public ReflectionActivity() 
        : base("Reflection Activity", 
               "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.")
    {
        // Initialize prompts
        _prompts = new List<string>
        {
            "Think of a time when you stood up for someone else.",
            "Think of a time when you did something really difficult.",
            "Think of a time when you helped someone in need.",
            "Think of a time when you did something truly selfless."
        };

        // Initialize questions
        _questions = new List<string>
        {
            "Why was this experience meaningful to you?",
            "Have you ever done anything like this before?",
            "How did you get started?",
            "How did you feel when it was complete?",
            "What made this time different than other times when you were not as successful?",
            "What is your favorite thing about this experience?",
            "What could you learn from this experience that applies to other situations?",
            "What did you learn about yourself through this experience?",
            "How can you keep this experience in mind in the future?"
        };
    }

    // Get a random prompt
    public string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        return _prompts[index];
    }

    // Get a random question
    public string GetRandomQuestion()
    {
        Random random = new Random();
        int index = random.Next(_questions.Count);
        return _questions[index];
    }

    // Run the reflection activity
    public override void Run()
    {
        DisplayStartingMessage();

        Console.WriteLine("Consider the following prompt:");
        Console.WriteLine();
        Console.WriteLine($" --- {GetRandomPrompt()} ---");
        Console.WriteLine();
        Console.WriteLine("When you have something in mind, press enter to continue.");
        Console.ReadLine();

        Console.WriteLine("Now ponder on each of the following questions as they related to this experience.");
        Console.Write("You may begin in: ");
        ShowCountDown(5);

        Console.Clear();

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);

        // Display random questions until duration is reached
        while (DateTime.Now < endTime)
        {
            Console.Write($"> {GetRandomQuestion()} ");
            ShowSpinner(10);
            Console.WriteLine();
        }

        DisplayEndingMessage();
    }
}