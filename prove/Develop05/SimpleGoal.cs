
class SimpleGoal : Goal
{
    
    public SimpleGoal()
    :base(){}

    public SimpleGoal(string name, string description)
    : base(name, description){}

    public override void RecordEvent()
    { 
        _status = true;
    }
}