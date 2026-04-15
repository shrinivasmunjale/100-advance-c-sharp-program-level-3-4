using System;

class Program
{
    static void Main()
    {
        GenericClass<int> obj1 = new GenericClass<int>();
        obj1.Show(10);

        GenericClass<string> obj2 = new GenericClass<string>();
        obj2.Show("Hello Generics");
    }
}

// Generic class
class GenericClass<T>
{
    public void Show(T data)
    {
        Console.WriteLine("Data: " + data);
    }
}