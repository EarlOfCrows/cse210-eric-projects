using System;
using System.Security.Cryptography.X509Certificates;

public class Program
{
    static void Main(string[] args)
    { 
        Console.WriteLine("Welcome to the Journal Program!");
        Boolean in_use = true;
        Journal user_journal = new Journal();
        while (in_use)
        {
            Menu menu = new Menu();
            Prompt prompts = new Prompt();

            Console.WriteLine($"Please select one of the following choices:\n{menu._write}\n{menu._display}\n{menu._load}\n{menu._save}\n{menu._quit}");
            Console.Write("What would you like to do? ");
            int choice = int.Parse(Console.ReadLine());
            if (choice == 1)
            {
                //Entry new_entry = new Entry();
                string wirting_prompt = prompts.get_prompt();
                Console.WriteLine(wirting_prompt);
                string user_input = Console.ReadLine();
                //Console.WriteLine(user_input + wirting_prompt);
                user_journal.save_entries(user_input, wirting_prompt);
                
               
            }
            else if (choice == 2)
            {
                user_journal.display_entries();
            }
            
            else if (choice == 3)
            {
                
            }

            else if (choice == 4)
            {
                user_journal.save_to_file(user_journal.entries);
            }
            
            else
            {
                in_use = false;
            }

        }
    }
}