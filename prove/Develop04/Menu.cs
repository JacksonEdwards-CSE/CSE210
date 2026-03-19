
class Menu
{
    private int _choice;

    public void ProcessMenu()
    {
        Console.WriteLine("Choose and activity to complete:\n1) Breathing Acitvity\n2) Listing Activity\n3) Reflecting Activity\n4) Quit");

        _choice = int.Parse(Console.ReadLine());
    }

    public bool RunProgram()
    {

        switch (_choice)
        {
            case 1:

                Console.WriteLine("Case 1");

                return false;
            
            case 2:

                Console.WriteLine("Case 2");

                return false;

            case 3:

                Console.WriteLine("Case 3");

                return false;

            case 4:

                Console.WriteLine("Good bye");
                return true;
        }

        return false;
        
    }
}