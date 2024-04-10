namespace Homework_2_6
{
    // Дослідити інші способи поміняти місцями значення двох змінних без використання тимчасової змінної та використання суми/множення. 

    
    class Program
    {   
        static void Main(string[] args)
        {
            Console.Write("Enter first number: ");
            int num1 = int.Parse(Console.ReadLine());
            
            Console.Write("Enter second number: ");
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine($"First number: {num1}, second number {num2}");
            
            (num1, num2) = (num2,num1);
            Console.WriteLine($"Swapped numbers: \nNumber_1: {num1}, \nNumber_2: {num2};");
        }
    }
}