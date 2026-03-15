using System.Security.Cryptography;

public class Goals
{
    private string _Name;
    private string _Description;
    private int _Points;

    public Goals(string name, string description, int points)
    {
        _Name = name;
        _Description = description;
        _Points = points;
    }
    public virtual void CreateGoal()
    {
        Console.Write("What is the name of your goal? ");
        string name = Console.ReadLine();
        _Name = name;
        Console.Write("What is a short description of it? ");
        string description = Console.ReadLine();
        _Description = description;
        Console.Write("What is the amount of points associated with this goal? ");
        int points = int.Parse(Console.ReadLine());
        _Points = points;
    }
    public virtual void DisplayGoal()
    {
        Console.WriteLine("The Goals are: \n");
    }
    public void RecordGoal(AllGoals goals)
    {
        List<Goals> goalstocomplete = [];
        int i =1;
            foreach(Goals currentgoals in goals.GetGoals())
            {
                if(currentgoals.IsComplete() != true)
            {
                goalstocomplete.Add(currentgoals);
            }
            }
            if (goalstocomplete.Count() == 0)
            {
                Console.WriteLine("You don't have any goals left to complete\n");
            }
            else{
            Console.WriteLine("The Goals are:");
            foreach(Goals currentgoal in goalstocomplete)
            {
                Console.Write($"{i}. ");
                Console.WriteLine(currentgoal.GetName());
                i++;
            }
            Console.WriteLine("Which goal did you accomplish? ");
            int choice = int.Parse(Console.ReadLine());
            Goals choicegoal = goalstocomplete[choice-1];
            choicegoal.completeGoal();
            goals.AddToPoints(choicegoal);
            Console.WriteLine($"Congratulations! You earned {choicegoal.AddPoints()} points!");
            }
    }
    public void SaveGoals(AllGoals allGoalsContainer, string filename = "") 
    {
    if (string.IsNullOrEmpty(filename)){
        Console.Write("Enter a filename: ");
        filename = Console.ReadLine();
    }

    using (StreamWriter outputFile = new StreamWriter(filename))
        {
        outputFile.WriteLine(allGoalsContainer.GetPoints());

        foreach(Goals goal in allGoalsContainer.GetGoals())
            {
                outputFile.WriteLine(goal.SaveGoal(goal));
            }
        }
    }
    public virtual string SaveGoal(Goals goals)
    {
        return "";
    }
    public List<Goals> LoadGoals(AllGoals mainContainer)
{
    Console.Write("Enter a filename: ");
    string filename = Console.ReadLine();

    if (!File.Exists(filename))
    {
        Console.WriteLine("File not found.");
        return new List<Goals>();
    }

    string[] lines = System.IO.File.ReadAllLines(filename);
    int savedScore = int.Parse(lines[0]);
    mainContainer.SetTotalPoints(savedScore); 

    List<Goals> loadedGoalsList = new List<Goals>();
    for (int i = 1; i < lines.Length; i++)
    {
        string line = lines[i];
        string[] attributes = line.Split("~~");
        string type = attributes[0];

        if (type == "Simple")
        {
            bool isDone = attributes[4] == "True";
            Simple goal = new(attributes[1], attributes[2], int.Parse(attributes[3]), isDone);
            loadedGoalsList.Add(goal);
        }
        else if (type == "Eternal")
        {
            Eternal goal = new(attributes[1], attributes[2], int.Parse(attributes[3]));
            loadedGoalsList.Add(goal);
        }
        else if (type == "Checklist")
        {
            Checklist goal = new(attributes[1], attributes[2], int.Parse(attributes[3]), 
            int.Parse(attributes[4]), int.Parse(attributes[5]), 
            int.Parse(attributes[6]), attributes[7] == "True");
            loadedGoalsList.Add(goal);
        }
    }

    Console.WriteLine("File loaded successfully!");
    return loadedGoalsList;
}
    public virtual void completeGoal()
    {
        
    }
    public virtual bool IsComplete()
    {
        return false;
    }
    public virtual int AddPoints()
    {
        return 0;
    }
    public int GetPoints()
    {
        return _Points;
    }
    public void SetPoints(int points)
    {
        _Points = points;
    }
    public string GetName()
    {
        return _Name;
    }
    public void SetName(string name)
    {
        _Name = name;
    }
    public string GetDescription()
    {
        return _Description;
    }
    public void SetDescription(string description)
    {
        _Description = description;
    }
}
