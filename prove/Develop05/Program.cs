using System;

class Program
{
    static void Main(string[] args)
    {
        AllGoals allGoals = new();
        Goals agoal = new("","",0);
        bool in_use = true;
        while (in_use){
        DisplayMenu(allGoals.GetPoints());
        int choice = int.Parse(Console.ReadLine());
        switch (choice)
            {
                case 6:
                    Console.Clear();
                    in_use = false;
                    agoal.SaveGoals(allGoals, "autosave.txt");
                    break;
                case 5:
                    agoal.RecordGoal(allGoals);
                    agoal.SaveGoals(allGoals, "autosave.txt");
                    break;
                case 4:
                    allGoals.SetGoals(agoal.LoadGoals(allGoals));
                    agoal.SaveGoals(allGoals, "autosave.txt");
                    break;
                case 3:
                    agoal.SaveGoals(allGoals);
                    agoal.SaveGoals(allGoals, "autosave.txt");
                    break;
                case 2:
                int i = 1;
                    Console.WriteLine("The Goals are:");
                    foreach(Goals currentgoal in allGoals.GetGoals())
                    {
                        Console.Write($"{i}. ");
                        currentgoal.DisplayGoal();
                        i++;
                    }
                    Console.WriteLine();
                    agoal.SaveGoals(allGoals, "autosave.txt");
                    break;
                case 1:
                    DisplayCreateGoals();
                    int goal = int.Parse(Console.ReadLine());
                    if(goal == 1)
                {
                    Simple simplegoal = new("","",0,false);
                    simplegoal.CreateGoal();
                    allGoals.AddGoal(simplegoal);
                }
                else if (goal == 2)
                {
                    Eternal eternalgoal = new("","",0);
                    eternalgoal.CreateGoal();
                    allGoals.AddGoal(eternalgoal);
                }
                else
                {
                    Checklist checklistgoal = new("","",0,0,0,0,false);
                    checklistgoal.CreateGoal();
                    allGoals.AddGoal(checklistgoal);
                }
                agoal.SaveGoals(allGoals, "autosave.txt");
                break;
                default:
                    Console.WriteLine("Please give a valid response");
                break;
            }
        }
    }
    public static void DisplayMenu(int currentpoints)
    {
        AllGoals points = new();
        Console.Write($"You have {currentpoints} points.\n\nMenu Options:\n  1. Create New Goal\n  2. List Goals\n  3. Save Goals\n  4. Load Goals\n  5. Record Event\n  6. Quit\nSelect a choice from the menu: ");
    }
    public static void DisplayCreateGoals()
    {
        Console.Write("The types of Goals are:\n  1. Simple Goal\n  2. Eternal Goal\n  3. Checklist Goal\nWhich type of goal would you like to create? ");
    }
}