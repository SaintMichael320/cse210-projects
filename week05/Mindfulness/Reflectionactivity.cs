using System;
using System.Collections.Generic;

// Reflection Activity - guides user through reflection on past experiences
public class ReflectionActivity : Activity
{
    // Master lists (never modified)
    private List<string> _prompts;
    private List<string> _questions;

    // Shuffled queue — questions are drawn without repeating until all are used
    private Queue<string> _questionQueue;

    // Constructor
    public ReflectionActivity()
        : base("Reflection Activity",
               "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.")
    {
        _prompts = new List<string>
        {
            "Think of a time when you stood up for someone else.",
            "Think of a time when you did something really difficult.",
            "Think of a time when you helped someone in need.",
            "Think of a time when you did something truly selfless."
        };

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

        _questionQueue = new Queue<string>();
    }

    // Returns a random prompt from the list
    public string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        return _prompts[index];
    }

    // Refills and shuffles the question queue from the master list
    private void RefillQuestionQueue()
    {
        // Copy the master list and shuffle it
        List<string> shuffled = new List<string>(_questions);
        Random random = new Random();

        for (int i = shuffled.Count - 1; i > 0; i--)
        {
            int j = random.Next(i + 1);
            string temp = shuffled[i];
            shuffled[i] = shuffled[j];
            shuffled[j] = temp;
        }

        foreach (string question in shuffled)
        {
            _questionQueue.Enqueue(question);
        }
    }

    // Returns the next question — no repeats until every question has been used once
    public string GetRandomQuestion()
    {
        if (_questionQueue.Count == 0)
        {
            RefillQuestionQueue();
        }

        return _questionQueue.Dequeue();
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

        Console.WriteLine("Now ponder on each of the following questions as they relate to this experience.");
        Console.Write("You may begin in: ");
        ShowCountDown(5);

        Console.Clear();

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);

        // Display questions (no repeats until all used) until duration is reached
        while (DateTime.Now < endTime)
        {
            Console.Write($"> {GetRandomQuestion()} ");
            ShowSpinner(10);
            Console.WriteLine();
        }

        DisplayEndingMessage();
    }
}