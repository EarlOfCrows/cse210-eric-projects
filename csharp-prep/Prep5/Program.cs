using System;

class Program
{
    static void Main(string[] args)
    {
        static void DisplayWelcome (){
        Console.WriteLine("Welcome to the program!");
        }
        static string PromptUserName (){
        Console.Write("Please enter your name: ");
        string user_name = Console.ReadLine();
        return user_name;
        }
        static int PromptUserNumber (){
        Console.Write("Please enter your favorite number: ");
        int fav_num = int.Parse(Console.ReadLine());
        return fav_num;
        }

        static int PromtUserBirthYear(){
        Console.Write("Please enter the year you were born: ");
        int birth_year = int.Parse(Console.ReadLine());
        return birth_year;
        }

        static int SquareNumber (int num)
        {
            int sqr_num = num * num;
            return sqr_num;
        }

        static void DisplayResult (string name, int sq_num, int bir_year)
        {
            Console.WriteLine($"{name}, the square of your number is {sq_num}\n{name}, you will turn {2026 - bir_year} this year.");
        }

        DisplayWelcome();
        string users_name = PromptUserName();
        int favorite_num = PromptUserNumber();
        int user_birth_year = PromtUserBirthYear();
        int square_num = SquareNumber(favorite_num);
        DisplayResult(users_name, square_num, user_birth_year);



    }
}