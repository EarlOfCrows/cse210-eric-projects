public class Eternal : Goals
{
    public Eternal(string name, string description, int points) : base (name, description, points){
    }
    public override void DisplayGoal()
    { 
        Console.WriteLine($"{GetName()} ({GetDescription()})");
    }
    public override int AddPoints()
    {
        return GetPoints();
    }
    public override string SaveGoal(Goals goals)
    {
       return $"Eternal~~{goals.GetName()}~~{goals.GetDescription()}~~{goals.GetPoints()}";
    }
        
}