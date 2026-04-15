using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Dictionary<int, string> students = new Dictionary<int, string>();

        // Adding elements
        students.Add(1, "shri");
        students.Add(2, "Ravi");
        students.Add(3, "Manvi");

        Console.WriteLine("Student List:");

        foreach (KeyValuePair<int, string> s in students)
        {
            Console.WriteLine("ID: " + s.Key + ", Name: " + s.Value);
        }

        // Access by key
        Console.WriteLine("\nStudent with ID 2: " + students[2]);

        // Remove element
        students.Remove(3);

        Console.WriteLine("\nAfter Removing ID 3:");
        foreach (var s in students)
        {
            Console.WriteLine(s.Key + " - " + s.Value);
        }
    }
}