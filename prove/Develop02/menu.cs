using System;
using System.Threading.Tasks.Dataflow;

public class Menu
{
    public String _write = "1. Write";
    public String _display = "2. Display";
    public String _load = "3. Load";
    public String _save = "4. Save";
    public String _quit = "5. Quit";

        static void DisplayMenu()
        {
            Menu menu = new Menu();
            Console.WriteLine($"Please select one of the following choices:\n{menu._write}\n{menu._display}\n{menu._load}\n{menu._save}\n{menu._quit}");
        }
}