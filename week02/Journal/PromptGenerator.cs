using System;
using System.Collections.Generic;

public class PromptGenerator
{
    // Member variable
    private List<string> _prompts;

    // Constructor
    public PromptGenerator()
    {
        _prompts = new List<string>()
        {
            "What made you happy today?",
            "What did you learn today?",
            "Describe a challenge you faced today."
            // Add more prompts as desired
        };
    }

    // Method to get a random prompt
    public string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        return _prompts[index];
    }
}
