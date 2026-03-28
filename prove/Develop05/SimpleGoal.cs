
class SimpleGoal : Goal
{
    
    public SimpleGoal()
    :base(){}

    public SimpleGoal(string name, string description)
    : base(name, description){}

    public SimpleGoal(string name, string description, int points, bool status)
    : base(name, description, points, status){}

    public override void RecordEvent()
    { 
        _status = true;
    }
}