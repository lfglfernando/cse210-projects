using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to Guess my number game!");

        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(-1, 101);

        int guess =-1;
        int attemps = 0;

        while (guess != magicNumber)
        {
            Console.Write("What is your guess? ");
            guess = int.Parse(Console.ReadLine());
            attemps ++;

            if (guess < magicNumber)
            {
                Console.WriteLine("Higher");
            }
            else if (guess > magicNumber)
            {
                Console.WriteLine("Lower");
            }
            else 
            {
                Console.WriteLine($"You guessed it! It took you {attemps} attemps.");
            }
        }
        // string response = ;
        

        // while (response == "yes")
        // {
        //     Console.Write("Do you want to continue? ");
        //     response = Console.ReadLine();
        // }

        // do
        // {
        //     Console.Write("Do you want to continue? ");
        //     response = Console.ReadLine();
        // } while (response == "yes");

        // for (int i = 0; i < 10; i++)
        // {
        //     Console.WriteLine(i);
        // }

        // foreach (string color in colors)
        // {
        //     Console.WriteLine(color);
        // }

    }
}