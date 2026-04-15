using System;

// S - Single Responsibility
class Report
{
    public string GetContent()
    {
        return "Report Data";
    }
}

// I - Interface Segregation
interface IPrinter
{
    void Print(string content);
}

// D - Dependency Inversion
class ConsolePrinter : IPrinter
{
    public void Print(string content)
    {
        Console.WriteLine(content);
    }
}

// O - Open/Closed & L - Liskov
class PDFPrinter : IPrinter
{
    public void Print(string content)
    {
        Console.WriteLine("Printing PDF: " + content);
    }
}

class Program
{
    static void Main()
    {
        Report report = new Report();

        IPrinter printer = new ConsolePrinter(); // can switch to PDFPrinter
        printer.Print(report.GetContent());
    }
}