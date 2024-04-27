namespace Homework_6
{
    class Program
    {
        static void DisplayMenu()
        {
            
            Console.WriteLine("\nMenu:");
            Console.WriteLine("1. Show Math Marks");
            Console.WriteLine("2. Show History Marks");
            Console.WriteLine("3. Show English Marks");
            Console.WriteLine("4. Show Geography Marks");
            Console.WriteLine("5. Show Ukrainian Marks");
            Console.WriteLine("6. Clear");
            Console.WriteLine("7. Exit");
            Console.WriteLine("\nEnter your index:");
        }

        static void DisplaySubmenu(int choice, ref int[] subject)
        {
            
            Console.WriteLine("1. Calculate average \n2. Add mark \n3. Back \nEnter your choice:");
            int submenuChoice = int.Parse(Console.ReadLine());
            string subjectChoice = choice == 1?"Math":choice == 2?"History":choice == 3?"English":choice == 4?"Geography":"Ukrainian";
            switch (submenuChoice)
            {
                case 1:
                    double calculationResult = Math.Round((double)subject.Sum() / subject.Length, 1);
                    Console.Clear();
                    Console.WriteLine($"Average mark: {calculationResult}\nSubject: {subjectChoice}");
                    break;
                case 2:
                    AddMark(ref subject, choice);
                    break;
                case 3:
                    Console.Clear();
                    break;
                default:
                    Console.WriteLine("Invalid choice.");
                    break;
            }
        }

        static void AddMark(ref int[] marks, int choice)
        {
            Console.Write("Enter your mark: ");
            string subjectChoice = choice == 1?"Math":choice == 2?"History":choice == 3?"English":choice == 4?"Geography":"Ukrainian";
            int newMark = int.Parse(Console.ReadLine());
            if (newMark <= 12 && newMark >= 1)
            {
                Array.Resize(ref marks, marks.Length + 1);
                marks[marks.Length - 1] = newMark;
                Console.Clear();
                Console.WriteLine($"Mark added: {newMark}\nSubject: {subjectChoice}");
                
            }
            else
                Console.WriteLine("Enter number between 1 and 12!");   
        }

        static void InitializeData(ref int[] marksUkrainian, ref int[] marksGeography,
            ref int[] marksEnglish, ref int[] marksHistory, ref int[] marksMath)
        {
            Random random = new Random();

            int[][] marks = { marksEnglish, marksGeography, marksUkrainian, marksMath, marksHistory };
            for (int i = 0; i < marks.Length; i++)
            {
                for (int mark = 0; mark < marks[i].Length; mark++)
                {
                    marks[i][mark] = random.Next(5, 12);
                }
            }
        }

        static void Main(string[] args)
        {
            Random random = new Random();
            int[] marksMath = new int[random.Next(5, 10)],
                marksHistory = new int[random.Next(5, 10)],
                marksEnglish = new int[random.Next(5, 10)],
                marksGeography = new int[random.Next(5, 10)],
                marksUkrainian = new int[random.Next(5, 10)];
            InitializeData(ref marksUkrainian, ref marksGeography, ref marksEnglish, ref marksHistory, ref marksMath);
            while (true)
            {
                DisplayMenu();
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1: Console.WriteLine(string.Join(" | ", marksMath));
                            DisplaySubmenu(choice, ref marksMath);
                            break;
                    
                    case 2: Console.WriteLine(string.Join(" | ", marksHistory));
                            DisplaySubmenu(choice, ref marksHistory);
                            break;
                    
                    case 3: Console.WriteLine(string.Join(" | ", marksEnglish));
                            DisplaySubmenu(choice, ref marksEnglish);
                            break;
                    
                    case 4: Console.WriteLine(string.Join(" | ", marksGeography));
                            DisplaySubmenu(choice, ref marksGeography);
                            break;
                    
                    case 5: Console.WriteLine(string.Join(" | ", marksUkrainian));
                            DisplaySubmenu(choice, ref marksUkrainian);
                            break;
                    
                    case 6: Console.Clear();
                            break;
                    
                    case 7: Console.WriteLine("Goodbye!");
                            return;
                    
                    default: Console.Clear();
                             Console.WriteLine("Invalid choice.");
                             break;
                }
            }
        }
    }
}
