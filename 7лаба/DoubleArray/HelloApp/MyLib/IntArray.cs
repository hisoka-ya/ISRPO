using System;
using System.IO;
using System.Windows.Forms;

namespace ClassLibraryForArray
{
    public class DoubleArray
    {
        // Закрытые поля
        private double[] a;    // Одномерный массив
        private int length;    // Длина массива

        // Конструктор 1 для создания массива заданной длины
        public DoubleArray(int length)
        {
            this.length = length;
            a = new double[length];
        }

        // Конструктор 2 с переменным числом параметров
        public DoubleArray(params double[] arr)
        {
            this.a = arr;
            this.length = arr.Length;
        }

        // Свойство Длина массива
        public int Length
        {
            get { return length; }
        }

        // Индексатор
        public double this[int i]
        {
            get
            {
                if (i < 0 || i >= length)
                {
                    throw new IndexOutOfRangeException("Индекс выходит за пределы массива.");
                }
                return a[i];
            }
            set
            {
                if (i < 0 || i >= length)
                {
                    throw new IndexOutOfRangeException("Индекс выходит за пределы массива.");
                }
                a[i] = value;
            }
        }

        // Создание массива длины length и заполнение его случайными вещественными числами в диапазоне от a до b
        public static DoubleArray RandomDoubleArray(int length, double minValue, double maxValue)
        {
            Random rand = new Random();
            double[] array = new double[length];

            for (int i = 0; i < length; i++)
            {
                array[i] = (rand.NextDouble() * (maxValue - minValue)) + minValue;
            }

            return new DoubleArray(array);
        }

        // Ввод массива из текстового файла
        public static double[] ArrayFromTextFile(string fileName)
        {
            // Считывание строк из текстового файла
            string[] lines = File.ReadAllLines(fileName);

            // Создание массива и заполнение его данными
            double[] array = new double[lines.Length];
            for (int i = 0; i < lines.Length; i++)
            {
                double value;
                if (double.TryParse(lines[i], out value))
                {
                    array[i] = value;
                }
            }

            return array;
        }

        // Вывод массива в текстовый файл
        public static void ArrayToTextFile(DoubleArray arr, string fileName)
        {
            File.WriteAllLines(fileName, Array.ConvertAll(arr.a, x => x.ToString()));
        }

        // Вычисление суммы элементов массива
        public static double SumArray(DoubleArray arr)
        {
            double sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }
            return sum;
        }

        // Операции класса
        public static DoubleArray operator ++(DoubleArray arr)
        {
            DoubleArray result = new DoubleArray(arr.Length);
            for (int i = 0; i < arr.Length; i++)
            {
                result[i] = arr[i] + 1;
            }
            return result;
        }
        
        public static DoubleArray operator +(DoubleArray x, double y)
        {
            DoubleArray result = new DoubleArray(x.Length);
            for (int i = 0; i < x.Length; i++)
            {
                result[i] = x[i] + y;
            }
            return result;
        }

        public static DoubleArray operator +(double x, DoubleArray y)
        {
            return y + x;
        }

        public static DoubleArray operator +(DoubleArray x, DoubleArray y)
        {
            if (x.Length != y.Length)
            {
                throw new ArgumentException("Длины массивов должны совпадать.");
            }
            DoubleArray result = new DoubleArray(x.Length);
            for (int i = 0; i < x.Length; i++)
            {
                result[i] = x[i] + y[i];
            }
            return result;
        }

        public static DoubleArray operator --(DoubleArray arr)
        {
            DoubleArray result = new DoubleArray(arr.Length);
            for (int i = 0; i < arr.Length; i++)
            {
                result[i] = arr[i] - 1;
            }
            return result;
        }

        public static DoubleArray operator -(DoubleArray x, double y)
        {
            DoubleArray result = new DoubleArray(x.Length);
            for (int i = 0; i < x.Length; i++)
            {
                result[i] = x[i] - y;
            }
            return result;
        }

        public static DoubleArray operator -(double x, DoubleArray y)
        {
            DoubleArray result = new DoubleArray(y.Length);
            for (int i = 0; i < y.Length; i++)
            {
                result[i] = x - y[i];
            }
            return result;
        }

        public static DoubleArray operator -(DoubleArray x, DoubleArray y)
        {
            if (x.Length != y.Length)
            {
                throw new ArgumentException("Длины массивов должны совпадать.");
            }
            DoubleArray result = new DoubleArray(x.Length);
            for (int i = 0; i < x.Length; i++)
            {
                result[i] = x[i] - y[i];
            }
            return result;
        }
    }
}