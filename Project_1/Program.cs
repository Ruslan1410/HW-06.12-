// Задача 1: Задайте двумерный массив символов (тип char [,]). Создать строку из символов этого массива.

using System;

class Program
{
    static void Main()
    {
        // Задаем двумерный массив символов
        char[,] charArray = {
            {'H', 'e', 'l', 'l', 'o',},
            { 'W', 'o', 'r', 'l', 'd'}
        };

        // Создаем строку из символов массива
        string resultString = CharArrayToString(charArray);

        // Выводим результат
        Console.WriteLine(resultString);

        Console.ReadLine(); // Добавлено для того, чтобы консольное окно не закрывалось сразу после выполнения программы.
    }

    static string CharArrayToString(char[,] charArray)
    {
        int rows = charArray.GetLength(0);
        int cols = charArray.GetLength(1);

        // Используем StringBuilder для эффективной конкатенации строк
        System.Text.StringBuilder sb = new System.Text.StringBuilder();

        // Обходим двумерный массив и добавляем каждый символ в StringBuilder
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                sb.Append(charArray[i, j]);
            }
        }

        // Возвращаем строку
        return sb.ToString();
    }
}
