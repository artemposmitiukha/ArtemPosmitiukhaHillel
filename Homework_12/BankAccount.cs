using System.Reflection.Emit;

namespace Homework_12;

public abstract class BankAccount
{
    protected private int accountNumber { get; set; }
    protected string accountHolder { get; set; }
    protected double balance { get; set; }
     
    public BankAccount(string name, double balance)
    {
        accountHolder = name;
        accountNumber = GenerateNum();
        this.balance = balance;
    }

    static int GenerateNum()
    {
        Random random = new Random();
        string stringNumber = "";
        int number;
        for (int i = 0; i < random.Next(7, 10); i++)
        {
            stringNumber += random.Next(10).ToString();
        }
        return number = int.Parse(stringNumber);
    }

    public abstract void Deposit(double amount);
    public abstract void Withdraw(double amount);
    public abstract void DisplayInfo();
}