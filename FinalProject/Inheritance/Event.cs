
using System.IO.Pipes;

class Event
{
    private string _title;
    private string _description;
    private string _date;
    private string _time;
    private string _address;

    public Event(string title, string description, string date, string time, string address)
    {
        _title = title;
        _description = description;
        _date = date;
        _time = time;
        _address = address;
    }

    public void DisplayStandardDetails()
    {
        Console.WriteLine($"{_title} - {_description}");
        Console.WriteLine($"{_date} @ {_time} - {_address}");
    }

    public virtual void DisplayFullDetails()
    {
        DisplayStandardDetails();
    }

    public virtual void DisplayShortDescription()
    {
        Console.WriteLine($"{_title} - {_date}");
    }
}