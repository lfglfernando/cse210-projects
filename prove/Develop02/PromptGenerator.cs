using System;
using System.Collections.Generic;


public class PromptGenerator
{
    //this create the prompt list
    public List<string> _prompts = new List<string>
    {
        "What was the most interesting part of your day?",
        "When did you feel the spirit?",
        "What did you do for someone else during your day?",
        "What did you learn today?",
        "What are you grateful for today?"
    };

    public string GetRandomPrompt()
    {
        //CREATE A RANDOM CLASS
        Random randomGenerator = new Random();

        //Generate a random number to get a prompt
        int randomIndex = randomGenerator.Next(0, _prompts.Count);
        //get the random promt from the index
        string randomPrompt = _prompts[randomIndex];

        return randomPrompt;
    }
}