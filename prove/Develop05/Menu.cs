
class Menu
{

    Goals _goals = new Goals();
    private int _userChoice;

    public void ProcessMenu()
    {   Console.Clear();

        _goals.DisplayTotalPoints();
        Console.WriteLine($"\nMenu Options:\n1) Create New Goal\n2) Show Goals\n3) Save Goals\n4) Load Goals\n5) Record Event\n6) Quit\n");
        
        Console.Write("Select a choice: ");
        _userChoice = int.Parse(Console.ReadLine());

        Console.Clear();
    }

    public bool RunProgram()
    {

        switch (_userChoice)
        {
            case 1:

                Console.WriteLine("Goal Options:\n1) Simple Goal\n2) Eternal Goal\n3) Checklist Goal\n");

                Console.Write("Select a choice: ");
                int goalChoice = int.Parse(Console.ReadLine());

                switch (goalChoice)
                {
                    case 1:

                        SimpleGoal simpleGoal = new SimpleGoal();

                        simpleGoal.SetName();

                        simpleGoal.SetDescription();

                        simpleGoal.SetPoints();

                        _goals.AppendGoal(simpleGoal);

                        return false;
                    
                    case 2:

                        EternalGoal eternalGoal = new EternalGoal();

                        eternalGoal.SetName();

                        eternalGoal.SetDescription();

                        eternalGoal.SetPoints();

                        _goals.AppendGoal(eternalGoal);

                        return false;

                    case 3:

                        ChecklistGoal checklistGoal = new ChecklistGoal();

                        checklistGoal.SetName();

                        checklistGoal.SetDescription();

                        checklistGoal.SetPoints();

                        _goals.AppendGoal(checklistGoal);

                        return false;
                }

                Console.WriteLine("Please enter a valid choice.");

                return false;
            
            case 2:

                _goals.DisplayTotalPoints();

                _goals.DisplayGoals();

                Console.ReadLine();

                return false;
            
            case 3:

                Console.WriteLine("Save Goals");

                Console.Write("Please enter the name of the File: ");

                string writeFileName = Console.ReadLine();

                using (StreamWriter outputFile = new StreamWriter(writeFileName))
                {
                    List<Goal> goalsList = _goals.GetGoalsList();

                    foreach (Goal goal in goalsList)
                    {
                       outputFile.WriteLine(goal.GetFileString()); 
                    }

                }

                return false;
            
            case 4:

                Console.WriteLine("Load Goals");

                Console.Write("Enter the name of the File: ");

                string readFileName = Console.ReadLine();

                string[] lines = System.IO.File.ReadAllLines(readFileName);

                foreach (string line in lines)
                {
                    Console.WriteLine(line);
                    Console.ReadLine();
                    string[] goalParts = line.Split('#');

                    if(goalParts[0] == "SimpleGoal")
                    {
                        SimpleGoal goal = new SimpleGoal(goalParts[1], goalParts[2], int.Parse(goalParts[3]), bool.Parse(goalParts[4]));

                        _goals.AppendGoal(goal);
                    }
                    else if(goalParts[0] == "EternalGoal")
                    {
                        EternalGoal goal = new EternalGoal(goalParts[1], goalParts[2], int.Parse(goalParts[3]), int.Parse(goalParts[4]));

                        _goals.AppendGoal(goal);
                    }

                    else
                    {
                        ChecklistGoal goal = new ChecklistGoal(goalParts[1], goalParts[2], int.Parse(goalParts[3]), int.Parse(goalParts[4]), int.Parse(goalParts[5]), int.Parse(goalParts[6]));
                        
                        _goals.AppendGoal(goal);
                    }

                }

                return false;
            
            case 5:

                Console.WriteLine("Record Event");

                _goals.DisplayGoals();

                Console.Write("Select a goal to record and event for: ");
                int goalIndex = int.Parse(Console.ReadLine());

                _goals.RecordGoalEvent(goalIndex - 1);

                return false;
            
            case 6:

                Console.WriteLine("Good Bye!");

                return true;
            
        }

        Console.WriteLine("Please enter a valid choice.");

        return false;
        
    }
}