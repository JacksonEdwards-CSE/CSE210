
class Running : Activity
{
    private double _distance;

    public Running(int distance, string date, int minutes)
    : base(date, minutes)
    {
        _distance = distance;
    }

    public override double GetSpeed()
    {
        return _distance / GetMinutes() * 60;
    }

    public override double GetPace()
    {
        return GetMinutes() / _distance;
    }

    public override void DisplaySummary()
    {
        Console.WriteLine($"{GetDate()} Running({GetMinutes()} minutes) - Distance: {_distance:N2} miles, Speed: {GetSpeed():N2} mph, Pace: {GetPace():N2} min per mile");
    }
}