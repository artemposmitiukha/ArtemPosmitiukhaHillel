namespace Homework_4_2
{
    class Program
    {
        
        // Програма загадує число від 1 до 146 (привіт, Random). Користувач намагається вгадати його.
        // У разі неправильної відповіді програма підказує «більше» або «менше»
        
        static void Main(string[] args)
        {
            byte randomNum = (byte) new Random().Next(1, 146), playerNum;
            do
            {
                Console.Write("Guess the number from 1 to 146: ");
                playerNum = byte.Parse(Console.ReadLine());
                Console.WriteLine(playerNum == randomNum ? "You win!" : 
                                  playerNum > randomNum ? "Your num is bigger" : "Your num is smaller");
            } while (randomNum != playerNum);
        }
    }
}