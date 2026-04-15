using System;
using System.Linq;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        var students = new List<Student>()
        {
            new Student { Id = 1, Name = "Amit" },
            new Student { Id = 2, Name = "Neha" },
            new Student { Id = 3, Name = "Rahul" }
        };

        var marks = new List<Marks>()
        {
            new Marks { StudentId = 1, Score = 85 },
            new Marks { StudentId = 2, Score = 90 },
            new Marks { StudentId = 3, Score = 75 }
        };

        var result = students.Join(
                        marks,
                        s => s.Id,
                        m => m.StudentId,
                        (s, m) => new { s.Name, m.Score });

        foreach (var item in result)
        {
            Console.WriteLine(item.Name + " - " + item.Score);
        }
    }
}

class Student
{
    public int Id { get; set; }
    public string Name { get; set; }
}

class Marks
{
    public int StudentId { get; set; }
    public int Score { get; set; }
}