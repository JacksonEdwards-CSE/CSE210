
class ChecklistGoal : Goal
{

    int _timesRepeated;

    int _timesCompleted;

    int _bonusPoints;

    public ChecklistGoal()
    :base(){ _status = true;}

    public ChecklistGoal(string name, string description)
    : base(name, description){_status = true;}

    public ChecklistGoal(string name, string description, int points, int bonusPoints, int timesCompleted, int timesRepeated)
    : base(name, description)
    {
        _points = points;
        _bonusPoints = bonusPoints;
        _timesCompleted = timesCompleted;
        _timesRepeated = timesRepeated;
        _status = true;
    }

    public override void SetPoints()
    {
        
        Console.Write("Please enter the amount of time this goal will need to be completed: ");
        _timesRepeated = int.Parse(Console.ReadLine());

        Console.WriteLine();

        base.SetPoints();
        
        Console.Write("Please enter the amount of bonus points that will be earned when this goal is fully completed: ");
        _bonusPoints = int.Parse(Console.ReadLine());
    }

    public override int GetPoints()
    {
        int totalPoints;

        if (_timesCompleted != _timesRepeated)

            totalPoints = _points * _timesCompleted;

        else
        {
            totalPoints = (_points * _timesCompleted) + _bonusPoints;
        }

        return totalPoints;
    }

    public override string GetConsoleString()
    {
        if (_timesCompleted != _timesRepeated)
        {   
            return $"[ ]{_name} ({_description}), Times Completed: {_timesCompleted}/{_timesRepeated}";
        }
        else
        {
            return $"[X] {_name} ({_description}), Times Completed: {_timesCompleted}/{_timesRepeated}";
        }
    }

    public override string GetFileString()
    {
  
            return $"ChecklistGoal#{_name}#{_description}#{_points}#{_bonusPoints}#{_timesCompleted}#{_timesRepeated}";
    }

    public override void RecordEvent()
    {

        if (_timesCompleted != _timesRepeated)
        {
         _timesCompleted++;
        }
       
    }
}