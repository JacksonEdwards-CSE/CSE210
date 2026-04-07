
class Swimming : Activity
{
    private int _laps;

    public Swimming(int laps, string date, int minutes)
    : base(date, minutes)
    {
        _laps = laps;
    }

    public override double GetDistance()
    {
        return _laps * 50 / 1000 *0.62;
    }

    public override double GetSpeed()
    {
        return GetDistance() / GetMinutes() * 60;
    }

    public override double GetPace()
    {
        return GetMinutes() / GetDistance();
    }

    public override void DisplaySummary()
    {
        Console.WriteLine($"{GetDate()} Swimming({GetMinutes()} minutes) - Distance: {GetDistance():N2} miles, Speed: {GetSpeed():N2} mph, Pace: {GetPace():N2} min per mile");
    }
}