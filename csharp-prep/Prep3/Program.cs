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

        int inputInNumber = 0;

        while (inputInNumber != magicNumber)
        {
            Console.Write("What is your guess? ");
            string valueFromUser = Console.ReadLine();
            inputInNumber = int.Parse(valueFromUser);

            if (inputInNumber > magicNumber)
            {
                Console.WriteLine("Lower");
            }
            else if (inputInNumber < magicNumber)
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