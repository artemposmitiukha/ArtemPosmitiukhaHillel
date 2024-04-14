namespace Homework_3_1
{
    // Необхідно написати консольну програму, де користувач вводитиме з клавіатури 2 числа. Числа будуть порівнюватися з наступним 
    // виведенням в консоль результату цього порівняння (чи рівні значення, а якщо ні, яке число більше/менше).
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number 1: ");
            double num1 = double.Parse(Console.ReadLine());
            
            Console.Write("Enter number 2: ");
            double num2 = double.Parse(Console.ReadLine());
            
            Console.WriteLine(num1 == num2 ? "Numbers are equal" : 
                $"Number {(num1 > num2 ? "1" : "2")} is bigger than number {(num1 > num2 ? "2" : "1")}");
        }
    }
}