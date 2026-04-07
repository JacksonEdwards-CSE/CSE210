
using System.Diagnostics.Tracing;

class Reception : Event
{
    private string _email;
    private string _eventType = "Reception";

    public Reception(string email, string title, string description, string date, string time, string address)
    : base(title, description, date, time, address)
    {
        _email = email;
    }

    public override void DisplayFullDetails()
    {
        base.DisplayFullDetails();
        Console.WriteLine($"RSVP @ {_email}");
    }

    public override void DisplayShortDescription()
    {
        Console.Write($"{_eventType}: ");
        base.DisplayShortDescription();
    }
}