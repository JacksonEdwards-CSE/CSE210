
using System.Numerics;

class Goals
{

    List<Goal> _goalsList = new List<Goal>();
    private int _totalPoints = 0;

    private int _level;

    public void DisplayTotalPoints()
    {
        CalculateTotalPoints();
        GetLevel();
        Console.WriteLine($"Total Points: {_totalPoints}/{100 + (_level * 50)}     Level:{_level + 1}");
    }
    
    

    private void CalculateTotalPoints()
    {
        _totalPoints = 0;

        foreach (Goal goal in _goalsList)
        {
            if (goal.GetStatus())
            {
                int points = goal.GetPoints();

                _totalPoints += points;
            }
        }
    }
    
    private void GetLevel()
    {
        if (_totalPoints >= 100)
        {
            _level = 1 + (_totalPoints - 100) / 50;
        }
    }

    public void DisplayGoals()
    {
        int i = 1;
        foreach (Goal goal in _goalsList)
        {
            Console.WriteLine($"{i++}: {goal.GetConsoleString()}");
        }
    }

    public List<Goal> GetGoalsList()
    {
        return _goalsList;
    }

    public void AppendGoal(Goal goal)
    {
        _goalsList.Add(goal);
    }

    public void RecordGoalEvent(int goalIndex)
    {
        _goalsList[goalIndex].RecordEvent();
    }

    public void WriteToFile()
    {
        foreach (Goal goal in _goalsList)
        {
            goal.GetFileString();
        }
    }
}