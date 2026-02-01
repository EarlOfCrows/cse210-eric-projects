using System;
using System.Security.Cryptography.X509Certificates;

public class Prompt
{
    public List<string> _prompts = ["Who was the most interesting person I interacted with today?",
    "What was the best part of my day?",
    "How did I see the hand of the Lord in my life today?",
    "What was the strongest emotion I felt today?",
    "If I had one thing I could do over today, what would it be?",
    "What am I most grateful for today?",
    "What challenge did I face today, and how did I respond?",
    "When did I feel peace today?",
    "What is something I learned about myself today?",
    "How did I serve someone else today?",
    "What prayer was answered today, even in a small way?",
    "What moment today made me pause and reflect?",
    "What is something I need help with right now?",
    "How did I grow spiritually today?",
    "What brought me joy that I didn’t expect?"];
    public string GetPrompt()
        {
            Random rng = new Random();
            Prompt prompts = new Prompt();
            int rand1 = rng.Next(prompts._prompts.Count);
            return prompts._prompts[rand1];
        }
        
}