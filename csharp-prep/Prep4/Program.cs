using System;
using System.Collections.Generic;
class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        int userInput = -1;
        while (userInput != 0)
        {
            Console.Write("Enter number: ");

            string valueFromUser = Console.ReadLine();
            userInput = int.Parse(valueFromUser);

            if (userInput != 0)
            {
                numbers.Add(userInput);
            }
        }
        // 1.Compute the sum, or total, of the numbers in the list.
        int total = 0;
        foreach (int number in numbers)
        {
            total = numbers.Sum();
        }

        // 2.Compute the average of the numbers in the list.
        float count = numbers.Count;
        float average = (total) / count;

        // 3.Find the maximum, or largest, number in the list.
        int maxNumber = 0;
        maxNumber = numbers.Max();


        Console.WriteLine($"The sum is: {total}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest is: {maxNumber}");
    }
}