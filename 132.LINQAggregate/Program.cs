using System;
using System.Linq;

class Program
{
    static void Main()
    {
        int[] numbers = { 1, 2, 3, 4, 5 };

        int sum = numbers.Aggregate((a, b) => a + b);

        Console.WriteLine("Sum = " + sum);

        int product = numbers.Aggregate((a, b) => a * b);

        Console.WriteLine("Product = " + product);
    }
}