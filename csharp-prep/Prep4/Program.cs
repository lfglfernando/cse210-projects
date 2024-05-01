using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {

        List<int> numbers = new List<int>();

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        while (true)
        {
            Console.Write("Enter a number: ");
            int numberAdded = int.Parse(Console.ReadLine());

            if (numberAdded == 0)
            {
                break;
            }

            numbers.Add(numberAdded);
        }

        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }

        Console.WriteLine($"The sum is: {sum}");
        double average = sum / (double)numbers.Count;
        Console.WriteLine($"The average is: {average}");

        int max = int.MinValue;

        foreach (int number in numbers)
        {
            if (number > max)
            {
                max = number; 
            }
        }
        Console.WriteLine($"The largest number is: {max}");


        
        

        // List<int> numbers = new List<int>();
        // List<string> words = new List<string>();
        
        // words.Add("phone");
        // words.Add("keyboard");
        // words.Add("mouse");

        // Console.WriteLine(words.Count);

        // foreach (string word in words)
        // {
        //     Console.WriteLine(word);
        // }

        // for (int i = 0; i < words.Count; i++)
        // {
        //     Console.WriteLine(words[i]);
        // }

// using System;
// using System.Collections.Generic;

// class Program
// {
//     static void Main(string[] args)
//     {
//         List<int> numbers = new List<int>();
//         Console.WriteLine("Enter a list of numbers, type 0 when finished.");

//         // Keep asking for numbers until the user enters 0
//         while (true)
//         {
//             Console.Write("Enter number: ");
//             int input = int.Parse(Console.ReadLine());

//             if (input == 0) // Stop collecting numbers when 0 is entered
//             {
//                 break;
//             }

//             numbers.Add(input); // Add the input to the list
//         }

//         // Compute the sum of the numbers in the list
//         int sum = 0;
//         foreach (int number in numbers)
//         {
//             sum += number;
//         }
//         Console.WriteLine($"The sum is: {sum}");

//         // Compute the average of the numbers in the list
//         double average = sum / (double)numbers.Count; // Cast to double for decimal division
//         Console.WriteLine($"The average is: {average}");

//         // Find the maximum number in the list
//         int max = int.MinValue; // Start with the smallest possible integer
//         foreach (int number in numbers)
//         {
//             if (number > max)
//             {
//                 max = number; // Update the max if a larger number is found
//             }
//         }
//         Console.WriteLine($"The largest number is: {max}");
//     }
// }

    }

}


