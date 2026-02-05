using System;

class Program
{
    static void Main(string[] args)
    {
        Boolean in_use = true;
        Scriptures scriptures = new Scriptures();
        while(in_use){
        Console.WriteLine("1: Any key to remove more words\n2: Q to quit");
        string user_choice = Console.ReadLine();

        scriptures.CreateScriptures();

        if (user_choice == "q"|| user_choice == "Q")
        {
            in_use = false;
            break;
        }
        else
        {
            RemoveWords();
        }

        static void RemoveWords()
        {
            Console.WriteLine("words removed");
        }
        }
    }
}