using System;

class Program
{
    static void Main()
    {
        // Пример строки
        string inputString = "level";

        Console.WriteLine("Исходная строка: " + inputString);

        // Проверяем, является ли строка палиндромом
        bool isPalindrome = IsPalindrome(inputString);

        if (isPalindrome)
        {
            Console.WriteLine("Строка является палиндромом.");
        }
        else
        {
            Console.WriteLine("Строка не является палиндромом.");
        }
    }

    // Метод для проверки, является ли строка палиндромом
    static bool IsPalindrome(string input)
    {
        // Удаляем пробелы и приводим все символы к нижнему регистру
        string cleanedInput = input.Replace(" ", "").ToLower();

        int length = cleanedInput.Length;

        for (int i = 0; i < length / 2; i++)
        {
            // Сравниваем символы с обоих концов строки
            if (cleanedInput[i] != cleanedInput[length - 1 - i])
            {
                return false; // Если хоть одна пара не совпадает, строка не палиндром
            }
        }

        return true; // Если все пары совпадают, строка палиндром
    }
}
