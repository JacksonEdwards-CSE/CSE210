using System;
using System.Reflection.Metadata;
using System.Runtime.Serialization;

class Program
{
    static void Main(string[] args)
    {
        int grade;
        string letterGrade;
        string gradeSign;
        bool passClass;

        Console.Write("What is your grade percentage: ");
        grade = int.Parse(Console.ReadLine());

        if (grade >= 90)
        {
            letterGrade = "A";
            passClass = true;
        }

        else if (grade >= 80)
        {
            letterGrade = "B";
            passClass = true;
        }

        else if (grade >= 70)
        {
            letterGrade = "C";
            passClass = true;
        }

        else if (grade >= 60)
        {
            letterGrade = "D";
            passClass = false;
        }

        else if (grade < 60)
        {
            letterGrade = "F";
            passClass = false;
        }

        else
        {
            letterGrade = "";
            passClass = false;

            Console.WriteLine("This is not a valid grade.");
        }



        if (grade % 10 >= 7 && ( letterGrade != "A" || letterGrade != "F"))
        {
            gradeSign = "+";
        }

        else if (grade % 10 <= 3 && (grade != 100) && (letterGrade != "F"))
        {
            gradeSign = "-";
        }

        else
        {
            gradeSign = "";
        }



        Console.WriteLine($"Your letter grade is {letterGrade}{gradeSign}");



        if (passClass == true)
        {
            Console.WriteLine("You have passed the class.");
        }

        else
        {
            Console.WriteLine("You have not passed the class.");
        }

    }
}