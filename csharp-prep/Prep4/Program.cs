using System;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        int added_number;
        int totalNumber = 0;

        do
        {
            Console.Write("What number would you like to add? ");
            added_number = int.Parse(Console.ReadLine());

            numbers.Add(added_number);

        }while(added_number != 0);

        foreach (int number in numbers)
        {
            totalNumber = totalNumber + number;
        }

        double averageNumber = totalNumber / (numbers.Count - 1);

        Console.WriteLine($"The total is {totalNumber}");

        Console.WriteLine($"The average is {averageNumber}");

        Console.WriteLine($"The largest number is {numbers.Max()}");

    }
}