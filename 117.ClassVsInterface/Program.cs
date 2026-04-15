using System;

// Abstract class
abstract class Vehicle
{
    public abstract void Start();

    public void Stop()
    {
        Console.WriteLine("Vehicle stopped");
    }
}

// Interface
interface IFuel
{
    void FillFuel();
}

// Class using both
class Car : Vehicle, IFuel
{
    public override void Start()
    {
        Console.WriteLine("Car started");
    }

    public void FillFuel()
    {
        Console.WriteLine("Fuel filled");
    }
}

class Program
{
    static void Main()
    {
        Car c = new Car();
        c.Start();
        c.FillFuel();
        c.Stop();
    }
}