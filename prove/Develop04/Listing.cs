using System.Formats.Asn1;
using System;
using System.Diagnostics;
using System.Threading;

public class Listing : Activity
{
    private List<string> _prompts = ["Who are people that you appreciate?", "What are personal strengths of yours?",
        "Who are people that you have helped this week?", "When have you felt the Holy Ghost this month?", "Who are some of your personal heroes?"];
    private int _count = 0;
    public Listing(string name, string description, int durration) : base(name, description, durration)
    {

    }

    public void ListingAct()
    {
        Console.Clear();
        Activity.Loading(8);
        Listing listActivity = new("Listing Activity", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.", 0);
        Activity.StartMessage(listActivity.GetName(), listActivity.GetDescription());
        Console.Write("How long, in seconds, would you like for your session? ");
        int length = int.Parse(Console.ReadLine());
        listActivity.SetDurration(length);
        Console.Clear();
        Random random = new();
        int prompt_index = random.Next(_prompts.Count());
        string prompt = _prompts[prompt_index];
        Console.WriteLine($"Get Ready...");
        Activity.Loading(7);
        Listing.DisplayPrompt(prompt);
        Console.Write("You may begin in: ");
        Activity.Countdown(5);
        TimeSpan timeLimit = TimeSpan.FromSeconds(listActivity.GetDurration());
        Stopwatch stopwatch = Stopwatch.StartNew();
        while (stopwatch.Elapsed < timeLimit)
        {
            Console.Write("> ");
            string response = Console.ReadLine();
            if (response != "q")
            {
                _count++;
            }
        }
        listActivity.DisplayCount(_count);
        Console.WriteLine("Well done!");
        Activity.EndMessage(listActivity.GetDurration(), listActivity.GetName());
        Activity.Loading(24);
        Console.Clear();

    }
    public static void DisplayPrompt(string prompt)
    {
        Console.WriteLine($"List as many responses you can to the following prompt:\n{prompt}");
    }
    public void DisplayCount(int count)
    {
        Console.WriteLine($"You listed {count} items!\n");
    }
    public void SetCount(int count)
    {
        _count = count;
    }
    public List<string> GetPromts()
    {
        return _prompts;
    }
}