using System;

// Base class
class Vehicle
{
    public void Start()
    {
        Console.WriteLine("Vehicle Started");
    }
}

// Sealed class
sealed class Car : Vehicle
{
    public void Show()
    {
        Console.WriteLine("This is a Car");
    }
}

// This will give error
// class SportsCar : Car { }

class Program
{
    static void Main()
    {
        Car c = new Car();
        c.Start();
        c.Show();
    }
}