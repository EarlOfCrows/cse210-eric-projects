using System;

class Journal
{
    public List<Entry> entries = new List<Entry>();

    public void save_entries(string input, string prompt)
    {
        Entry new_entry = new Entry();
        new_entry._input = input;
        new_entry.prompts = prompt;
        new_entry.Date = DateTime.Now.ToShortDateString();
        entries.Add(new_entry);
    }

    public void save_to_file(List<Entry> new_entries)
    {
        Console.Write("Enter filename: ");
        string filename = Console.ReadLine();
        Console.WriteLine("saving file... ");

        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            foreach(Entry e in entries)
            {
                outputFile.WriteLine($"Date: {e.Date} - Prompt: {e.prompts}\ne._input\n");
            }
        }
        Console.WriteLine($"File saved to: {Path.GetFullPath(filename)}");

    }

    public void load_entries()
    {
        Console.Write("Enter filename: ");
        string filename = Console.ReadLine();
    }

    public void display_entries()
    {
        foreach (Entry e in entries)
        {
            Console.WriteLine($"Date: {e.Date} - Prompt: {e.prompts}");
            Console.WriteLine(e._input);
            Console.WriteLine();
        }
    }
}