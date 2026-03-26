
using System.Numerics;

class Goals
{

    List<Goal> goalsList = new List<Goal>();
    private int _totalPoints;

    public string DisplayTotalPoints()
    {
        CalculateTotalPoints();
        return $"Total Points: {_totalPoints}";
    }

    private void CalculateTotalPoints()
    {
        foreach (Goal goal in goalsList)
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
        foreach (Goal goal in goalsList)
        {
            goal.GetConsoleString();
        }
    }
}