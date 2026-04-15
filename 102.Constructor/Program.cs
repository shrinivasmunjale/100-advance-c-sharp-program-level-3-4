using System;

class Student
{
    string name;

    // Constructor
    public Student(string n)
    {
        name = n;
    }

    public void display()
    {
        Console.WriteLine("Student Name: " + name);
    }
}

class Program
{
    static void Main()
    {
        Student s1 = new Student("Shri");  // Constructor called
        s1.display();
    }
}