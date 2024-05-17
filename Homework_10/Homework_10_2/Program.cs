namespace  Homework_10_2;

class Program
{
    static void Main(string[] args)
    {
        double age;
        while (true)
        {
            try
            {
                Console.Write("Enter your age: ");
                age = double.Parse(Console.ReadLine());
                if (age > 0 && (age % 1 == 0))
                {
                    Console.WriteLine("Your age: " + age);
                    break;
                }
                else
                    throw new FormatException("Invalid age!");
            }
            catch (FormatException)
            {
                Console.WriteLine("Your age in the wrong format!");
            }
        }
    }
}