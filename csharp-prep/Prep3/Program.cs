using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        Console.WriteLine("Welcome to the Guess My Number game!");

        Console.Write("What is the magic number? ");
        int magicNumber = randomGenerator.Next(1, 100);
        Console.WriteLine($"{magicNumber}");

        int input = 0;
        while (input != magicNumber)
        {
            Console.Write("What is your guess? ");
            string valueFromUser = Console.ReadLine();
            int valueInNumber = int.Parse(valueFromUser);

            if (valueInNumber > magicNumber)
            {
                Console.WriteLine("Lower");
            }
            else if (valueInNumber < magicNumber)
            {
                Console.WriteLine("Higher");
            }
            else
            {
                Console.WriteLine("You guessed it!");
            }

        }

    }
}