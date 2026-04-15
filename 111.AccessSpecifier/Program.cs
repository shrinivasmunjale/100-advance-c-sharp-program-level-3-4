using System;

class BaseClass
{
    public int publicVar = 1;
    private int privateVar = 2;
    protected int protectedVar = 3;
    internal int internalVar = 4;
    protected internal int protectedInternalVar = 5;

    public void ShowBase()
    {
        Console.WriteLine("Inside Base Class:");
        Console.WriteLine(publicVar);
        Console.WriteLine(privateVar);
        Console.WriteLine(protectedVar);
        Console.WriteLine(internalVar);
        Console.WriteLine(protectedInternalVar);
    }
}

class DerivedClass : BaseClass
{
    public void ShowDerived()
    {
        Console.WriteLine("Inside Derived Class:");
        Console.WriteLine(publicVar);
        // Console.WriteLine(privateVar); // Not accessible
        Console.WriteLine(protectedVar);
        Console.WriteLine(internalVar);
        Console.WriteLine(protectedInternalVar);
    }
}

class Program
{
    static void Main()
    {
        BaseClass obj1 = new BaseClass();
        obj1.ShowBase();

        DerivedClass obj2 = new DerivedClass();
        obj2.ShowDerived();

        Console.WriteLine("Access from Main:");
        Console.WriteLine(obj1.publicVar);
        // Console.WriteLine(obj1.privateVar); // Not accessible
        // Console.WriteLine(obj1.protectedVar); // Not accessible
        Console.WriteLine(obj1.internalVar);
        Console.WriteLine(obj1.protectedInternalVar);
    }
}