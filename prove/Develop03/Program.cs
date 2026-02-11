using System;

class Program
{
    static void Main(string[] args)
    {
        Boolean this_scripture = true;
        Boolean in_use = true;
        Reference new_reference = new Reference("", 1, 1, 1);
        Scriptures scriptures = new Scriptures("", new_reference);
        scriptures.CreateScriptures();
        while(in_use){
        Random random = new();
        int next_scripture = random.Next(scriptures.all_scriptures.Count());
        Scriptures current_scripture = scriptures.all_scriptures[next_scripture];
        List<string> each_word = current_scripture.BreakDownScripture();
        current_scripture.CreateWords(each_word);
        this_scripture = true;

        while(this_scripture){
            Console.WriteLine("1: Any key to remove more words\n2: Q to quit \n3: N for next verse");
            string user_choice = Console.ReadLine();
            if (user_choice == "q"|| user_choice == "Q")
            {
                in_use = false;
                break;
            }
            if (user_choice == "n"|| user_choice == "N")
            {
                break;
            }
            else
            {
                current_scripture.HideWords();
                Console.WriteLine(current_scripture.DisplayScripture());
            }
        }
        
    }
    }
}