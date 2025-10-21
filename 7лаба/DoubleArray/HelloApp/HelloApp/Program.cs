using System;
using System.IO;
using ClassLibraryForArray;

namespace HelloApp
{
    internal class Program
    {
        static void Main(string[] args)

        {
            // Создание массива длины 5 с случайными числами от 1 до 10
            IntArray x = IntArray.RandomIntArray(5, 1, 10);
            Console.WriteLine("Скалярная величина y = 5");
            // Вывод массива x
            Console.WriteLine("Массив x:");
            PrintArray(x);

            try
            {
                // Чтение массива из файла
                IntArray arr = IntArray.ArrayFromTextFile("fileName.txt");
                Console.WriteLine("Массив прочитан из файла:");
                foreach (int num in arr.arr)
                {
                    Console.Write(num + " ");
                }
                Console.WriteLine();

                // Модификация массива (ко всем элементам + 1)
                for (int i = 0; i < arr.Length; i++)
                {
                    arr.arr[i]++;
                }

                // Записывание измененного массива в файл
                IntArray.ArrayToTextFile(arr, "fileName.txt");
                Console.WriteLine("Массив записан в файл");
                }
                catch (FileNotFoundException e)
                {
                    Console.WriteLine(e.Message);
                    Console.WriteLine("Проверьте правильность имени файла!");
                }
                catch (Exception e)
                {
                    Console.WriteLine("Error: " + e.Message);
                }


            // Вычисление суммы элементов массива x
            double sum = IntArray.SumArray(x);
            Console.WriteLine("Сумма элементов массива x: " + sum);

            // Увеличение всех элементов массива x на 1
            IntArray xIncreased = ++x;
            Console.WriteLine("Массив x после увеличения элементов на 1:");
            PrintArray(xIncreased);

            // Сложение массива x со скалярным значением y
            int y = 5;
            IntArray xPlusY = x + y;
            Console.WriteLine("Массив x + y:");
            PrintArray(xPlusY);

            // Сложение скаляра a c массивом x
            Console.WriteLine("Скалярная величина a = 10");
            int a = 10;
            IntArray aPlusX = a + x;
            Console.WriteLine("a + Массив x:");
            PrintArray(aPlusX);

            // Создание второго массива z длины 5 с случайными числами от 1 до 10
            IntArray z = IntArray.RandomIntArray(5, 5, 15);
            Console.WriteLine("Массив z:");
            PrintArray(z);

            // Сложение массивов x и z
            IntArray xPlusZ = x + z;
            Console.WriteLine("Массив x + Массив z:");
            PrintArray(xPlusZ);

            // Уменьшение всех элементов массива x на 1
            IntArray xDecreased = --x;
            Console.WriteLine("Массив x после уменьшения элементов на 1:");
            PrintArray(xDecreased);

            // Вычитание скаляра y = 5 из массива x
            IntArray xMinusY = x - y;
            Console.WriteLine("Массив x - y:");
            PrintArray(xMinusY);

            // Вычитание массива x из скаляра y = 5
            IntArray zMinusX = y - x;
            Console.WriteLine("Массив z - Массив x:");
            PrintArray(zMinusX);

            // Вычитание массива z из массива x
            IntArray xMinusZ = x - z;
            Console.WriteLine("Массив x - Массив z:");
            PrintArray(xMinusZ);


            Console.WriteLine("Сравнения массива x и z");
            Console.WriteLine("true - одинаковые по содержанию, false - разные");
            Console.WriteLine(x.Equals(z));


            Console.ReadKey();
        }

        // Функция для вывода массива на консоль
        static void PrintArray(IntArray arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
        }
     
    }
}

