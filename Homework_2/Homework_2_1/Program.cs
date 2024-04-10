namespace Homework_2_1
{
    class Program
    {
        // Дано тризначне число. Знайти число, отримане під час прочитання його цифр справа наліво.
        
        static void Main(string[] args)
        {
            int initialNum = 493;
            Console.WriteLine("Initial number: " + initialNum);
            
            int reversedNum = (initialNum % 10) * 100 + (initialNum / 10 % 10) * 10 + initialNum / 100;
            Console.WriteLine("Reversed number: " + reversedNum);
                
        }
    }
}