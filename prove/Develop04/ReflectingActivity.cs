using System;
using System.Collections.Generic;
using System.Threading;

public class ReflectingActivity : Activity
{
    private List<string> _prompts = new List<string>
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };

    private List<string> _questions = new List<string>
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

    public ReflectingActivity()
    {
        _name = "Reflecting";
        _description = "\nWelcome to the Reflecting Activity.\n\nThis activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.\n\n";
    }

    public void Run()
    {
        DisplayStartingMessage();

        Random random = new Random();
        string prompt = _prompts[random.Next(_prompts.Count)];
        ShowSpinner(3);

        Console.WriteLine("Consider the following prompt:");
        Console.WriteLine($"\n---- {prompt} ----\n");
        Console.WriteLine("When you have something in mind, press enter to continue.");
        Console.ReadLine();

        Console.WriteLine("Now ponder on each of the following questions as they relate to this experience.");
        Console.WriteLine("\nYou might begin in:");
        ShowCountDown(4);

        int remainingTime = _duration;
        while (remainingTime > 0)
        {
            Console.Clear();
            string question = _questions[random.Next(_questions.Count)];
            Console.WriteLine($"> {question}");
            ShowSpinner(5);
            remainingTime -= 5;
        }

        DisplayEndingMessage();
    }
}
