using System;

class Program
{
    static void Main()
    {
        // Пример строки с латинскими буквами в обоих регистрах
        string originalString = "HeLLo WoRLd";

        Console.WriteLine("First string: " + originalString);

        // Заменяем все заглавные буквы на строчные
        string resultString = ConvertToLowerCase(originalString);

        Console.WriteLine("Second string: " + resultString);
    }

    // Метод для замены заглавных букв на строчные
    static string ConvertToLowerCase(string input)
    {
        char[] charArray = input.ToCharArray();

        for (int i = 0; i < charArray.Length; i++)
        {
            if (char.IsUpper(charArray[i]))
            {
                charArray[i] = char.ToLower(charArray[i]);
            }
        }

        return new string(charArray);
    }
}
