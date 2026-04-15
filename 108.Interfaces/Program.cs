using System;
using System.Runtime.InteropServices.Marshalling;

// Interface
interface IAnimal
{
    void Sound();
}
//Implementing Interface
class Dog: IAnimal
{
    public void Sound()
    {
        Console.WriteLine("Dog barks");
    }
}

class Program
{
    static void Main()
    {
        IAnimal dog = new Dog();
        dog.Sound();
    }
}