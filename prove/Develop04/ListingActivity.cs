class ListingActivity : Activity
{

    List<string> _prompts;
    
    public ListingActivity(List<string> prompts, string name, string description)
    : base(name, description)
    {
        _prompts = prompts;
    }

    public void RunListingActivity()
    {
        Console.Clear();
        DisplayGreeting();
        DisplayDescription();

        SetSeconds();
        int seconds = GetSeconds();

        Console.Clear();

        DisplayLoading("Get Ready...",3, "-\\|/", 100);

        string prompt = GetPrompt(_prompts);

        Console.WriteLine("Consider the following prompt:");
        Console.WriteLine($"     -----{prompt}-----");
        DisplayLoading("You will begin in ", 3, "321", 1000);

        DateTime endTime = DateTime.Now.AddSeconds(seconds);

        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            Console.ReadLine();
        }

        DisplayLoading("Well Done! ",3, "-\\|/", 100);
        DisplayLoading($"You Have Completed {GetSeconds()} seconds of the {GetName()} ",3, "-\\|/", 100);
    }
}