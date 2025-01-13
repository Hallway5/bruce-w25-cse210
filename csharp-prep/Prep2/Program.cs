using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep2 World!");

        Console.Write("What is your grade percentage? ");
        string gradeInput = Console.ReadLine();
        int gradePercent = int.Parse(gradeInput);
        string gradeLetter;

        if (gradePercent >= 93)
        {
            gradeLetter = "A";
        }
        else if (gradePercent >= 90)
        {
            gradeLetter = "A-";
        }
        else if (gradePercent >= 87)
        {
            gradeLetter = "B+";
        }
        else if (gradePercent >= 83)
        {
            gradeLetter = "B";
        }
        else if (gradePercent >= 80)
        {
            gradeLetter = "B-";
        }
        else if (gradePercent >= 77)
        {
            gradeLetter = "C+";
        }
        else if (gradePercent >= 73)
        {
            gradeLetter = "C";
        }
        else if (gradePercent >= 70)
        {
            gradeLetter = "C-";
        }
        else if (gradePercent >= 67)
        {
            gradeLetter = "D+";
        }
        else if (gradePercent >= 60)
        {
            gradeLetter = "D";
        }
        else
        {
            gradeLetter = "F";
        }

        Console.WriteLine($"Lettter Grade: {gradeLetter}");

        if (gradePercent >= 70)
        {
            Console.WriteLine("Congratuations, you passed.");
        }
        else
        {
            Console.WriteLine("Sorry, you failed. Better luck next time.");
        }
    }
}