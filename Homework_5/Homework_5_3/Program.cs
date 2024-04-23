namespace Homework_5_3
{
    class Program
    {
        
        // Потрібно додати до масиву елемент на початок. Нехай масив буде на 10 елементів.
        // Масив заповнити рандомними числами. Той елемент, що потрібно додати, також взяти рандомно. 
        
        static void Main(string[] args)
        {
            /*
            Random random = new Random();
            Console.Write("Enter array length: ");
            int[] myArray = new int[int.Parse(Console.ReadLine())];
            for (int i = 0; i < myArray.Length; i++)
                myArray[i] = random.Next(-100, 100);
            Console.WriteLine("Initial array: " + string.Join(" | ", myArray));

            int[] bufferArray = new int[myArray.Length + 1];
            bufferArray[0] = int.Parse(Console.ReadLine());
            Array.Copy(myArray, 0, bufferArray, 1, myArray.Length);

            Console.WriteLine("Array with new first element: " + string.Join(" | ", bufferArray));
            */
            
            Random random = new Random(); 
            Console.Write("Enter array length: "); 
            int[] myArray = new int[int.Parse(Console.ReadLine())]; 
            
            for (int i = 0; i < myArray.Length; i++)
                myArray[i] = random.Next(-100, 100);
            Console.WriteLine("Initial array: " + string.Join(" | ", myArray));
            
            Console.Write("Enter new first element: ");
            int newFirstElement = int.Parse(Console.ReadLine());
            
            ArrayChange(ref myArray, newFirstElement);
            
            Console.WriteLine("Array with new first element: " + string.Join(" | ", myArray));
        }
        static void ArrayChange(ref int[] array, int newFirstElement)
        {
            int[] bufferArray = new int[array.Length + 1];
            bufferArray[0] = newFirstElement;
            
            for (int i = 1; i < bufferArray.Length; i++)
                bufferArray[i] = array[i - 1];
            
            bufferArray[array.Length] = array[array.Length - 1];
            array = bufferArray;
        } 
    }
}