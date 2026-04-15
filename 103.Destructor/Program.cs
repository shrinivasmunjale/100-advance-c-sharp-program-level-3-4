using System;

class Demo
{
    // Constructor
    public Demo()
    {
        Console.WriteLine("Constructor Called");
    }

    // Destructor
    ~Demo()
    {
        Console.WriteLine("Destructor Called");
    }
}

class Program
{
    static void Main()
    {
        Demo obj = new Demo();
        Console.WriteLine("Program Executing");
    }
}