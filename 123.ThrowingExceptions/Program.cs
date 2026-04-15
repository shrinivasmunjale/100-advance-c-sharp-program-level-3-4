using System;

class Program
{
    static void ValidateNumber(int num)
    {
        if (num < 0)
        {
            throw new Exception("Number cannot be negative!");
        }
        else
        {
            Console.WriteLine("Valid number: " + num);
        }
    }

    static void Main()
    {
        try
        {
            Console.Write("Enter a number: ");
            int num = Convert.ToInt32(Console.ReadLine());

            ValidateNumber(num);
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
    }
}