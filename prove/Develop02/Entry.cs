
using System.Runtime.InteropServices;

class Entry
{
    public string _dateTime;
    public string _prompt;
    public string _response;

    public void GetDate()
    {
        DateTime theCurrentTime = DateTime.Now;
        _dateTime = theCurrentTime.ToShortDateString();
    }

    public void GetPrompt()
    {

        List<string> prompts = new List<string> {"Who was the most interesting person you interacted with today?", 
        "What was the best part of your day?", "How did you see the Lord's hand in your life today?", 
        "What was the strongest emotion you felt today?", "If you had one thing you could do over today, what would it be?"};
        
        Random random = new Random();

        int randomIndex = random.Next(prompts.Count);

        _prompt = prompts[randomIndex];
    }

    public string Response()
    {
        Console.WriteLine($"{_dateTime} - {_prompt}");

        _response = Console.ReadLine();

        Console.WriteLine();
        
        return _response;
    }
}