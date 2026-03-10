using System;
using System.Runtime.ExceptionServices;
using System.Security.Cryptography;

class Program
{
    static void Main(string[] args)
    {
        Fraction newFraction = new Fraction();

        string defaultFraction = newFraction.GetFractionString();
        Console.WriteLine(defaultFraction);

        double defaultDecimal = newFraction.GetDecimalValue();
        Console.WriteLine(defaultDecimal);

        Fraction secondFraction = new Fraction(5);

        string wholeFraction = secondFraction.GetFractionString();
        Console.WriteLine(wholeFraction);

        double wholeDecimal = secondFraction.GetDecimalValue();
        Console.WriteLine(wholeDecimal);

        secondFraction.SetTop(3);
        secondFraction.SetBottom(4);

        wholeFraction = secondFraction.GetFractionString();
        Console.WriteLine(wholeFraction);

        wholeDecimal = secondFraction.GetDecimalValue();
        Console.WriteLine($"{wholeDecimal}");

        secondFraction.SetTop(1);
        secondFraction.SetBottom(3);

        wholeFraction = secondFraction.GetFractionString();
        Console.WriteLine(wholeFraction);

        wholeDecimal = secondFraction.GetDecimalValue();
        Console.WriteLine($"{wholeDecimal}");

        Fraction loopFraction = new Fraction();

        Random random = new Random();


        for (int i = 0; i < 20; i++)
        {
            int randomNumber = random.Next(101);

            loopFraction.SetTop(randomNumber);

            randomNumber = random.Next(101);

            loopFraction.SetBottom(randomNumber);

            string loopFractionString = loopFraction.GetFractionString();
            double loopDecimalValue = loopFraction.GetDecimalValue();

            Console.WriteLine($"Fraction {i + 1}: {loopFractionString} | Decimal Value: {loopDecimalValue:F5}");
            Console.WriteLine();
        }

    }
}