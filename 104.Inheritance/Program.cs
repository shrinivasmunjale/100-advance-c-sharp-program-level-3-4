using System;

class Animal
{
    public void eat()
    {
        Console.WriteLine("Animal is eating");
    }
}

class Dog : Animal
{
    public void bark()
    {
        Console.WriteLine("Dog is barking");
    }
}

class Program
{
    static void Main()
    {
        Dog d = new Dog();
        d.eat();   // inherited method
        d.bark();  // own method
    }
}