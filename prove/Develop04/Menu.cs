
class Menu
{
    private int _choice;

    public void ProcessMenu()
    {
        Console.WriteLine("Choose and activity to complete:\n1) Breathing Acitvity\n2) Listing Activity\n3) Reflecting Activity\n4) Goal Activity\n5) Quit\n");

        _choice = int.Parse(Console.ReadLine());
    }

    public bool RunProgram()
    {

        switch (_choice)
        {
            case 1:

                BreathingActivity breathingActivity = new BreathingActivity("Breathing Activity", 
                "This activity is meant to help walk you through your breathing. Clear your mind and focus on your breath.");

                breathingActivity.RunBreathingActivity();
                return false;
            
            case 2:

                ListingActivity listingActivity = new ListingActivity(
                ["Who are people that you appreciate?", "What are personal strengths of yours?", "Who are people that you have helped this week?", "When have you felt the Holy Ghost this month?", "Who are some of your personal heroes?"]
                ,"Listing Activity", 
                "This activity will help you think about positive things that have happened in your life by having you list them out.");

                listingActivity.RunListingActivity();

                return false;

            case 3:

                ReflectingActivity reflectingActivity = new ReflectingActivity(
                ["Think of a time when you stood up for someone else.", "Think of a time when you did something really difficult.", "Think of a time when you helped someone in need.", "Think of a time when you did something truly selfless."],
                ["Why was this experience meaningful to you?", "Have you ever done anything like this before?", "How did you get started?", "How did you feel when it was complete?", "What made this time different than other times when you were not as successful?", "What is your favorite thing about this experience?", "What could you learn from this experience that applies to other situations?", "What did you learn about yourself through this experience?", "How can you keep this experience in mind in the future?"],
                "Reflecting Activity", 
                "This activity is to help you focus on times where you have shown strength and resilience. This will help you see that you have power to overcome hard things adn other aspects of your life.");

                reflectingActivity.RunReflectingActivity();

                return false;

            case 4:

                GoalActivity goalActivity = new GoalActivity(
                    "Goal Activity", 
                    "This activity is to help you layout basic steps for a goal you would like to achieve.");
                goalActivity.RunGoalActivity();
                
                return false;

            case 5:

                Console.WriteLine("Good bye");
                return true;
        }

        return false;
        
    }
}