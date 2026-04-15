using System;

// Custom Exception
class AgeException : Exception
{
    public AgeException(string message) : base(message) { }
}

class Program
{
    static void CheckAge(int age)
    {
        if (age < 18)
        {
            throw new AgeException("Age must be 18 or above!");
        }
        else
        {
            Console.WriteLine("Eligible to vote");
        }
    }

    static void Main()
    {
        try
        {
            Console.Write("Enter Age: ");
            int age = Convert.ToInt32(Console.ReadLine());

            CheckAge(age);
        }
        catch (AgeException ex)
        {
            Console.WriteLine("Custom Exception: " + ex.Message);
        }
    }
}