
class BreathingActivity : Activity
{
    
    public BreathingActivity(string name, string description) 
    : base(name, description){}

    public void RunBreathingActivity()
    {
        Console.Clear();
        DisplayGreeting();
        DisplayDescription();

        SetSeconds();
        int seconds = GetSeconds();

        Console.Clear();

        DisplayLoading("Get Ready...",3, "-\\|/", 100);

        int iteration = 0;

        while (iteration < seconds / 10)
        {

            DisplayLoading("Breathe in...", 6, "654321", 1000);

            DisplayLoading("Breathe out...", 4, "4321", 1000);

            iteration++;
        }

        DisplayLoading("Well Done! ",3, "-\\|/", 100);
        DisplayLoading($"You Have Completed {GetSeconds()} seconds of the {GetName()} ",3, "-\\|/", 100);

    }
}