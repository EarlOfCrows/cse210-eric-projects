using System;
using System.IO.Pipelines;

class Program
{
    static void Main(string[] args)
    {
        int magic_number = 27;

        do 
        { 
            Console.WriteLine($"What is the Magic number: {magic_number}");
            Console.Write("What is your guess: ");
            string guess = Console.ReadLine();
            int num_guess = int.Parse(guess);
            if (num_guess > magic_number)
            {
                Console.WriteLine("Lower");
            }
            else if (num_guess < magic_number)
            {
                Console.WriteLine("Higher");
            }
            else
            {
                Console.WriteLine("You guessed it!");
                break;
            }
        } while (true);

    }
}