using System;

class Program
{
    public delegate void MyDelegate();

    static void Method1()
    {
        Console.WriteLine("Method 1 called");
    }

    static void Method2()
    {
        Console.WriteLine("Method 2 called");
    }

    static void Main()
    {
        MyDelegate del;

        del = Method1;
        del += Method2;   // Adding second method

        del(); // Calls both methods
    }
}