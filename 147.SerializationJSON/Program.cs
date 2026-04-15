using System;
using System.Text.Json;

class Program
{
    static void Main()
    {
        Student s = new Student { Name = "Amit", Age = 20 };

        // Serialize object to JSON
        string json = JsonSerializer.Serialize(s);
        Console.WriteLine("JSON: " + json);

        // Deserialize JSON to object
        Student newStudent = JsonSerializer.Deserialize<Student>(json);
        Console.WriteLine("Name: " + newStudent.Name);
    }
}

class Student
{
    public string Name { get; set; }
    public int Age { get; set; }
}