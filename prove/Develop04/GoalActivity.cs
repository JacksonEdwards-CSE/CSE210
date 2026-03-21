
class GoalActivity : Activity
{
    
    public GoalActivity(string name, string description)
    : base(name, description){}

    public void RunGoalActivity()
    {
        Console.Clear();
        DisplayGreeting();
        DisplayDescription();

        Console.WriteLine("What is a goal that you want to achieve?");
        Console.Write("> ");
        Console.ReadLine();

        SetSeconds();
        int seconds = GetSeconds();

        Console.Clear();

        Console.WriteLine($"Try to think of as many steps as you can to complete your goal in {GetSeconds()} seconds.");

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