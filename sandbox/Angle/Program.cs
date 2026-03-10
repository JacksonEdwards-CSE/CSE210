using System;

class Program
{
    public static void Main()
    {
        Console.Clear();

        Angle myAngle = new Angle(180);

        Console.WriteLine(myAngle.GetRadians());

        Console.WriteLine(myAngle.GetDegrees());
    }
}