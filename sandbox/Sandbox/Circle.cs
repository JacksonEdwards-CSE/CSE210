
class Circle
{
    private double _radius;

    public Circle()
    {
        _radius = 0;
    }

    public Circle(double radius)
    {
        // _radius = radius;
        SetRadius(radius);
    }

    public double GetRadius()
    {
        return _radius;
    }

    public void SetRadius(double radius)
    {
        if(radius < 0)
        {
            Console.WriteLine("Please set radius to valid value.");
            _radius = 0;
            return;
        }
        _radius = radius;
    }

    public double GetArea()
    {
        return Math.PI * _radius * _radius;
    }

    public double GetDiameter()
    {
        return 2 * _radius;
    }

    public double GetCircumfrence()
    {
        return 2 * Math.PI * _radius;
    }
}