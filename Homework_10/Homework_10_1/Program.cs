using UkrainianStringUtils;
namespace Homework_10_1;

class Program
{
    static void Main(string[] args)
    {
        string userInput = Console.ReadLine();
        
        int vowelsCount = UkrainianStringUtils.UkrainianStringUtils.VowelsCount(userInput);
        Console.WriteLine("Number of vowels: " + vowelsCount);
        
        int consonantsCount = UkrainianStringUtils.UkrainianStringUtils.CountConsonants(userInput);
        Console.WriteLine("Number of consonants: " + consonantsCount);
        
        string reversedString = UkrainianStringUtils.UkrainianStringUtils.ReverseString(userInput);
        Console.WriteLine("reversed string: " + reversedString);
        
        string withoutDuplicates = UkrainianStringUtils.UkrainianStringUtils.RemoveDuplicates(userInput);
        Console.WriteLine("String without duplicates: " + withoutDuplicates);
        
        string withoutPunctuation = UkrainianStringUtils.UkrainianStringUtils.RemovePunctuation(userInput);
        Console.WriteLine("String without punctuation: " + withoutPunctuation);
    }
}   