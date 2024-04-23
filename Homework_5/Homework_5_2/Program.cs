using System.Security.AccessControl;

namespace Homework_5_2
{
    class Program
    {
        
        // Написати програму для інверсії масиву, тобто перевороту його у зворотному порядку.
        // В цьому завданні недостатньо просто вивести елементи масиву у зворотному порядку. 


        
        static void Main(string[] args)
        {
            Random random = new Random();
            Console.Write("Enter array length: ");
            int[] myArray = new int[int.Parse(Console.ReadLine())], reversedArray = new int[myArray.Length];
            for (int i = 0; i < myArray.Length; i++)
            {
                myArray[i] = random.Next(-100, 100);
                reversedArray[myArray.Length - i - 1] = myArray[i];
            }
            
            Console.WriteLine("Initial array: " + string.Join(" | ", myArray) + 
                              "\nReversed array: " + string.Join(" | ", reversedArray));
            /*
            Array.Reverse(myArray);
            Console.WriteLine("Reversed array: " + string.Join(" | ", myArray));
            */

        }
    }
}