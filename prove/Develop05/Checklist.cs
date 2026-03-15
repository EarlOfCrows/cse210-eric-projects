public class Checklist : Goals
{
    private int _CompletionBonus;
    private int _TargetAmount;
    private int _CurrentComplete;
    private bool _Completed;

    public Checklist(string name, string description, int points, int bonus, int targetamount, int currentcomplete, bool completed) : base (name, description, points)
    {
        _CompletionBonus = bonus;
        _TargetAmount = targetamount;
        _CurrentComplete = currentcomplete;
        _Completed = completed;
    }
    public override void CreateGoal()
    {
        base.CreateGoal();
        Console.Write("What is the completion bonus points? ");
        int bonus = int.Parse(Console.ReadLine());
        _CompletionBonus = bonus;
        Console.Write("How many times do you want to complete the goal? ");
        int completeamount = int.Parse(Console.ReadLine());
        _TargetAmount = completeamount;
        
    }
    public override void DisplayGoal()
    {
        if(_CurrentComplete != _TargetAmount){
        Console.WriteLine($"[ ] {GetName()} ({GetDescription()}) -- Currently completed: {_CurrentComplete}/{_TargetAmount}");
        }
        else
        {
            Console.WriteLine($"[X] {GetName()} ({GetDescription()}) -- Currently completed: {_CurrentComplete}/{_TargetAmount}");
        }
    }
    public override void completeGoal()
    {
        _CurrentComplete ++;
        if(_CurrentComplete >= _TargetAmount){
        _Completed = true;
        }
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
        int points = 0;
        points += GetPoints();
        if(_CurrentComplete >= _TargetAmount){
        points += _CompletionBonus;
        }
        return points;
    }

    public void SetCompletionBonus(int bonus)
    {
        _CompletionBonus = bonus;
    }
    public void SetTargetAmount(int targetamt)
    {
        _TargetAmount = targetamt;
    }
    public void SetCurrentComplete(int currcomp)
    {
        _CurrentComplete = currcomp;
    }
    public override string SaveGoal(Goals goals)
    {
       return $"Checklist~~{goals.GetName()}~~{goals.GetDescription()}~~{goals.GetPoints()}~~{_CompletionBonus}~~{_TargetAmount}~~{_CurrentComplete}~~{_Completed}";
    }

}