
using System.Numerics;

class Goals
{

    List<Goal> _goalsList = new List<Goal>();
    private int _totalPoints = 0;

    public void DisplayTotalPoints()
    {
        CalculateTotalPoints();
        Console.WriteLine($"Total Points: {_totalPoints}");
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