using System;

abstract class Shape
{
    public abstract int GetArea();
}

class Rectangle : Shape
{
    public int Width { get; set; }
    public int Height { get; set; }

    public override int GetArea()
    {
        return Width * Height;
    }
}

class Square : Shape
{
    public int Side { get; set; }

    public override int GetArea()
    {
        return Side * Side;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Rectangle rect = new Rectangle() { Width = 5, Height = 10 };
        Console.WriteLine(rect.GetArea());

        Shape sq = new Square() { Side = 5 };
        Console.WriteLine(sq.GetArea());

        Console.ReadKey();
    }
}