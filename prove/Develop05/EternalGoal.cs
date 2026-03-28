
class EternalGoal : Goal
{

    int _timesCompleted = 0;

    public EternalGoal()
    :base(){ _status = true;}

    public EternalGoal(string name, string description)
    : base(name, description){_status = true;}

    public EternalGoal(string name, string description, int points, int timesCompleted)
    : base(name, description)
    {
        _points = points;
        _timesCompleted = timesCompleted;
        _status = true;
    }

    

    public override int GetPoints()
    {
        return _points * _timesCompleted;
    }

    public override string GetConsoleString()
    {
        return $"[ ] {_name} ({_description}), Times Completed: {_timesCompleted}";
    }

    public override string GetFileString()
    {
            return $"EternalGoal#{_name}#{_description}#{_points}#{_timesCompleted}";
    }

    public override void RecordEvent()
    {
        _timesCompleted++;
    }
}