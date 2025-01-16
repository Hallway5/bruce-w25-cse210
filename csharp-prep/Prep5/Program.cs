using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();
        string name = PromptUserName();
        int number = PromptUserNumber();
        int squaredNumber = SquareNumber(number);
        DisplayResult(name, squaredNumber);
    }

    static void DisplayWelcome(){
        Console.WriteLine("Welcome to the program!");
    }

    static string PromptUserName(){
        Console.Write("Please enter your name: ");
        string name = Console.ReadLine();
        return name;
    }

    static int PromptUserNumber(){
        Console.Write("Please enter your favorite number: ");
        string numberString = Console.ReadLine();
        int number = int.Parse(numberString);
        return number;
    }

    static int SquareNumber(int number){
        int squaredNumber = number * number;
        return squaredNumber;
    }

    static void DisplayResult(string name, int squaredNumber){
        Console.WriteLine($"Hello {name}, the square of your favorite number is {squaredNumber}.");
    }
}