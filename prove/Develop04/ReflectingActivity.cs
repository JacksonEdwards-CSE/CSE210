
class ReflectingActivity : Activity
{

    private List<string> _firstPrompts;
    private List<string> _secondPrompts;
    
    public ReflectingActivity(List<string> firstPrompts, List<string> secondPrompts, string name, string description)
    : base(name, description)
    {
        _firstPrompts = firstPrompts;

        _secondPrompts = secondPrompts;
    }

    public void RunReflectingActivity()
    {
        Console.Clear();
        DisplayGreeting();
        DisplayDescription();

        SetSeconds();
        int seconds = GetSeconds();

        Console.Clear();

        DisplayLoading("Get Ready...",3, "-\\|/", 100);

        string firstPrompt = GetPrompt(_firstPrompts);

        Console.WriteLine("Ponder the following prompt: ");

        Console.WriteLine($"     -----{firstPrompt}-----\n");

        Console.Write("When you have thought of an experience, press enter.");
        Console.ReadLine();

        DisplayLoading("You will begin in ", 3, "321", 1000);

        Console.Clear();

        DateTime endTime = DateTime.Now.AddSeconds(seconds);

        while (DateTime.Now < endTime)
        {
            
            string secondPrompt = GetPrompt(_secondPrompts);

            Console.WriteLine(secondPrompt);

            Console.Write("> ");
            Console.ReadLine();
            Console.WriteLine();
        }

        DisplayLoading("Well Done! ",3, "-\\|/", 100);
        DisplayLoading($"You Have Completed {GetSeconds()} seconds of the {GetName()} ",3, "-\\|/", 100);
    }
}