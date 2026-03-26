
class Menu
{

    Goals _goals = new Goals();
    private int _userChoice;

    public void ProcessMenu()
    {
        Console.WriteLine($"{_goals.DisplayTotalPoints}\n\nMenu Options:\n1) Create New Goal\n2) Show Goals\n3) Save Goals\n4) Load Goals\n5) Record Event\n6) Quit\n");
        
        Console.Write("Select a choice: ");
        _userChoice = int.Parse(Console.ReadLine());
    }

    public void RunProgram()
    {

        switch (_userChoice)
        {
            case 1:

                Console.WriteLine("Create New Goal");

                break;
            
            case 2:

                _goals.DisplayGoals();

                break;
            
            case 3:

                break;
            
            case 4:

                break;
            
            case 5:

                break;
            
            case 6:

                break;
            
        }
        
    }
}