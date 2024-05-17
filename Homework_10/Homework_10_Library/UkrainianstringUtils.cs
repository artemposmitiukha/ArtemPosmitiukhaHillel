namespace  UkrainianStringUtils;

public class UkrainianStringUtils
{
    public static int VowelsCount(string userInput)
    {
        char[] vowelsList = { 'а', 'е', 'є', 'и', 'і', 'ї', 'о', 'у', 'ю', 'я' };
        int vowels = 0;
        for (int i = 0; i < userInput.Length; i++)
        {
            char currentChar = userInput[i];
            currentChar = char.ToLower(currentChar);  

            if (vowelsList.Contains(currentChar))
            {
                vowels++;
            }
        }

        return vowels;
    }

    public static int CountConsonants(string userInput)
    {
        char[] cononantssList = { 'б', 'в', 'г', 'ґ', 'д', 'ж', 'з', 'й', 'к', 'л', 'м', 'н', 'п', 'р', 'с', 'т', 'ф', 'х', 'ц', 'ч', 'ш', 'щ' };

        int consonants = 0;
        for (int i = 0; i < userInput.Length; i++)
        {
            char currentChar = userInput[i];
            currentChar = char.ToLower(currentChar);  

            if (cononantssList.Contains(currentChar))
            {
                consonants++;
            }
        }

        return consonants;
    }

    public static string ReverseString(string userInput)
    {
        char[] bufferArray = userInput.ToCharArray();
        Array.Reverse(bufferArray);
        return new string(bufferArray);
    }

    public static string RemoveDuplicates(string userInput)
    {
        char[] bufferArray = userInput.ToCharArray();
        char[] outputArray = new char[bufferArray.Length];
        int outputIndex = 0;

        for (int i = 0; i < bufferArray.Length; i++)
        {
            bool isDuplicate = false;
            for (int j = 0; j < outputIndex; j++)
            {
                if (bufferArray[i] == outputArray[j])
                {
                    isDuplicate = true;
                    break;
                }
            }

            if (!isDuplicate)
            {
                outputArray[outputIndex] = bufferArray[i];
                outputIndex++;
            }
        }

        return new string(outputArray, 0, outputIndex);
    }

    public static string RemovePunctuation(string userInput)
    {
        char[] punctuationList = { ',', '.', ':', ';', '-', '!', '?', '"', '/', ' ' };
        int count = 0;
        
        for (int i = 0; i < userInput.Length; i++)
        {
            if (!punctuationList.Contains(userInput[i]))
            {
                count++;
            }
        }
        
        char[] outputArray = new char[count];
        
        int index = 0;
        for (int i = 0; i < userInput.Length; i++)
        {
            if (!punctuationList.Contains(userInput[i]))
            {
                outputArray[index] = userInput[i];
                index++;
            }
        }
        
        return new string(outputArray);
    }
}