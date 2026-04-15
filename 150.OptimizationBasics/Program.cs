using System;
using System.Diagnostics;
using System. Text;

class Program
{
    static void Main()
    {
        //using string (slow)
        Stopwatch sw1 = Stopwatch.StartNew();
        string str = "";
        for (int i = 0; i < 10000; i++)
        {
            str += i;
        }
        sw1.Stop();
        Console.WriteLine("Time with string: " + sw1.ElapsedMilliseconds + " ms");

        // Using StringBuilder (fast)
        Stopwatch sw2 = Stopwatch.StartNew();
        StringBuilder sb = new StringBuilder();
        for (int i = 0; i < 10000; i++)
        {
            sb.Append(i);
        }
        sw2.Stop();
        Console.WriteLine("Time with StringBuilder: " + sw2.ElapsedMilliseconds + " ms");
    }
}