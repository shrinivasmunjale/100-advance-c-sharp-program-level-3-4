using System;

class Program
{
    static void Main()
    {
        string name = "hello";
        string result = name.ToUpperCustom();

        Console.WriteLine(result);
    }
}

// Extension class
public static class MyExtensions
{
    public static string ToUpperCustom(this string str)
    {
        return str.ToUpper();
    }
}