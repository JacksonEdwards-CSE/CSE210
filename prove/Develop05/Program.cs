using System;

class Program
{
    static void Main(string[] args)
    {
        SimpleGoal goal = new SimpleGoal("Basic Goal", "Test goal");

        Console.WriteLine(goal.GetName());
        Console.WriteLine(goal.GetDescription());
        goal.SetPoints();

        Console.WriteLine(goal.GetConsoleString());

        goal.RecordEvent();

        Console.WriteLine(goal.GetConsoleString());

        Menu menu = new Menu();
        Goals goals = new Goals();

        goals.DisplayTotalPoints();
        menu.ProcessMenu();
        menu.RunProgram();
    }
}