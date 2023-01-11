using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();

        Console.WriteLine("Welcome to the Guess My Number game!");

        Console.Write("What is the magic number? ");
        int number = randomGenerator.Next(1, 10);
        Console.WriteLine($"{number}");

        Console.Write("What is your guess? ");
        string valueFromUser = Console.ReadLine();
        int inputInNumber = int.Parse(valueFromUser);

        if (inputInNumber > number)
        {
            Console.WriteLine("Lower");
        }
        else if (inputInNumber < number)
        {
            Console.WriteLine("Higher");
        }
        else
        {
            Console.WriteLine("You guessed it!");
        }


    }
}