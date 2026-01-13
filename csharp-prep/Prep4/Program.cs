using System;

class Program
{
    static void Main(string[] args)
    {
        List<int> user_list = [];
        while (true)
        {
            Console.WriteLine("Enter a list of numbers, type 0 when finished.");
            Console.Write("Enter number: ");
            int list_num = int.Parse(Console.ReadLine());
            if (list_num == 0)
            {
                break;
            }
            user_list.Add(list_num);
        }

        int sum = 0;
        double average = 0;
        int largest_num = 0;

        foreach (int num in user_list)
        {
            sum += num;
        }

        foreach (int num in user_list)
        {
            average += num;
        }
        average = average/user_list.Count();

        foreach (int num in user_list)
        {
            if (num > largest_num)
            {
            largest_num = num;
            }
        }


        Console.WriteLine($"The sum is: {sum}");

        Console.WriteLine($"The average is: {average}");

        Console.WriteLine($"The largest number is:  {largest_num}");

    }
}