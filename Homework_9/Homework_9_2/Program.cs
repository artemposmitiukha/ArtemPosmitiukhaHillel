using System.Text;

namespace Homework_9_2
{
    class Program
    {
        static int GetDate(string input, int max, int min)
        {
            int value;
            do
            {
                Console.Write(input);
            } while ((!int.TryParse(Console.ReadLine(), out value)) || value > max || value < min);

            return value;
        }

        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();
            int day = GetDate("Enter your day(1-31): ", 31, 1);
            int month = GetDate("Enter your month(1-12): ", 12, 1);
            int year = GetDate("Enter your year(1-2024): ", 2024, 1);

            Console.WriteLine(sb.Append($"{day}-{month}-{year}"));

        }
    }
}