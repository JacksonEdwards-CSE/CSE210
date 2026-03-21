
class Activity
{
    
    private string _name;

    private string _description;

    private int _duration;

    private DateTime _endtime;

    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
        _duration = 0;
        _endtime = DateTime.Now;
    }

    public void DisplayGreeting()
    {
        Console.WriteLine($"Welcome to the {_name} Activity!");
    }

    public void DisplayDescription()
    {
        Console.WriteLine(_description);
    }

    public void SetSeconds()
    {
        Console.Write("How long would you like your session: ");
        _duration = int.Parse(Console.ReadLine());
    }

    public int GetSeconds()
    {
        return _duration;
    }

    public string GetName()
    {
        return _name;
    }

    public string GetPrompt(List<string> prompts)
    {
        Random random = new Random();

        int promptIndex = random.Next(prompts.Count);

        string prompt = prompts[promptIndex];
        
        return prompt;
    }

    public void DisplayLoading(string message, int seconds, string animatedString, int sleepTime)
    {
        DateTime currentTime = DateTime.Now;
        DateTime endTime = currentTime.AddSeconds(seconds);
        int index = 0;

        Console.CursorVisible = false;

        Console.Write($"{message} ");
        
        while(DateTime.Now < endTime)
        {
            Console.Write(animatedString[index++ % animatedString.Length]);
            Thread.Sleep(sleepTime);
            Console.Write("\b");
        }

        Console.Write("\b");

        Console.WriteLine();

        Console.CursorVisible = true;
    }
}