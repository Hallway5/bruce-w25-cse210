using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.Write("What is the magic number? ");
        // string magicNumberString = Console.ReadLine();
        // int magicNumber = int.Parse(magicNumberString);

        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 21);

        Console.Write("What is your guess? ");
        string guessString = Console.ReadLine();
        int guess = int.Parse(guessString);

        while (guess != magicNumber){
            if (guess < magicNumber){

                Console.WriteLine("Higher");
            } else if (guess > magicNumber){

                Console.WriteLine("Lower");
            }
            Console.Write("What is your guess? ");
            guessString = Console.ReadLine();
            guess = int.Parse(guessString);
        }
        Console.WriteLine("You guessed it!");
    }
}