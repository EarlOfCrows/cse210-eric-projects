using System.Diagnostics;
public class Breathing : Activity
{
    public Breathing(string name, string description, int durration) : base(name, description, durration)
    {
        
    }
    public static void BreathIn()
    {
        Console.Write("Breath in...");
        Activity.Countdown(4);
        Console.Write("\b");
        Console.WriteLine("");
    }
    public static void BreathOut()
    {
        Console.Write("Now breath out...");
        Activity.Countdown(6);
        Console.Write("\b");
        Console.WriteLine("\n");

    }
    public static void BreathingAct()
    {
        Console.Clear();
        Activity.Loading(7);
        Breathing breathingActivity = new("Breathing Activity", "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.",0);
        Activity.StartMessage(breathingActivity.GetName(),breathingActivity.GetDescription());
        Console.Write("How long, in seconds, would you like for your session? ");
        int length = int.Parse(Console.ReadLine());
        breathingActivity.SetDurration(length);Console.Clear();
        int timesToBreath = length/10;
        if (timesToBreath < 1)
        {
            timesToBreath = 1;
        }
        Console.WriteLine("Get ready...\n");
        Activity.Loading(8);
        TimeSpan timeLimit = TimeSpan.FromSeconds(breathingActivity.GetDurration());
        Stopwatch stopwatch = Stopwatch.StartNew();
        while (stopwatch.Elapsed < timeLimit)
        {
            BreathIn();
            BreathOut();
        }
        Console.WriteLine("Well done!");
        Activity.Loading(9);
        Activity.EndMessage(breathingActivity.GetDurration(),breathingActivity.GetName());
        Console.Clear();


    }
}