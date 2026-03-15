public class AllGoals
{
    private List<Goals> _AllGoals = [];
    private int _TotalPoints = 0;

    public void AddGoal(Goals goal)
    {
        _AllGoals.Add(goal);
    }
    public List<Goals> GetGoals()
    {
        return _AllGoals;
    }
    public void SetGoals(List<Goals> NewGoals)
    {
        _AllGoals = NewGoals;
    }
    public int GetPoints()
    {
        return _TotalPoints;
    }
    public void AddToPoints(Goals goal)
    {
        _TotalPoints += goal.AddPoints();
    }
    public void SetTotalPoints(int points)
    {
        _TotalPoints = points;
    }
}