using System;
using System.IO;


namespace ClassLibraryForArray
{
    public class IntArray
    {
        // Закрытые поля
        private int[] a;
        private int length;

        // Конструкторы
        public IntArray(int length)
        {
            this.length = length;
            a = new int[length];
        }
       
        public int[] arr;
        public IntArray(params int[] arr)
        {
            this.arr = arr; 
            length = arr.Length;
            a = new int[length];
            for (int i = 0; i < length; i++)
            {
                a[i] = arr[i];
            }
        }

        // Свойства
        public int Length
        {
            get { return length; }
        }

        public int this[int i]
        {
            get { return a[i]; }
            set { a[i] = value; }
        }

        // Методы класса
        public static IntArray RandomIntArray(int length, int a, int b)
        {
            Random random = new Random();
            IntArray result = new IntArray(length);
            for (int i = 0; i < length; i++)
            {
                result[i] = random.Next(a, b + 1);
            }
            return result;
        }

        public static IntArray ArrayFromTextFile(string fileName)
        {
            string[] lines = File.ReadAllLines(fileName);
            int[] arr = new int[lines.Length];
            for (int i = 0; i < lines.Length; i++)
            {
                arr[i] = int.Parse(lines[i]);
            }
            return new IntArray(arr);

        }

        public static void ArrayToTextFile(IntArray arr, string fileName)
        {
            string[] lines = new string[arr.Length];
            for (int i = 0; i < arr.Length; i++)
            {
          
                lines[i] = (arr[i]+1).ToString() ;
            }
            File.WriteAllLines(fileName, lines);
        }

        //Вычисление суммы элементов массива
        public static double SumArray(IntArray arr)
        {
            double sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }
            return sum;

        }

        // Операции класса
        public static IntArray operator ++(IntArray arr)
        {
            IntArray result = new IntArray(arr.Length);
            for (int i = 0; i < arr.Length; i++)
            {
                result[i] = arr[i] + 1;
            }
            return result;
        }
        // Перегрузка оператора + для сложения массива x со скаляром y
        public static IntArray operator +(IntArray x, int y)
        {
            IntArray result = new IntArray(x.Length);
            for (int i = 0; i < x.Length; i++)
            {
                result[i] = x[i] + y;
            }
            return result;
        }
        // Перегрузка оператора + для сложения скаляра a с массивом x
        public static IntArray operator +(int a, IntArray x)
        {
            int[] result = new int[x.Length];
            for (int i = 0; i < x.Length; i++)
            {
                result[i] = a + x[i];
            }
            return new IntArray(result);
        }

        // Перегрузка оператора + для сложения двух массивов x и z
        public static IntArray operator +(IntArray x, IntArray z)
        {
            if (x.Length != z.Length)
            {
                throw new ArgumentException("Массивы должны быть одинаковой длины.");
            }
            int[] result = new int[x.Length];
            for (int i = 0; i < x.Length; i++)
            {
                result[i] = x[i] + z[i];
            }
            return new IntArray(result);
        }

        // Перегрузка оператора -- для декремента всех элементов массива
        public static IntArray operator --(IntArray arr)
        {
            int[] result = new int[arr.Length]; // Доступ к arr через arr.arr
            for (int i = 0; i < arr.Length; i++)
            {
                result[i] = arr[i] - 1;
            }
            return new IntArray(result);
        }

        // Перегрузка оператора - для вычитания из массива x скаляра y
        public static IntArray operator -(IntArray x, int y)
        {
            int[] result = new int[x.Length];
            for (int i = 0; i < x.Length; i++)
            {
                result[i] = x[i] - y;
            }
            return new IntArray(result);
        }

        // Перегрузка оператора - для вычитания из скаляра y массива x
        public static IntArray operator -(int y, IntArray x)
        {
            int[] result = new int[x.Length];
            for (int i = 0; i < x.Length; i++)
            {
                result[i] = y - x[i];
            }
            return new IntArray(result);
        }

        // Перегрузка оператора - для вычитания из массива x массива z
        public static IntArray operator -(IntArray x, IntArray z)
        {
            if (x.Length != z.Length)
            {
                throw new ArgumentException("Массивы должны быть одинаковой длины.");
            }
            int[] result = new int[x.Length];
            for (int i = 0; i < x.Length; i++)
            {
                result[i] = x[i] -z[i];
            }
            return new IntArray(result);
        }
        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }

            IntArray other = (IntArray)obj;

            if (this.Length != other.Length)
            {
                return false;
            }

            for (int i = 0; i < this.Length; i++)
            {
                if (this[i] != other[i])
                {
                    return false;
                }
            }

            return true;
        }
    }
}
