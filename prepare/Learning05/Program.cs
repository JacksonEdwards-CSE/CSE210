using System;

class Program
{
    static void Main(string[] args)
    {

        List<Shape> shapeList = new List<Shape>();

        Circle circle = new Circle(15, "blue");
        Rectangle rectangle = new Rectangle(5, 10, "red");
        Square square = new Square(5, "green");

        shapeList.Add(circle);
        shapeList.Add(rectangle);
        shapeList.Add(square);

        foreach (Shape shape in shapeList)
        {
            Console.WriteLine(shape.GetColor());
            Console.WriteLine(shape.GetArea());
        }
    }
}