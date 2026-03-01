using System;
using System.ComponentModel.DataAnnotations;

class Program
{
    static void Main(string[] args)
    {
        bool in_use = true;
        while (in_use)
        {
            DisplayMenu();
            int choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 5:
                    Console.Clear();
                    in_use = false;
                    break;
                case 4:
                    Gratitude gratitudeactivity = new("","",0);
                    gratitudeactivity.GratitudeActivity();
                    break;
                case 3:
                    Listing listingActivity = new("","",0);
                    listingActivity.ListingAct();
                    break;
                case 2:
                    Reflection reflectionActivity = new("","",0);
                    reflectionActivity.ReflectionAct();
                    break;
                case 1:
                    Breathing.BreathingAct();
                    break;
                default:
                    Console.WriteLine("Please give a valid response");
                    break;
            }
        }
    }

    public static void DisplayMenu()
    {
        Console.Write("Menu Options:\n  1.Start Breathing Activity\n  2.Start Reflecting Activity\n  3.Start Listing Activity\n  4. Start Gratitude Activity\n  5. Quit\nSelect a choice from the menu: ");
    }
}