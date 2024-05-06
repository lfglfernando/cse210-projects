using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        Journal theJournal = new Journal();
        Entry anEntry = new Entry();
        anEntry.Display();


        int option = 0;

        while (option != 5)
        {
            Console.WriteLine("Please select one of the following choices:\n1. Write\n2. Display\n3. Load\n4. Save\n5. Quit\nWhat would you like to do?");
            option = int.Parse(Console.ReadLine());

            if (option == 1)
            {
                PromptGenerator promptGenerator = new PromptGenerator();
                string randomPrompt = promptGenerator.GetRandomPrompt();
                Console.WriteLine(randomPrompt);
                string response = Console.ReadLine();
                theJournal.AddEntry(new Entry { _promptText = randomPrompt, _entryText = response});
            }
            else if (option == 2)
            {
                theJournal.DisplayAll();
            }
            else if (option == 3)
            {
                Console.WriteLine("Enter the filename to load: ");
                string filename = Console.ReadLine();
                theJournal.LoadFromFile(filename);
            }
            else if (option == 4)
            {
                Console.WriteLine("Enter the filename to save: ");
                string filename = Console.ReadLine();
                theJournal.SaveToFile(filename);
            }
            else
            {
                Console.WriteLine("Good job for writing on your Journal! Keep doing it!");
            }
        }



    }
}