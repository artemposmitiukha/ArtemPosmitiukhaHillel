using System.Globalization;
using Microsoft.VisualBasic;

namespace Homework_5_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int[] myArray = new int[random.Next(6, 12)];
            for (int i = 0; i < myArray.Length; i++)
                myArray[i] = random.Next(-5, 5);
            Console.WriteLine("\nInitial array: " + string.Join(" | ", myArray));
            Console.Write("Array till -1: ");
            for (int i = 0; i < myArray.Length; i++)
            {
                if(myArray[i] != -1)
                    Console.Write(" | " + myArray[i]);
                else
                    break;
            }
            
        }
    }
}