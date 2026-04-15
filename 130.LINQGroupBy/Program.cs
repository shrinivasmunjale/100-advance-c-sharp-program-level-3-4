using System;
using System.Linq;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        var students = new List<Student>()
        {
            new Student { Name = "Shri", Dept = "IT" },
            new Student { Name = "Neha", Dept = "CS" },
            new Student { Name = "Rahul", Dept = "IT" },
            new Student { Name = "Sneha", Dept = "CS" }
        };

        var group = students.GroupBy(s => s.Dept);

        foreach (var g in group)
        {
            Console.WriteLine("Department: " + g.Key);

            foreach (var student in g)
            {
                Console.WriteLine(student.Name);
            }
        }
    }
}

class Student
{
    public string Name { get; set; }
    public string Dept { get; set; }
}