using System;

// Abstract class
abstract class Shape
{
    public abstract void Draw();
}
//Derived class
class Circle: Shape
{
    public override void Draw()
    {
        Console.WriteLine("Drawing Circle");
    }
}

class Program
{
    static void Main()
    {
        Shape s = new Circle();
        s.Draw();
    }
}