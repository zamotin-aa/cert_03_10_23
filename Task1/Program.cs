// Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
// длина которых меньше, либо равна 3 символам. 
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.


using System;

class Program
{
    static void Main()
    {
        // ввод массива с клавиатуры, разделитель запятая
        Console.WriteLine("Введите строки через запятую:");
        string input = Console.ReadLine();
        string[] inputArray = input.Split(',');

        //фильтруем введенный массив
        string[] resultArray = FilterArrayByLength(inputArray, 3);

        //печатаем ответ
        Console.WriteLine("Результат:");
        foreach (string str in resultArray)
        {
            Console.WriteLine(str);
        }
    }

    // Метод для фильтрации массива по заданному условию
    static string[] FilterArrayByLength(string[] inputArray, int maxLength)
    {
        int count = 0;

        // Считаем количество строк, удовлетворяющих условию
        for (int i = 0; i < inputArray.Length; i++)
        {
            if (inputArray[i].Length <= maxLength)
            {
                count++;
            }
        }

        // Создаем новый массив нужной длины
        string[] resultArray = new string[count];
        int resultIndex = 0;

        // Заполняем новый массив подходящими строками
        for (int i = 0; i < inputArray.Length; i++)
        {
            if (inputArray[i].Length <= maxLength)
            {
                resultArray[resultIndex] = inputArray[i];
                resultIndex++;
            }
        }

        return resultArray;
    }

}
