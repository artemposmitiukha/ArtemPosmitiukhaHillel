namespace Homework_2_5
{
    class Program
    {
        // Користувач вводить радіус круга. Напишіть програму, яка обчислює площу цього круга і виводить в консоль результат. 
        
        static void Main(string[] args)
        {
            Console.Write("Enter circle radius: ");
            double square = Math.Round(Math.PI * Math.Pow(int.Parse(Console.ReadLine()), 2), 1);
            Console.WriteLine("Circle area: " + square);
        }
    }
}