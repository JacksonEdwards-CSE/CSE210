using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment myAssignment = new Assignment("Jackson Edwards", "CSE210");

        Console.WriteLine(myAssignment.GetSummary());

        MathAssignment mathAssignment = new MathAssignment("5.3", "1-10", "Jackson Edwards", "CSE210");

        Console.WriteLine(mathAssignment.GetHomeworkList());

        WritingAssignment writeAssignment = new WritingAssignment("Creating Classes", "Jackson Edwards", "CSE210");

        Console.WriteLine(writeAssignment.GetWritingInformation());
    }
}