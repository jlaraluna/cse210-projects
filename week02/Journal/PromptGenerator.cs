using System;
using System.Collections.Generic;

public class PromptGenerator
{
    private List<string> _prompts = new List<string>
    {
        "Who stood out the most in my interactions today, and why?",
        "What was the highlight of my day?",
        "In what ways did I feel guided or blessed today?",
        "What emotion impacted me the most today, and what triggered it?",
        "If I could change one thing about today, what would it be and why?"
    };

    public string GetRandomPrompt()
    {
        Random rnd = new Random();
        int index = rnd.Next(_prompts.Count);
        return _prompts[index];
    }
}
