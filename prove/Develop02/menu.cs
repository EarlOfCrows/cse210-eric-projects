using System;
using System.Threading.Tasks.Dataflow;

public class Menu
{
    public String _write = "1. Write";
    public String _display = "2. Display";
    public String _load = "3. Load";
    public String _save = "4. Save";
    public String _quit = "5. Quit";
    public void run()
    {
        static String display_menu(string write)
        {
            return write;
        }
    }
}