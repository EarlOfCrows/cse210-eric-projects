using System;

class Program
{
    static void Main(string[] args)
    {
        string letter = "";
        Console.WriteLine("What is your grade (100-0) ");
        string user_grade = Console.ReadLine();
        int grade = int.Parse(user_grade);

        if (grade >= 90)
        {
            letter = "A";
        }
        else if (grade >= 80)
        {
            letter = "B";
        }
        else if (grade >= 70)
        {
            letter = "C";
        }
        else if (grade >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        if (grade >= 70)
        {
            Console.WriteLine($"Congrats You Passed The Class with a {letter}");
        }
        else
        {
            Console.WriteLine($"Sorry you failed the class, you got it next time");
        }

    }
}