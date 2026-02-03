using System;


class Program
{
    static void Main(string[] args)
    {
        Random rnd = new Random();
        //Fraction top_fraction = new Fraction(5);
        //Fraction full_fraction = new Fraction(1,3);
        //full_fraction.DisplayFraction();
        //top_fraction.DisplayFraction();
        //full_fraction.DisplayFraction();
        //top_fraction.SetTop(9);
        //Console.WriteLine(top_fraction.GetTop());
        //Console.WriteLine(full_fraction.GetDecimalValue());
        for(int i = 1; i < 21; i++)
        {
            Fraction new_fraction = new Fraction();
            int top_num = rnd.Next(100);
            int bottom_num = rnd.Next(100);
            new_fraction.SetTop(top_num);
            new_fraction.SetBottom(bottom_num);
            Console.WriteLine($"Fraction {i}: string: {new_fraction.DisplayFraction()} Number: {Math.Round(new_fraction.GetDecimalValue(),3)}");
        }
    } 
}