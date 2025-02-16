using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning03 World!");

        Fraction fraction1 = new Fraction();
        Console.WriteLine(fraction1);

        //int wholeNumber = 5;
        //Fraction fraction2 = new Fraction(wholeNumber);
        //Console.WriteLine(fraction2);

        int top = 6;
        int bottom = 7;
        //Fraction fraction3 = new Fraction(top, bottom);
        //Console.WriteLine(fraction3);

        //Fraction fraction = new Fraction();
        //fraction.SetTop(1);
        //fraction.SetBottom(1);
        //Console.WriteLine(fraction.GetTop());
        //Console.WriteLine(fraction.GetBottom());

        Fraction fraction = new Fraction();
        Console.WriteLine(fraction.GetFractionString(top, bottom));
        Console.WriteLine(fraction.GetDecimalValue(top, bottom));
    }
}