
class Lecture : Event
{
    private string _speaker;
    private int _capacity;

    public Lecture(string speaker, int capacity, string title, string description, string date, string time, string address)
    : base(title, description, date, time, address)
    {
        _speaker = speaker;
        _capacity = capacity;
    }

    private string _eventType = "Lecture";

    public override void DisplayFullDetails()
    {
        base.DisplayFullDetails();
        Console.WriteLine($"Speaker: {_speaker}  Capacity: {_capacity}");
    }

    public override void DisplayShortDescription()
    {
        Console.Write($"{_eventType}: ");
        base.DisplayShortDescription();
    }
}