using System;

class Company
{
    public const string CompanyName = "TechSoft";
    public readonly DateTime JoiningDate;

    public Company(DateTime data)
    {
        JoiningDate = data;
    }
    public void Display()
    {
        Console.WriteLine("Company:"+CompanyName);
        Console.WriteLine("Joining Date:" + JoiningDate);

    }
}
class Program
{
    static void Main()
    {
        Company emp1 = new Company(new DateTime(2025, 5, 10));
        Company emp2 = new Company(new DateTime(2025, 1, 15));

        emp1.Display();
        emp2.Display();

    
    }
}