
abstract class Goal
{
    public string _name;
    public string _description;
    protected int _points;
    protected bool _status;

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
    }

    public Goal(string name, string description, int points, bool status)
    {
        _name = name;
        _description = description;
        _points = points;
        _status = status;
    }
    public void SetName()
    {
        Console.Write("Please enter the name of your goal:");
        _name = Console.ReadLine();

        Console.WriteLine();
    }

    public string GetName()
    {
        return _name;
    }

    public void SetDescription()
    {
        Console.Write("Please enter the description of your goal: ");
        _description = Console.ReadLine();
        
        Console.WriteLine();
    }

    public string GetDescription()
    {
        return _description;
    }

    public virtual void SetPoints()
    {
        Console.Write("Please enter the amount of points this goal is worth: ");
        _points = int.Parse(Console.ReadLine());
        
        Console.WriteLine();
    }

    public virtual int GetPoints()
    {
        return _points;
    }

    public virtual string GetConsoleString()
    {
        if (_status)
        {   
            return $"[X]{_name} ({_description})";
        }
        else
        {
            return $"[ ] {_name} ({_description})";
        }
    }

    public bool GetStatus()
    {
        return _status;
    }

    public abstract void RecordEvent();

    public virtual string GetFileString()
    {
        if (_status)
        {   
            return $"SimpleGoal#{_name}#{_description}#{_points}#true";
        }
        else
        {
            return $"SimpleGoal#{_name}#{_description}#{_points}#false";
        }
    }
}
