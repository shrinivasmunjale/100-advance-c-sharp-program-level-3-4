using System;
using System.Reflection;

class Program
{
    static void Main()
    {
        Type t = typeof(Student);

        Console.WriteLine("Class Name: " + t.Name);

        Console.WriteLine("\nProperties:");
        foreach (var prop in t.GetProperties())
        {
            Console.WriteLine(prop.Name);
        }

        Console.WriteLine("\nMethods:");
        foreach (var method in t.GetMethods())
        {
            Console.WriteLine(method.Name);
        }
    }
}

class Student
{
    public string Name { get; set; }
    public int Age { get; set; }

    public void Show()
    {
        Console.WriteLine("Student Info");
    }
}