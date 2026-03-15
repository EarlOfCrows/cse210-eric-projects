public class Simple : Goals
{
    private bool _Completed;
    
    public Simple(string name, string description, int points, bool completed) : base (name, description, points)
    {
        _Completed = completed;
    }
    public override void CreateGoal()
    {
        base.CreateGoal();
    }
    public override void DisplayGoal()
    {
        if(!_Completed){
        Console.WriteLine($"[ ] {GetName()} ({GetDescription()})");
        }
        else
        {
            Console.WriteLine($"[X] {GetName()} ({GetDescription()})");
        }

    }
    public override void completeGoal()
    {
        _Completed = true;
    }
    public override bool IsComplete()
    {
        if (_Completed)
        {
            return true;
        }
        return false;
    }
    public override int AddPoints()
    {
        return GetPoints();
    }
    public override string SaveGoal(Goals goals)
    {
       return $"Simple~~{goals.GetName()}~~{goals.GetDescription()}~~{goals.GetPoints()}~~{_Completed}";
    }
}