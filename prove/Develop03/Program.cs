using System;

class Program
{
    static void Main(string[] args)
    {
        //Test Reference class
        // Reference reference = new Reference("Proverbs", 3, 5, 6);
        // reference.Display();

        //Test Word class
        // Word word = new Word("Lemon");
        // // word.SetVisibleWord("Lemon");
        // word.WriteWord();
        // // word.SetHiddenWord("_");
        // word.HideWord();
        // word.WriteWord();
        //Test Scripture class
        Scripture scripture = new Scripture();
        string userChoice = "";
        while (userChoice != "quit")
        {
            scripture.Display();
            Console.WriteLine();
            Console.WriteLine("\nPress enter to continue or type 'quit' to finish:");
            if (userChoice != "quit")
            {
                userChoice = Console.ReadLine();
                Console.Clear();
                scripture.HideRandomText();
            }
        }
    }

}