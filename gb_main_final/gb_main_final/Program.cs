using System;

namespace FilterArrayByStringLength
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ввод исходного массива строк
            Console.WriteLine("Введите исходный массив строк через запятую:");
            string[] inputArray = Console.ReadLine().Split(",");

            // Создание нового массива для отфильтрованных строк
            string[] filteredArray = new string[inputArray.Length];

            // Индекс для отфильтрованного массива
            int filteredIndex = 0;

            // Перебор исходного массива
            foreach (string str in inputArray)
            {
                // Проверка длины строки
                if (str.Length <= 3)
                {
                    // Добавление строки в отфильтрованный массив
                    filteredArray[filteredIndex] = str;
                    filteredIndex++;
                }
            }

            // Удаление пустых элементов из отфильтрованного массива
            //Array.Resize(ref filteredArray, filteredIndex);

            // Вывод отфильтрованного массива строк
            string result = string.Join(",", filteredArray);
            Console.WriteLine("Отфильтрованный массив строк:");
            Console.WriteLine(result);
        }

     }
}