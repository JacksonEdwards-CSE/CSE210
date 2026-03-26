
abstract class Goal
{
    public string _name;
    public string _description;
    private int _points;
    protected bool _status;
    private string _goalType;

    public Goal()
    {
        _name = "";
        _description = "";
        _points = 0;
        _status = false;
    }

    public Goal(string name, string description)
    {
        _name = name;
        _description = description;
        _points = 10;
        _status = false;
        _goalType = "Simple Goal";
    }
    public void SetName()
    {
        Console.WriteLine("Please enter the name of your goal:");
        _name = Console.ReadLine();
    }

    public string GetName()
    {
        return _name;
    }

    public void SetDescription()
    {
        Console.WriteLine("What is the purpose of your goal?");
        _description = Console.ReadLine();
    }

    public string GetDescription()
    {
        return _description;
    }

    public string GetConsoleString()
    {
        if (_status)
        {   
            return $"Goal Information: {_name}, {_description}, {_points} points, Complete";
        }
        else
        {
            return $"Goal Information: {_name}, {_description}, {_points} points, Inomplete";
        }
    }

    public virtual void SetPoints()
    {
        Console.WriteLine("How many points is this goal worth?");

        _points = int.Parse(Console.ReadLine());
    }

    public abstract void RecordEvent();

    public bool GetStatus()
    {
        return _status;
    }

    public int GetPoints()
    {
        return _points;
    }
}