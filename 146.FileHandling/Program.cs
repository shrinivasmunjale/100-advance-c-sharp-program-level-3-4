using System;
using System.IO;

class Program
{
    static void Main()
    {
        string path = "test.txt";

        // Write to file
        File.WriteAllText(path, "Hello File Handling in C#");

        // Read from file
        string content = File.ReadAllText(path);

        Console.WriteLine("File Content:");
        Console.WriteLine(content);
    }
}