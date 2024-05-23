namespace Homework_12;

public class SavingsAccount : BankAccount
{ 
    double interestRate { get; set; }
    public SavingsAccount(string accountHolder, double balance, double interestRate) 
        : base( accountHolder, balance)
    {
        this.interestRate = interestRate;
    }

    public override void Deposit(double amount)
    {
        Console.WriteLine("Deposit amount: " + amount); 
        double interestEarned = balance * interestRate;
        balance += amount + interestEarned;
    }

    public override void Withdraw(double amount)
    {
        Console.WriteLine("Withdraw amount: " + amount);   
        if (amount <= balance)
        {
            balance -= amount;
        }
        else
        {
            Console.WriteLine("Invalid amount to winthdraw");
        }
    }

    public override void DisplayInfo() 
    {
        Console.WriteLine($"Account Number: {accountNumber}");
        Console.WriteLine($"Account Holder: {accountHolder}");
        Console.WriteLine($"Balance: {balance} $");
        Console.WriteLine($"Interest Rate: {interestRate}");
    }
}