using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter the reference of the scripture (e.g., John 3:16)");
        string referenceInput = Console.ReadLine();
        string[] referenceParts = referenceInput.Split(' ');
        string book = referenceParts[0];
        int chapter = int.Parse(referenceParts[1].Split(':')[0]);
        int verse = int.Parse(referenceParts[1].Split(':')[1].Split('-')[0]);
        int endVerse = verse;
        if (referenceParts[1].Contains('-'))
        {
            endVerse = int.Parse(referenceParts[1].Split(':')[1].Split('-')[1]);        
        }
        Reference reference = new Reference(book, chapter, verse, endVerse);

        Console.WriteLine("Enter the text of the scripture:");
        string scriptureText = Console.ReadLine();

        Scripture scripture = new Scripture(reference, scriptureText);

        while (true)
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            while (true)
            {
                Console.WriteLine("Press Enter to Continue or Type 'quit' to exit.");
                string input = Console.ReadLine().Trim();
                if (input.ToLower() == "quit")
                {
                    return;
                }
                else if (input == "")
                {
                    scripture.HideRandomWords(3);
                    Console.Clear();
                    Console.WriteLine(scripture.GetDisplayText());
                    if (scripture.IsCompletelyHidden())
                    {
                        return;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input. Press Enter to continue...");
                    Console.ReadLine();
                }

                
            }
        }

    }
}