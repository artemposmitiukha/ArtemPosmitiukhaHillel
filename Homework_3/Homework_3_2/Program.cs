﻿namespace Homework_3_2
{
    class Program
    {
        
        /*
         Написати програму, в якій користувач вводить номер місяця.
         Якщо місяць 1,2,12 відображає "Зима"; 3,4,5 - «Весна»; 6-8 - «Літо»; 9-11 – «Осінь».
         У будь-якому іншому випадку - "Немає такого місяця на цій планеті" .
        */
        
        static void Main(string[] args)
        {
            Console.Write("Enter your month: ");
            int monthInput = int.Parse(Console.ReadLine());
            switch (monthInput)
            {
                case 1: case 2: case 12:
                    Console.WriteLine("Winter");
                    break;
                
                case 3: case 4: case 5:
                    Console.WriteLine("Spring");
                    break;
                
                case 6: case 7: case 8:
                    Console.WriteLine("Summer");
                    break;
                
                case 9: case 10: case 11:
                    Console.WriteLine("Autumn"); 
                    break;
                
                default:
                    Console.WriteLine("There is no such month");
                    break;
            }
        }
    }
}