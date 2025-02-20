using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning04 World!");

        // Assignment assignment1 = new Assignment("Samuel Bennett", "Multiplication");
        // Console.WriteLine(assignment1.GetSummary());

        // MathAssignment mathAssignment2 = new MathAssignment("Roberto Rogriguez", "Fractions", "7.3", "8-19");
        // Console.WriteLine(mathAssignment2.GetSummary());
        // Console.WriteLine(mathAssignment2.GetHomeworkList());

        WritingAssignment writingAssignment3 = new WritingAssignment("Mary Waters", "European History", "The Causes of World War II");
        Console.WriteLine(writingAssignment3.GetSummary());
        Console.WriteLine(writingAssignment3.GetWritingInformation());
    }
}