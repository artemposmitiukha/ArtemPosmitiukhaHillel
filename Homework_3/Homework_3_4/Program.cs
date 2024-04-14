namespace Homework_3_4
{
    class Program
    {
        
        // Квадратне рівняння

        static double Discriminant(sbyte a, sbyte b, sbyte c)
        {
            return Math.Pow(b, 2) - 4 * a * c;
        }

        static void DiscriminantCheck(double discriminant)
        {
            string discriminantValue = discriminant > 0 ? "D > 0" : discriminant == 0 ? "D == 0" : "D < 0";
            Console.WriteLine(discriminantValue);
        }

        static void RootCount(double discriminant, sbyte a, sbyte b, sbyte c)
        {
            if (discriminant > 0)
            {
                double x1 = double.Round((-b + Math.Sqrt(discriminant)) / 2 * a);
                double x2 = double.Round((-b - Math.Sqrt(discriminant)) / 2 * a);
                Console.WriteLine($"The equation has two roots: \nX1: {x1}; \nX2: {x2};");
            }
            else if (discriminant == 0)
            {
                double x1 = double.Round((-b + Math.Sqrt(discriminant)) / 2 * a);
                Console.WriteLine($"The equation has one root: \nX1: {x1};");
            }
            else
                Console.WriteLine("There are no roots in the equation");
        }
        static void Main(string[] args)
        {
            Random random = new Random();
            
            sbyte a = (sbyte)random.Next(-50, 50);
            sbyte b = (sbyte)random.Next(-50, 50);
            sbyte c = (sbyte)random.Next(-50, 50);
            Console.WriteLine($"Quadratic equation: {a}x^2 + {b}x + {c} = 0");
            
            double discriminant = Discriminant(a, b, c);
            DiscriminantCheck(discriminant);
            Console.WriteLine($"Discriminant: " + discriminant);
            
            RootCount(discriminant, a, b, c);
        }
    }
}    