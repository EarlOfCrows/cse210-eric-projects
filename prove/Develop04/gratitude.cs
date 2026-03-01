using System.Diagnostics;
public class Gratitude : Activity
{
    private List<string> _prompts = ["What memory always warms your heart?","What is one small win you had today?","Who has positively influenced your life?","What is a personal strength you’re grateful to have?"];
    private int _count;
    public Gratitude(string name, string description, int durration) : base(name, description, durration)
    {

    }
    public void GratitudeActivity()
    {
        Console.Clear();
        Activity.Loading(8);
        Gratitude gradactivity = new("Gradtitude Activity", "This activity will help you find what you are grateful for, by responding to prompts about what you are grateful for.", 0);
        Activity.StartMessage(gradactivity.GetName(), gradactivity.GetDescription());
        Console.Write("How long, in seconds, would you like for your session? ");
        int length = int.Parse(Console.ReadLine());
        gradactivity.SetDurration(length);
        Console.Clear();
        Random random = new();
        Console.WriteLine($"Get Ready...");
        Activity.Loading(7);
        TimeSpan timeLimit = TimeSpan.FromSeconds(gradactivity.GetDurration());
        Stopwatch stopwatch = Stopwatch.StartNew();
        while(stopwatch.Elapsed < timeLimit)
        {
            int prompt_index = random.Next(_prompts.Count());
            string prompt = _prompts[prompt_index];
            Gratitude.DisplayPrompt(prompt);
            Console.ReadLine();
            _count ++;
        }
        Console.WriteLine("Well Done!!!");
        gradactivity.DisplayCount(_count);
        Activity.EndMessage(gradactivity.GetDurration(),gradactivity.GetName());
        Activity.Loading(24);
        Console.Clear();
    }
    public void DisplayCount(int count)
    {
        Console.WriteLine($"You learned {count} things you're grateful for!\n");
    }
    public static void DisplayPrompt(string prompt)
    {
        Console.Write($"---{prompt}---\n>");
    }
}