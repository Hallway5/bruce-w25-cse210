using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        List<int> numbers = new List<int>();

        Console.Write("Enter number: ");
        string numberString = Console.ReadLine();
        int number = int.Parse(numberString);
        numbers.Add(number);

        while (number != 0){

            Console.Write("Enter number: ");
            numberString = Console.ReadLine();
            number = int.Parse(numberString);

            if (number != 0){
                numbers.Add(number);
            }
        }

        int sum = 0;
        for (int i = 0; i < numbers.Count; i++){

            sum += numbers[i];
        }
        Console.WriteLine($"The sum is: {sum}");

        float average;
        average = ((float)sum) / numbers.Count;
        Console.WriteLine($"The average is: {average}");

        int largestNum = 0;
        for (int i = 0; i < numbers.Count; i++){

            if (numbers[i] > largestNum){

                largestNum = numbers[i];
            }
        }
        Console.WriteLine($"The largest number is: {largestNum}");
    }
}