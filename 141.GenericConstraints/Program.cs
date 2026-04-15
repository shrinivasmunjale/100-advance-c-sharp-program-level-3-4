using System;

// Constraint: only reference types allowed
class GenericClass<T> where T : class
{
    public void Show(T data)
    {
        Console.WriteLine("Data: " + data);
    }
}

class Program
{
    static void Main()
    {
        GenericClass<string> obj = new GenericClass<string>();
        obj.Show("Constraint Example");

    }
}