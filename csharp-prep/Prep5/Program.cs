using System;

class Program
{

    public static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Program!");
    }

    public static string GetName()
    {
        string name;

        Console.Write("Enter your name: ");
        name = Console.ReadLine();

        return name;
    }

    public static int GetFavoriteNumber()
    {
        int favoriteNumber;

        Console.Write("Enter your favorite number: ");
        favoriteNumber = int.Parse(Console.ReadLine());

        return favoriteNumber;
    }

    public static void GetBirthYear(out int birthYear)
    {
        Console.Write("Enter your birth year: ");
        birthYear = int.Parse(Console.ReadLine());
    }

    public static int SquareNumber(ref int number)
    {
        int squareNumber;

        squareNumber = number * number;

        return squareNumber;
    }

    public static void DisplayResult(ref string name, ref int birthYear, ref int favoriteNumber, ref int squareNumber)
    {

        Console.WriteLine($"{name}, you were born in {birthYear} and your favorite number is {favoriteNumber}. That number squared is {squareNumber}.");
        
    }
    static void Main(string[] args)
    {
        DisplayWelcome();

        string name = GetName();

        int favoriteNumber = GetFavoriteNumber();

        int birthYear;
        GetBirthYear( out birthYear);

        int squareNumber = SquareNumber(ref favoriteNumber);

        DisplayResult(ref name, ref birthYear, ref favoriteNumber, ref squareNumber);
    }
}