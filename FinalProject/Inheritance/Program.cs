
class Program
{ 
    public static void Main(string[] args)
    {
        List<Event> events = new List<Event>();

        Lecture lecture = new Lecture("John Programming", 75, "How to be good at C#", "We will tell you how to use effective tools in your coding environments", 
        "4/7/2026", "12:30", "123 Lecture St");

        events.Add(lecture);

        Reception reception = new Reception("reception@gmail.com", "Fun Reception", "This is a fun reception", 
        "4/8/2026", "1:30", "456 Reception Rd");

        events.Add(reception);

        OutdoorGathering outdoorGathering = new OutdoorGathering("Sunny, SlightlyCloudy", "Frisbee Tournament", "A fun day of frisbees", 
        "4/9/2026", "2:30", "789 Outdoor Ave");

        events.Add(outdoorGathering);

        foreach (Event item in events)
        {
            Console.WriteLine(" - Standard Details - ");
            item.DisplayStandardDetails();
            Console.WriteLine();

            Console.WriteLine(" - Full Details - ");
            item.DisplayFullDetails();
            Console.WriteLine();

            Console.WriteLine(" - Short Description - ");
            item.DisplayShortDescription();
            Console.WriteLine();
        }
    }
}