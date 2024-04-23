using System.Globalization;
using Microsoft.VisualBasic;

namespace Homework_5_4
{
    class Program
    {
        
        //  Написати програму, яка виводить всі елементи масиву доки не зустрінеться елемент -1.
        // Масив заповнити рандомними числами, діапазон чисел від -5 до 5. 
        
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