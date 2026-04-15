using System;

class Calculator
{
    public int add(int a, int b)
    {
        return a + b;
    }

    public int add(int a, int b, int c)
    {
        return a + b + c;
    }
}

class Program
{
    static void Main()
    {
        Calculator obj = new Calculator();

        Console.WriteLine("Sum of two numbers: " + obj.add(5, 10));
        Console.WriteLine("Sum of three numbers: " + obj.add(5, 10, 15));
    }
}