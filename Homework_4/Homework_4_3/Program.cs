namespace Homework_4_3
{
    class Program
    {
        
        // Доробити таблицю множення - зробити гарний вивід в консоль.  
        
        static void Main(string[] args)
        {
            /*for (int i = 1; i <= 10; i++)
            {
                for (int j = 1; j <= 10; j++)
                {
                    i = 1;
                    while (i <= 10)
                    {
                        Console.Write($"{i} * {j} = {i * j}\t\t");
                        i++;
                    }
                    Console.WriteLine();
                }
            }*/
            int i;
            for (int j = 1; j <= 10; j++)
            {
                i = 1;
                while (i <= 10)
                {
                    Console.Write($"{i} * {j} = {i * j}\t\t");
                    i++;
                }
                Console.WriteLine();
            }


        }
    }
}