using System;

// Custom Attribute
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Method)]
class MyAttribute : Attribute
{
    public string Message { get; }

    public MyAttribute(string message)
    {
        Message = message;
    }
}

// Applying Attribute
[MyAttribute("This is a sample class")]
class Demo
{
    [MyAttribute("This is a sample method")]
    public void Show()
    {
        Console.WriteLine("Hello from method");
    }
}

class Program
{
    static void Main()
    {
        Type t = typeof(Demo);

        // Get class attribute
        var classAttr = (MyAttribute)Attribute.GetCustomAttribute(t, typeof(MyAttribute));
        Console.WriteLine("Class Attribute: " + classAttr.Message);

        // Get method attribute
        var method = t.GetMethod("Show");
        var methodAttr = (MyAttribute)Attribute.GetCustomAttribute(method, typeof(MyAttribute));
        Console.WriteLine("Method Attribute: " + methodAttr.Message);
    }
}