using System;

class Program
{
    static void Main()
    {
        Publisher p = new Publisher();

        // Subscribe to event
        p.MyEvent += Subscriber1;
        p.MyEvent += Subscriber2;

        // Trigger event
        p.RaiseEvent();
    }

    static void Subscriber1()
    {
        Console.WriteLine("Subscriber 1 received event");
    }

    static void Subscriber2()
    {
        Console.WriteLine("Subscriber 2 received event");
    }
}

class Publisher
{
    // Step 1: Declare delegate
    public delegate void MyDelegate();

    // Step 2: Declare event
    public event MyDelegate MyEvent;

    public void RaiseEvent()
    {
        if (MyEvent != null)
        {
            MyEvent(); // Trigger event
        }
    }
}