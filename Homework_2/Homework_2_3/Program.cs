namespace Homework_2_3;

class Program
{
    // Дано тризначне число. Знайти число, отримане під час перестановки першої та другої цифр заданого числа.
         
    static void Main(string[] args)
    {
        int initialNum = 936;
        Console.WriteLine("Initial number: " + initialNum);
            
        int reversedNum = (initialNum % 10 * 100) + (initialNum / 10 % 10) * 10 + (initialNum / 100);
        Console.WriteLine("Reversed number: " + reversedNum);
    }
}