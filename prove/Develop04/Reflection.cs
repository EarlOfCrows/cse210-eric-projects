using System.Diagnostics;
public class Reflection : Activity
{
    private List<string> _prompts = ["Think of a time when you stood up for someone else.","Think of a time when you did something really difficult.","Think of a time when you helped someone in need.","Think of a time when you did something truly selfless."];
    private List<string> _questions = ["Why was this experience meaningful to you?","Have you ever done anything like this before?","How did you get started?"
,"How did you feel when it was complete?","What made this time different than other times when you were not as successful?","What is your favorite thing about this experience?"
,"What could you learn from this experience that applies to other situations?","What did you learn about yourself through this experience?","How can you keep this experience in mind in the future?"];

    public Reflection(string name, string description, int durration) : base(name, description, durration)
    {
        
    }
    public void ReflectionAct()
    {
        Console.Clear();
        Activity.Loading(10);
        Reflection reflectionAct = new("Reflection Avtivity","This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.",0);
        Activity.StartMessage(reflectionAct.GetName(), reflectionAct.GetDescription());
        Console.Write("How long, in seconds, would you like for your session? ");
        int length = int.Parse(Console.ReadLine());
        reflectionAct.SetDurration(length);
        Console.Clear();
        Console.WriteLine($"Get Ready...");
        Random random = new();
        int prompt_index = random.Next(_prompts.Count());
        string prompt = _prompts[prompt_index];
        Activity.Loading(9);
        reflectionAct.DisplayPrompt(prompt);
        Console.WriteLine("When you have something in mind, press enter to continue.");
        string continueCheck = Console.ReadLine();
        Console.Clear();
        Console.WriteLine("Now ponder on each of the folowing questions as they related to this experience.");
        Console.Write("You may begin in: ");
        Activity.Countdown(5);
        TimeSpan timeLimit = TimeSpan.FromSeconds(reflectionAct.GetDurration());
        Stopwatch stopwatch = Stopwatch.StartNew();
        while(stopwatch.Elapsed < timeLimit)
        {
            int question_index = random.Next(_questions.Count());
            string question = _questions[question_index];
            reflectionAct.DisplayQuestion(question);
            Activity.Loading(40);
            Console.WriteLine();
        }
        Console.WriteLine("Well Done!!!");
        Activity.EndMessage(reflectionAct.GetDurration(),reflectionAct.GetName());
        Activity.Loading(6);
        Console.Clear();

    }
    public void DisplayPrompt(string prompt)
    {
        Console.WriteLine($"Consider the following prompt:\n---{prompt}---");
    }
    public void DisplayQuestion(string question)
    {
        Console.Write($">{question}");
    }
}