using System;

static class MathUtility
{
    public static int Square(int x)
    {
        return x * x;
    }

    public static int Cube(int x)
    {
        return x * x * x;
    }
}

class Program
{
    static void Main()
    {
        Console.WriteLine("Square: " + MathUtility.Square(5));
        Console.WriteLine("Cube: " + MathUtility.Cube(3));
    }
}