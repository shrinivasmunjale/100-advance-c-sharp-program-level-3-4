using System;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        Task task1 = Task.Run(() =>
        {
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine("Task 1: " + i);
            }
        });

        Task task2 = Task.Run(() =>
        {
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine("Task 2: " + i);
            }
        });

        Task.WaitAll(task1, task2);

        Console.WriteLine("All Tasks Completed");
    }
}