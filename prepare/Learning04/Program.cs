using System;

class Program
{
    static void Main(string[] args)
    {
        //-----using constructor to display
        // Assignment assignment1 = new Assignment("Samuel Bennett", "Multiplication");
        // assignment1.Display1();

        // Assignment assignment2 = new Assignment("Roberto Rodriguez", "Fractions");
        // assignment2.Display1();
        // MathAssignment assignmentM = new MathAssignment("", "", "Section 7.3", "Problems 8-19");
        // assignmentM.Display2();

        Assignment assignment3 = new Assignment("Mary Waters", "European History");
        assignment3.Display1();
        WritingAssignment assignmentW = new WritingAssignment("", "", "The Causes of World War II");
        Console.WriteLine(assignmentW.GetWritingInformation());



        //-----using Getters and Setters to display
        // Assignment assignment = new Assignment();
        // assignment.SetName("Mary Waters");
        // assignment.SetTopic("European History");
        // Console.WriteLine(assignment.GetSummary());

        // MathAssignment assignment1 = new MathAssignment();
        // assignment1.SetTextbookSection("Section 7.3");
        // assignment1.SetProblems("Problems 8-19");
        // Console.WriteLine(assignment1.GetHomeworkList());


        //------using GetSumary function to display
        // Assignment assignment = new Assignment();
        // Console.WriteLine(assignment.GetSummary());

        // MathAssignment assignment1 = new MathAssignment();
        // Console.WriteLine(assignment1.GetHomeworkList());


    }
}