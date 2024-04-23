namespace Homework_5_1
{
    class Program
    {
        
        // Задати масив із 10 елементів. Заповнити цей масив рандомними числами від -100 до 100.
        // Знайти кількість додатніх чисел у масиві. Вивести на екран масив і кількість порахованих чисел. 
        
        static void Main(string[] args)
        {
            byte numCount = 0;
            Random random = new Random();
            sbyte[] myArray = new sbyte [10];
            Console.Write("Your array: ");
            for (int i = 0;i < myArray.Length; i++)
            {
                myArray[i] = (sbyte)random.Next(-100, 100);
                Console.Write(myArray[i] + ", ");
                if (myArray[i] > 0)
                    numCount++;
            }
            Console.WriteLine("\nCount of positive numbers: " + numCount);
        }
    }
}