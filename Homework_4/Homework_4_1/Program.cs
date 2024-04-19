namespace Homework_4_1
{
    class Program
    {
        
        // Напишіть програму, яка «запитуватиме» правильний пароль, доки він не буде введений.
        // Правильний пароль нехай буде "root". Якщо пароль неправильний, програма повинна сказати "Неправильний пароль!"
        
        static void Main(string[] args)
        {
            string password;
            do
            {
                Console.Write("Enter your password: ");
                password = Console.ReadLine();
                Console.WriteLine(password == "root" ? "Welcome!" : "Wrong password!");
            } while (password != "root");
        }
    }
}