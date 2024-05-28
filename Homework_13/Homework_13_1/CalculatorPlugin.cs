namespace Homework_13_1;

public class CalculatorPlugin : IPlugin
{
    public void Execute()
    {
        Console.WriteLine("Simple calculation: " + (5 + 10));
    }
    
}