using System;

class Program
{
    static void Main(string[] args)
    {
        Activity newActivity = new Activity("Breathing", "This activity will help you calm yourself with a series of breathing motions.");

        newActivity.DisplayGreeting();
        newActivity.DisplayDescription();

        newActivity.DisplaySpinner("Hello World!", 5);
    }
}