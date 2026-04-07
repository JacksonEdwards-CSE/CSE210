
class OutdoorGathering : Event
{
    private string _weather;
    private string _eventType = "Outdoor Gathering";

    public OutdoorGathering(string weather, string title, string description, string date, string time, string address)
    : base(title, description, date, time, address)
    {
        _weather = weather;
    }

    public override void DisplayFullDetails()
    {
        base.DisplayFullDetails();
        Console.WriteLine($"Weather Conditions: {_weather}");
    }

    public override void DisplayShortDescription()
    {
        Console.Write($"{_eventType}: ");
        base.DisplayShortDescription();
    }
}