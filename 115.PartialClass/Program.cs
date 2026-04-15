using System;

// Part 1
partial class Student
{
    public void GetData()
    {
        Console.WriteLine("Getting student data...");
    }
}

// Part 2
partial class Student
{
    public void ShowData()
    {
        Console.WriteLine("Displaying student data...");
    }
}

class Program
{
    static void Main()
    {
        Student s = new Student();
        s.GetData();
        s.ShowData();
    }
}