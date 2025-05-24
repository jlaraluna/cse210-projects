using System;

class Program
{
    static void Main(string[] args)
    {
        Reference reference = new Reference("Proverbs", 3, 5, 6);
        string verseText = "Trust in the Lord with all thine heart and lean not unto thine own understanding.";
        Scripture scripture = new Scripture(reference, verseText);

        while (true)
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine("\nPress Enter to hide more words or type 'quit' to finish:");
            string input = Console.ReadLine();

            if (input.ToLower() == "quit" || scripture.IsCompletelyHidden())
                break;

            scripture.HideRandomWords(3);
        }

        Console.WriteLine("Perfect! Program ended.");
    }
}
