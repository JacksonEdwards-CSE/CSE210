using System;

class Program
{
    static void Main(string[] args)
    {
        Circle myCircle = new Circle();

        myCircle.SetRadius(10);

        Console.WriteLine(myCircle.GetRadius());
        Console.WriteLine(myCircle.GetCircumfrence());
        Console.WriteLine(myCircle.GetArea());
        Console.WriteLine(myCircle.GetDiameter());
    }
}