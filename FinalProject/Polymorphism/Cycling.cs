
class Cycling : Activity
{
    private double _speed;

    public Cycling(double speed, string date, int minutes)
    : base(date, minutes)
    {
        _speed = speed;
    }

    public override double GetDistance()
    {
        return _speed * GetMinutes() / 60;
    }

    public override double GetPace()
    {
        return 60 / _speed;
    }

    public override void DisplaySummary()
    {
        Console.WriteLine($"{GetDate()} Cycling({GetMinutes()} minutes) - Distance: {GetDistance():N2} miles, Speed: {_speed:N2} mph, Pace: {GetPace():N2} min per mile");
    }
}