using System;

class Program
{
    static void Main(string[] args)
    {
        Square square = new(5,"red");
        Rectangle rectangle = new(3,4,"blue");
        Circle circle = new(10,"yellow");
        List<Shape> shapes = [square,rectangle,circle];
        foreach (Shape shape in shapes)
        {
            Console.WriteLine($"This shape's color is {shape.GetColor()}, and their area is {Math.Round(shape.GetArea(),2)}");
        }
    }
}