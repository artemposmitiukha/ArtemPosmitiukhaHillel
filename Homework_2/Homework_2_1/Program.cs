namespace Homework_2
{
    class Program
    {
        // Дано тризначне число. Знайти число, отримане під час прочитання його цифр справа наліво.
        static void Main(string[] args)
        {
            int initialNum = int.Parse(Console.ReadLine());
            int resultNum = (initialNum % 10) * 100 + (initialNum / 10 % 10) * 10 + initialNum / 100;
            Console.WriteLine(resultNum);
        }
    }
}