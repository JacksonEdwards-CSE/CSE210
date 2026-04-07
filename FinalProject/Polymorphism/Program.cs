
class Program()
{
    public static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>();

        Running running = new Running(5, "April 7 2026", 45);
        activities.Add(running);

        Cycling cycling = new Cycling(25, "April 8 2026", 60);
        activities.Add(cycling);

        Swimming swimming = new Swimming(60, "April 9 2026", 30);
        activities.Add(swimming);

        foreach (Activity activity in activities)
        {
            Console.WriteLine(" - Summary - ");
            activity.DisplaySummary();
            Console.WriteLine();
        }
    }
}