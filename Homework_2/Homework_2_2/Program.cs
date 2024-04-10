namespace Homework_2_2
{
    class Program
    {
        // Написати програму, яка обчислює квадрат будь-якого введеного числа (бажано використати Math).

        static void Main(string[] args)
        {
            Console.Write("Enter the number to square: ");
            double num = Math.Pow(double.Parse(Console.ReadLine()), 2);
            // int num = (int)Math.Pow(double.Parse(Console.ReadLine()), 2);

            Console.WriteLine("The square of your number: " + num);

        }
    }
}