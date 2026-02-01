using System;
using System.IO;

class Journal
{
    public List<Entry> _entries = new List<Entry>();

    public void SaveEntries(string input, string prompt)
    {
        Entry new_entry = new Entry();
        new_entry._input = input;
        new_entry._prompts = prompt;
        new_entry._date = DateTime.Now.ToShortDateString();
        _entries.Add(new_entry);
    }

    public void SaveToFile(List<Entry> new_entries)
    {
        Console.Write("Enter a filename: ");
        string filename = Console.ReadLine();
        Console.WriteLine("saving file... ");

        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            foreach(Entry e in _entries)
            {
                outputFile.WriteLine($"{e._date}\\{e._prompts}\\{e._input}");
            }
        }
        Console.WriteLine($"File saved to: {Path.GetFullPath(filename)}");

    }

    public Journal LoadEntries()
    {
        Journal new_journal = new Journal();
        Console.Write("Enter a filename: ");
        string filename = Console.ReadLine();
        Console.WriteLine("loading file... ");

        string[] lines = System.IO.File.ReadAllLines(filename);

        foreach (string line in lines)
        {
            string[] attibues = line.Split("\\");
            Entry new_entry = new Entry();
            new_entry._date = attibues[0];
            new_entry._prompts = attibues[1];
            new_entry._input = attibues[2];

            new_journal._entries.Add(new_entry);
        }
        return new_journal;
        
    }

    public void DisplayEntries()
    {
        Console.WriteLine();
        foreach (Entry e in _entries)
        {
            Console.WriteLine($"Date: {e._date} - Prompt: {e._prompts}");
            Console.WriteLine(e._input);
            Console.WriteLine();
        }
    }
    
}