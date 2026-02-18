using System;

public class Program
{
    static void Main(string[] args)
    {
        Assignment assignment = new("Jeff", "programming");
        MathAssignment math = new("Jeff", "fractions", "1.7", "10-20");
        Console.WriteLine(math.GetSummary());
        Console.WriteLine(math.GetHomeworkList());
        WritingAssignment writing = new("Jeff", "inheritance", "Inheritance and it's purpose");
        Console.WriteLine(writing.GetSummary());
        Console.WriteLine(writing.GetWritingInformation());
    }
}