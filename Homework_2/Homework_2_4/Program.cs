namespace Homework_2_4
{
    class Program
    {
        // Написати програму, яка обчислює середнє арифметичне двох чисел.
        
        static void Main(string[] args)
        {
            Console.Write("Enter first number: ");
            int num1 = int.Parse(Console.ReadLine());

            Console.Write("Enter second number: ");
            int num2 = int.Parse(Console.ReadLine());

            int result = (num1 + num2) / 2;
            Console.WriteLine("Arithmetic mean: " + result);
        }
    }
}