using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage?: ");
        string gradePercentage = Console.ReadLine();

        int note = int.Parse(gradePercentage);
        string letter;

        if (note >= 90)
        {
            letter = "A";
        }
        else if (note >= 80)
        {
            letter = "B";
        }
        else if (note >= 70)
        {
            letter = "C";
        }
        else if (note >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        Console.WriteLine($"Your grade is a {letter}.");

        // Check if the course is passed or failed
        if (note >= 70)
        {
            Console.WriteLine("Great job! You passed the course.");
        }
        else
        {
            Console.WriteLine("You did not pass the course, try harder next time.");
        }
    }
}