using System;

class Program
{
    static void Main(string[] args)
    {
        int magicNumber;
        int guessNumber;

        Console.Write("What is your magic number? ");
        magicNumber = int.Parse(Console.ReadLine());

        do
        {
            Console.Write("What is your guess? ");
            guessNumber = int.Parse(Console.ReadLine());

            if (guessNumber > magicNumber)
            {
                Console.WriteLine("Lower");
            }

            else if (guessNumber < magicNumber)
            {
                Console.WriteLine("Higher");
            }

            else
            {
                Console.WriteLine($"You got it! The magic number is {magicNumber}.");
            }

        }while(guessNumber!= magicNumber);
    }
}