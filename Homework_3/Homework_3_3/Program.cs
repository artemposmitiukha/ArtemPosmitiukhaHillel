using System.Threading.Channels;

namespace Homework_3_3
{
    class Program
    {
        /*
         Напишіть програму, яка приймає від користувача число від 1 до 100.
         При цьому якщо число кратне трьом, програма повинна виводити слово Fizz, а якщо кратно п'яти - слово Buzz.
         Якщо число кратно п'ятнадцяти, програма повинна виводити слово FizzBuzz. З
         авдання може здатися очевидним, але потрібно отримати найбільш просте та красиве рішення.
        */
        
        static void Main(string[] args)
        {
            Console.Write("Write the number from 0 to 100: ");
            byte num = byte.Parse(Console.ReadLine());
            if (num <= 100 && num >= 0)
            {
                Console.WriteLine(num % 3 == 0 ? "Fizz" : 
                                  num % 5 == 0 ? "Buzz" : 
                                  num % 15 == 0 ? "FizzBuzz" : "You lose!");
            }
            else
                Console.WriteLine("Number is out of range!");
            
        }
            
    }
}