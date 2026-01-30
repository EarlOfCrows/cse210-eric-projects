using System;

public class Entry
{
    public string _input;
    public string prompts;
    public void run()
    {
        static string get_prompts()
        {
            Prompt prompts = new Prompt();
            string prompt = prompts.get_prompt();
            return prompt;
        }

        static void display_entry()
        {
            
        }
    }
}