using System;

class Program
{
    // Step 1: Declare delegate
    public delegate void MyDelegate(string msg);

    static void ShowMessage(string message)
    {
        Console.WriteLine("Message: " + message);
    }

    static void Main()
    {
        // Step 2: Assign method to delegate
        MyDelegate del = ShowMessage;

        // Step 3: Invoke delegate
        del("Hello Delegates!");
    }
}