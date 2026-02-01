using System;

public class Entry
{
    public string _input;
    public string _prompts;
    public string _date;

    static string GetPrompts()
    {
        Prompt prompts = new Prompt();
        string prompt = prompts.GetPrompt();
        return prompt;
    }

}