using System;
using System.Security.Cryptography.X509Certificates;

public class Prompt
{
    public List<string> _prompts = ["Who was the most interesting person I interacted with today?", "What was the best part of my day?",
"How did I see the hand of the Lord in my life today?",
"What was the strongest emotion I felt today?",
"If I had one thing I could do over today, what would it be?"];
    public string get_prompt()
        {
            Random rng = new Random();
            Prompt prompts = new Prompt();
            int rand1 = rng.Next(prompts._prompts.Count);
            return prompts._prompts[rand1];
        }
}