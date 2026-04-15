using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        HashSet<int> numbers = new HashSet<int>();

        numbers.Add(10);
        numbers.Add(20);
        numbers.Add(30);
        numbers.Add(20); // Duplicate value

        Console.WriteLine("HashSet Elements:");

        foreach (int num in numbers)
        {
            Console.WriteLine(num);
        }
    }
}