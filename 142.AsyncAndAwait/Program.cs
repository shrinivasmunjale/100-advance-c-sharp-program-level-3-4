using System;
using System.Threading.Tasks;

class Program
{
    static async Task Main()
    {
        Console.WriteLine("Start");

        await DoWork();

        Console.WriteLine("End");
    }

    static async Task DoWork()
    {
        Console.WriteLine("Working...");
        await Task.Delay(2000); // Simulates delay
        Console.WriteLine("Work Completed");
    }
}