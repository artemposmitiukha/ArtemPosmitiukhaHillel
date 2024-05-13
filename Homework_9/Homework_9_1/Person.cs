using System.Runtime.CompilerServices;

namespace Homework_9_1
{
    public class Person
    {
        public enum Gender { Male, Female, Other }

        private string name { get; set; }
        private int age { get; set; }
        private string gender { get; set; }

        public Person(string name, int age = 0, string gender = "Other")
        {
            this.name = name;
            this.age = age;
            this.gender = gender;
        }
        public Person(string name)
        {
            this.name = name;
            this.age = 0;
            this.gender = Gender.Other.ToString();
        }
        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
            this.gender = Gender.Other.ToString();
        }

        public void PrintDetails()
        {
            Console.WriteLine($"Name: {name}\nAge: {age}\nGender: {gender}");
        }

        public bool isAdult() => age >= 18;

        public void ChangeName()
        {
            Console.WriteLine("Previous name: " + name);
            Console.Write("Enter new name: ");
            name = Console.ReadLine();
            Console.WriteLine("New name: " + name);
        }
    }
}