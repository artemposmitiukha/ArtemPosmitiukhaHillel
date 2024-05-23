using System.Runtime.InteropServices;

namespace Homework_12;

class Program 
{
    static (string, double, double) GetInfo(string operation)
    {
        Random random = new Random();
        Console.Write("Enter account holder name: ");
        string name = Console.ReadLine();
        double balance = random.Next(1000, 10000);
        double interestRate = random.NextDouble();
        double overdraftLimit = random.Next(100, 900);
        if (operation == "SavingAccount")
            return (name, balance, interestRate);
        else
            return (name, balance, overdraftLimit);
            
    }
    static void Main(string[] args)
    {
        Random random = new Random();
        (string name, double balance, double interestRate) = GetInfo("SavingsAccount");
        BankAccount sa = new SavingsAccount(name, balance, interestRate);
        (string name1, double balance1, double overdraftLimit) = GetInfo("ChekingAccount");
        BankAccount ca = new ChekingAccount(name1, balance1, overdraftLimit);
        
        sa.Deposit(random.Next(100, 600));
        sa.Withdraw(random.Next(100, 800));
        sa.DisplayInfo();

        Console.WriteLine("--------------------------------");
        
        ca.Deposit(random.Next(100, 500));
        ca.Withdraw(random.Next(100, 700)); 
        ca.DisplayInfo();
    }
}