using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Func: takes 2 inputs, returns result
        Func<int, int, int> add = (a, b) => a + b;
        Console.WriteLine("Sum: " + add(5, 3));

        // Action: performs action, no return
        Action<string> greet = name => Console.WriteLine("Hello " + name);
        greet("Shree");

        // Predicate: returns true/false
        Predicate<int> isEven = x => x % 2 == 0;
        Console.WriteLine("Is 4 even? " + isEven(4));
    }
}