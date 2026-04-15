using System;

class Program
{
    static void Main()
    {
        try
        {
            Console.Write("Enter first number: ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter second number: ");
            int b = Convert.ToInt32(Console.ReadLine());

            if (b == 0)
                throw new DivideByZeroException("Cannot divide by zero!");

            int result = a / b;

            Console.WriteLine("Result: " + result);
        }
        catch (FormatException)
        {
            Console.WriteLine("Invalid input! Please enter numbers only.");
        }
        catch (DivideByZeroException ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
        catch (Exception ex)
        {
            Console.WriteLine("General Error: " + ex.Message);
        }
        finally
        {
            Console.WriteLine("Program executed successfully (finally block).");
        }
    }
}