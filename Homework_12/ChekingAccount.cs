namespace Homework_12;

public class ChekingAccount : BankAccount
{ 
    double overdraftLimit { get; set; }

    public ChekingAccount(string accountHolder, double balance, double overdraftLimit) 
        : base(accountHolder, balance)
    {
        this.overdraftLimit = overdraftLimit;
    }

    public override void Deposit(double amount)
    {
        Console.WriteLine("Deposit amount: " + amount);   
        balance += amount;
    }

    public override void Withdraw(double amount)
    {
        Console.WriteLine("Withdraw amount: " + amount);   
        if (amount > balance || balance + overdraftLimit < amount)
            Console.WriteLine(amount > balance
                ? "You have exceeded your balance!"
                :  "You have exceeded overdraft limit!");

        else
            balance -= amount;
    }

    public override void DisplayInfo()
    {
        Console.WriteLine($"Account Number: {accountNumber}");
        Console.WriteLine($"Account Holder: {accountHolder}");
        Console.WriteLine($"Balance: {balance} $");
        Console.WriteLine($"Overdraft limit: {overdraftLimit}");
    }
}