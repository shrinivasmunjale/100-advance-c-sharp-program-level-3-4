using System;

class Student
{
    string name;
    int age;

    public void getData(string n, int a)
    {
        name = n;
        age = a;
    }

    public void display()
    {
        Console.WriteLine("Name: " + name);
        Console.WriteLine("Age: " + age);
    }
}

class Program
{
    static void Main()
    {
        Student s1 = new Student();   // Object creation
        s1.getData("shri", 20);        // Calling method
        s1.display();                 // Display data
    }
}