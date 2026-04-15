using System;
using System.Collections;

class Program
{
    static void Main()
    {
        ArrayList list = new ArrayList();

        // Adding different types
        list.Add(10);
        list.Add("Hello");
        list.Add(3.14);
        list.Add(true);

        Console.WriteLine("ArrayList Elements:");

        foreach (var item in list)
        {
            Console.WriteLine(item);
        }

        // Remove element
        list.Remove("Hello");

        Console.WriteLine("\nAfter Removing 'Hello':");
        foreach (var item in list)
        {
            Console.WriteLine(item);
        }
    }
}