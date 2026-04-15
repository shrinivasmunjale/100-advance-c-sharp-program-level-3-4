using System;

class Program
{
    public delegate void MyDelegate(int num);

    static void Main()
    {
        // Anonymous method
        MyDelegate del = delegate(int x)
        {
            Console.WriteLine("Square: " + (x * x));
        };

        del(5);
    }
}