using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();
        string name = PromptUserName();
        int inputInNumber = PromptUserNumber();
        int squaredNumber = SquareNumber(inputInNumber);
        DisplayResult(name, squaredNumber);

        static void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the Program!");
        }

        static string PromptUserName()
        {
            Console.Write("Please enter your name: ");
            string name = Console.ReadLine();
            return name;
        }

        static int PromptUserNumber()
        {
            Console.Write("Please enter your favorite number: ");
            string userInput = Console.ReadLine();
            int inputInNumber = int.Parse(userInput);
            return inputInNumber;
        }

        static int SquareNumber(int inputInNumber)
        {
            int squaredNumber = inputInNumber * inputInNumber; 
            return squaredNumber;
        }

        static void DisplayResult(string name, int squaredNumber)
        {
            Console.Write($"{name}, the square of your number is {squaredNumber}");
        }

    }
}