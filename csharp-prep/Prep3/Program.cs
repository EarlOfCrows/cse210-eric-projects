using System;
using System.ComponentModel;
using System.IO.Pipelines;

class Program
{
    static void Main(string[] args)
    {
        int magic_number = 27;

        
        while (true) { 
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
                Console.Write("Do you want to play again? Yes/No: ");
                string play_again = Console.ReadLine();
                if (play_again.Equals("Yes"))
                {
                    return;
                }
                else
                {
                    break;
                }
            }
        }

    }
}