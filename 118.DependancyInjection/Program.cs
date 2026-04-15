using System;

// Service interface
interface IMessageService
{
    void SendMessage(string msg);
}

// Email service
class EmailService : IMessageService
{
    public void SendMessage(string msg)
    {
        Console.WriteLine("Email: " + msg);
    }
}

// Client class
class Notification
{
    private IMessageService service;

    // Constructor Injection
    public Notification(IMessageService service)
    {
        this.service = service;
    }

    public void Notify(string msg)
    {
        service.SendMessage(msg);
    }
}

class Program
{
    static void Main()
    {
        IMessageService service = new EmailService();
        Notification notify = new Notification(service);

        notify.Notify("Hello User!");
    }
}