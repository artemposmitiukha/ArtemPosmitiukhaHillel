using System.Runtime.CompilerServices;

namespace Homework_9_1
{
    class Program
    {
        static void Main(string[] args)
        {
            void PrintPerson(Person person)
            {
                person.PrintDetails();
                Console.WriteLine("Is adult: " + person.isAdult());
                person.ChangeName();
                Console.WriteLine();
            }

            string GenderChoice()
            {
                string gender;
                Console.Write("Enter your gender(male, female, other): ");
                switch (Console.ReadLine().ToLower())
                {
                    case ("male"):
                        gender = Person.Gender.Male.ToString();
                        break;
                    case ("female") :
                        gender = Person.Gender.Female.ToString();
                        break;
                    default:
                        gender = Person.Gender.Other.ToString();
                        break;
                }
                return gender;
            }

            Console.Write("Enter name: ");
            string name1 = Console.ReadLine();
            int age1;
            do
                Console.Write("Enter age: ");
            while (!int.TryParse(Console.ReadLine(), out age1));
            string gender1 = GenderChoice();

            Person person1 = new Person(name1, age1, gender1);
            PrintPerson(person1);

            Console.Write("Enter name: ");
            string name2 = Console.ReadLine();
            Person person2 = new Person(name2);
            PrintPerson(person2);

            Console.Write("Enter name: ");
            string name3 = Console.ReadLine();

            int age3;
            do
                Console.Write("Enter age: ");
            while (!int.TryParse(Console.ReadLine(), out age3));

            Person person3 = new Person(name3, age3);
            PrintPerson(person3);
        }
    }
}
