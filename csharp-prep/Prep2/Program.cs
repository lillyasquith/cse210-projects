using System;

class Program
{
    static void Main(string[] args)
    {
        // Ask the user for their grade percentage, then print out the appropriate letter grade. 
        
        // Instead of printing the letter grade in the body of each if, elif, or else block, have a single print statement that prints the letter grade once.

        Console.Write("Please enter the grade percentage: ");
        string valueFromUser = Console.ReadLine();
        int percent = int.Parse(valueFromUser);
        
        string letter = "";

        if (percent >= 90)
        {
            letter = "A";   
        }
        else if (percent >= 80)
        {
            letter = "B"; 
        }
        else if (percent >= 70)
        {
            letter = "C"; 
        }
        else if (percent >= 60)
        {
            letter = "D"; 
        }
        else 
        {
            letter = "F"; 
        }

        Console.WriteLine($"Your letter grade is: {letter}");
                                                                                         
        // Add a separate if statement to determine if the user passed the course, and if so display a message to congratulate them. If not, display a different message to encourage them for next time.

        if (percent >= 70)
        {
            Console.WriteLine("Congratulations! You passed the course.");
        }
        else
        {
            Console.WriteLine("Try again, You got this.");
        }
    }
}