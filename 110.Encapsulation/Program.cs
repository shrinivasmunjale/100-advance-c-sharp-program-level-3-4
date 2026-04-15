using System;

class BankAccount
{
    private double balance;

    //public method to set balance
    public void Deposit(double amount)
    {
        if(amount > 0)
        balance +=amount;
    }

    //public method to get balance
    public double GetBalance()
    {
        return balance;
    }
}
class Program
{
    static void Main()
    {
        BankAccount account = new BankAccount();
        account.Deposit(5000);
        Console.WriteLine("Current Balance: " + account.GetBalance());
    }
}