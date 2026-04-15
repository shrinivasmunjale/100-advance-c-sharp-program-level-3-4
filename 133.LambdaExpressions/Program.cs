using System;

class Program
{
    static void Main()
    {
        Func<int, int> square = x => x * x;

        Console.WriteLine("Square of 5: " + square(5));
    }
}