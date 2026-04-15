using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<int> numbers = new List<int>();

        // Adding elements
        numbers.Add(10);
        numbers.Add(20);
        numbers.Add(30);

        Console.WriteLine("List Elements:");
        foreach (int num in numbers)
        {
            Console.WriteLine(num);
        }

        // Remove element
        numbers.Remove(20);

        Console.WriteLine("\nAfter Removing 20:");
        foreach (int num in numbers)
        {
            Console.WriteLine(num);
        }
    }
}