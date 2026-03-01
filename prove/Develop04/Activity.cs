using System.ComponentModel;
using System.Runtime.Versioning;

public class Activity
{
    private string _name;
    private string _description;
    private int _durration;

    public Activity(string name, string description, int durrarion)
    {
        _name = name;
        _description = description;
        _durration = durrarion;
    }
    public static void StartMessage(string name, string description)
    {
        Console.WriteLine($"Welcome to the {name}");
        Console.WriteLine(description);
    }
    public static void EndMessage(int time, string name)
    {
        Console.WriteLine($"You have completed another {time} seconds of the {name}");
    }
    public static void Loading(int time)
    {
        List<string> animation = ["_----","-_---","--_--","---_-","----_","---_-","--_--","-_---","_----"];
        for(int i=0; i<time; i++)
        {
            int frame = i;
            if (frame > 8)
            {
                frame = frame % 8;
            }
            Console.Write(animation[frame]);
            Thread.Sleep(250);
            Console.Write("\b\b\b\b\b");
        }
    }
    public static void Countdown(int seconds){
        for(int i=seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b");
        }
       Console.Write("\b \b");
       Console.WriteLine();
        
    }
    public int GetDurration()
    {
        return _durration;
    }
    public void SetDurration(int durration)
    {
        _durration = durration;
    }
    public string GetName()
    {
        return _name;
    }
    public string GetDescription()
    {
        return _description;
    }
}