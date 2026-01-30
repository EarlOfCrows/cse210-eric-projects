using System;

class Journal
{
    public List<Entry> entries;
    public void run()
    {
        
    }
    public void save_entries(string input, string prompt)
    {
        Journal used_journal = new Journal();
        Entry new_entry = new Entry();
        new_entry._input = input;
        new_entry.prompts = prompt;
        used_journal.entries.Add(new_entry);
        Console.WriteLine(used_journal);
    }

    public void load_entries()
    {
        
    }

    public void display_entries()
    {
        
    }
}