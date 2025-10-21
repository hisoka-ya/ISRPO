using System;
using System.Collections.Generic;
using System.IO;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using ClassLibraryForArray;
using System.Collections;


namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // Обработчик события для проверки вводимых данных
            dataGridView1.CellValidating += DataGridView1_CellValidating;
            dataGridView2.CellValidating += DataGridView2_CellValidating;
        }

        private void button1_Click(object sender, EventArgs e)

        {
            double[] array;

            // Проверяем, какой массив (и, следовательно, какое DataGridView) будем заполнять
            if (radioButton4.Checked) // Для первого массива
            {
                // Устанавливаем array как null, если будет заполним из файла
                array = null;
            }
            else if (radioButton5.Checked) // Для второго массива
            {
                // Устанавливаем array как null, если будет заполним из файла
                array = null;
            }
            else
            {
                MessageBox.Show("Выберите, какой массив заполнять.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (radioButton1.Checked) // Заполнение рандомно
            {
                var rand = new Random();
                // Устанавливаем длину массива равной значению numericUpDown1, игнорируемое для файла
                int length = (int)numericUpDown1.Value;
                array = new double[length];
                for (int i = 0; i < length; i++)
                {
                    // Генерация случайных чисел: целые числа в диапазоне от 1 до 100 и десятичные от 1 до 100
                    if (rand.Next(0, 2) == 0)
                        array[i] = rand.Next(-100, 101); // Случайное целое число
                    else
                        array[i] = Math.Round(rand.NextDouble() * 100, 2); // Случайное десятичное число
                }
            }
            else if (radioButton2.Checked) // Заполнение вручную
            {
                int length = (int)numericUpDown1.Value;
                array = new double[length];
                if (radioButton4.Checked)
                {
                    dataGridView1.ReadOnly = false;
                    dataGridView2.ReadOnly = true;
                }
                else
                {
                    dataGridView2.ReadOnly = false;
                    dataGridView1.ReadOnly = true;
                }

            }
            else if (radioButton3.Checked) // Заполнение из текстового файла
            {
                using (OpenFileDialog openFileDialog = new OpenFileDialog())
                {

                    openFileDialog.Filter = "Text files|*.txt"; // Настраиваем фильтр для диалога выбора файла
                    if (openFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        // Вызов статического метода ArrayFromTextFile из библиотеки
                        array = DoubleArray.ArrayFromTextFile(openFileDialog.FileName);

                        if (array == null || array.Length == 0)
                        {
                            MessageBox.Show("Файл пуст или не содержит корректных данных.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }
                    else
                    {
                        return; // Если пользователь отменил выбор файла
                    }
                }
            }
            else
            {
                MessageBox.Show("Выберите способ заполнения массива.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Заполнение DataGridView
            DataGridView targetDataGridView = radioButton4.Checked ? dataGridView1 : dataGridView2;

            // Сбрасываем предыдущие данные
            targetDataGridView.Columns.Clear();

            // Устанавливаем количество колонок равным количеству элементов в массиве
            for (int i = 0; i < array.Length; i++)
            {
                targetDataGridView.Columns.Add($"Column{i}", $"Число {i + 1}");
            }

            targetDataGridView.Rows.Clear();

            if (array.Length < 1)
            {
                MessageBox.Show("Размер массива должен содержать не меньше 1 столбца", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                targetDataGridView.Rows.Add(array.Select(x => (object)x).ToArray()); // Добавление массива как строки
            }
        }



        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1.CellValidating += DataGridView1_CellValidating;

        }

        private void DataGridView1_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            //ропускаем, если ячейка не изменяется
             if (e.FormattedValue == null || e.FormattedValue.ToString() == dataGridView1[e.ColumnIndex, e.RowIndex].Value?.ToString())
            {
                return;
            }

            // Проверка на числовое значение
            if (!double.TryParse(e.FormattedValue.ToString(), out double number))
            {
                e.Cancel = true;
                MessageBox.Show("Пожалуйста, введите число.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void DataGridView2_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            //ропускаем, если ячейка не изменяется
             if (e.FormattedValue == null || e.FormattedValue.ToString() == dataGridView2[e.ColumnIndex, e.RowIndex].Value?.ToString())
             {
                return;
             }

            // Проверка на числовое значение
            if (!double.TryParse(e.FormattedValue.ToString(), out double number))
            {
                e.Cancel = true;
                MessageBox.Show("Пожалуйста, введите число.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //private void SumArray(DataGridView dataGridView)
        //{
        //    double sum = 0;

        //    for (int i = 0; i < dataGridView.RowCount; i++)
        //    {
        //        for (int j = 0; j < dataGridView.ColumnCount; j++)
        //        {
        //            if (dataGridView[j, i].Value != null)
        //            {
        //                double value;
        //                if (double.TryParse(dataGridView[j, i].Value.ToString(), out value))
        //                {
        //                    sum += value;
        //                }
        //            }
        //        }
        //    }

        //    label4.Text = sum.ToString();
        //}

        private void суммаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            double[] array1 = GetDataFromDataGridView(dataGridView1);
            DoubleArray doubleArray1 = new DoubleArray(array1);
            double sum = DoubleArray.SumArray(doubleArray1);
            label4.Text = sum.ToString();
        }

        private void количествоToolStripMenuItem_Click(object sender, EventArgs e)
        {
            double[] array2 = GetDataFromDataGridView(dataGridView2);
            DoubleArray doubleArray2 = new DoubleArray(array2);
            double sum = DoubleArray.SumArray(doubleArray2);
            label4.Text = sum.ToString();
        }

        // Метод для получения массива из DataGridView
        private double[] GetDataFromDataGridView(DataGridView dataGridView)
        {
            return dataGridView.Rows.Cast<DataGridViewRow>()
                .Where(row => !row.IsNewRow) // Пропустить пустую строку
                .Select(row =>
                {
                    // Извлечение всех значений из текущей строки
                    double[] values = new double[row.Cells.Count];
                    for (int i = 0; i < row.Cells.Count; i++)
                    {
                        // Преобразуем значение в double, если оно не null
                        values[i] = row.Cells[i].Value != null ? Convert.ToDouble(row.Cells[i].Value) : 0;
                    }
                    return values;
                }).SelectMany(x => x).ToArray();  // Разворачиваем массивы в один одномерный массив
        }

        // Метод для отображения результата в DataGridView
        private void DisplayResultInDataGridView(DoubleArray resultArray, DataGridView dataGridView)
        {
            dataGridView.Rows.Clear();
            dataGridView.Columns.Clear();

            // Установка заголовков
            for (int i = 0; i < resultArray.Length; i++)
            {
                dataGridView.Columns.Add("Column" + i, "Число " + (i + 1));
            }

            // Добавление данных в DataGridView
            var row = new object[resultArray.Length];
            for (int i = 0; i < resultArray.Length; i++)
            {
                row[i] = resultArray[i];
            }
            dataGridView.Rows.Add(row);
        }
        private void сложениеМассивовToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                // Получение данных из DataGridView1
                double[] array1 = GetDataFromDataGridView(dataGridView1);
                // Получение данных из DataGridView2
                double[] array2 = GetDataFromDataGridView(dataGridView2);

                // Проверка на одинаковую длину массивов
                if (array1.Length != array2.Length)
                {
                    MessageBox.Show("Длины массивов должны совпадать.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Создание объектов DoubleArray
                DoubleArray doubleArray1 = new DoubleArray(array1);
                DoubleArray doubleArray2 = new DoubleArray(array2);

                // Сложение массивов
                DoubleArray resultArray = doubleArray1 + doubleArray2;

                // Вывод набора данных в dataGridView3
                DisplayResultInDataGridView(resultArray, dataGridView3);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // Вывод результата на метку
            label7.Text = $"Итог сложения двух массивов: ";

        }

        private void массив1МассивToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PerformSubtraction(true);
            label7.Text = $"Итог вычитание массива 1 из массива 2: ";

        }

        private void массив2МассивToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PerformSubtraction(false);
            label7.Text = $"Итог вычитание массива 2 из массива 1: ";
        }

        private void PerformSubtraction(bool subtractArray1FromArray2)
        {
            try
            {
                // Получение данных из DataGridView1
                double[] array1 = GetDataFromDataGridView(dataGridView1);
                // Получение данных из DataGridView2
                double[] array2 = GetDataFromDataGridView(dataGridView2);

                // Проверка на одинаковую длину массивов
                if (array1.Length != array2.Length)
                {
                    MessageBox.Show("Длины массивов должны совпадать.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Создание объектов DoubleArray
                DoubleArray doubleArray1 = new DoubleArray(array1);
                DoubleArray doubleArray2 = new DoubleArray(array2);

                // Выполнение вычитания
                DoubleArray resultArray;

                if (subtractArray1FromArray2)
                {
                    resultArray = doubleArray2 - doubleArray1; // array2 - array1
                }
                else
                {
                    resultArray = doubleArray1 - doubleArray2; // array1 - array2
                }

                // Вывод набора данных в dataGridView3
                DisplayResultInDataGridView(resultArray, dataGridView3);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void массивToolStripMenuItem_Click(object sender, EventArgs e)
        {
            double[,] array1 = GetArrayFromDataGridVieww(dataGridView1);

            // Сортировать массив в порядке возрастания, оставляя отрицательные и нулевые элементы на своих местах
          SortArray(array1, true);

            // Вывести отсортированный массив в dataGridView3
          DisplayArrayInDataGridView(dataGridView3, array1);

            // Обновить метку label7
            label7.Text = "Отсортированный массив 1";
        }

        private void массивToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            // Получить данные из dataGridView2
          double[,] array2 = GetArrayFromDataGridVieww(dataGridView2);

            // Сортировать массив в порядке возрастания, оставляя отрицательные и нулевые элементы на своих местах
           SortArray(array2, true);

            // Вывести отсортированный массив в dataGridView3
           DisplayArrayInDataGridView(dataGridView3, array2);

            // Обновить метку label7
            label7.Text = "Отсортированный массив 2";

        }
        private double[,] GetArrayFromDataGridVieww(DataGridView dataGridView)
        {
            int rowCount = dataGridView.RowCount;
            int columnCount = dataGridView.ColumnCount;

            double[,] array = new double[rowCount, columnCount];

            for (int i = 0; i < rowCount; i++)
            {
                for (int j = 0; j < columnCount; j++)
                {
                    if (dataGridView[j, i].Value != null)
                    {
                        double value;
                        if (double.TryParse(dataGridView[j, i].Value.ToString(), out value))
                        {
                            array[i, j] = value;
                        }
                    }
                }
            }

            return array;
        }

        private void SortArray(double[,] array, bool skipNonPositive)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    for (int k = j + 1; k < array.GetLength(1); k++)
                    {
                        if (array[i, j] > array[i, k] && (skipNonPositive && array[i, j] > 0 && array[i, k] > 0))
                        {
                            double temp = array[i, j];
                            array[i, j] = array[i, k];
                            array[i, k] = temp;
                        }
                    }
                }
            }
        }
        private void DisplayArrayInDataGridView(DataGridView dataGridView, double[,] array)
        {
            dataGridView.RowCount = array.GetLength(0);
            dataGridView.ColumnCount = array.GetLength(1);

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    dataGridView[j, i].Value = array[i, j];
                }
            }
            for (int i = 0; i < dataGridView3.ColumnCount; i++)
            {
                dataGridView3.Columns[i].HeaderText = $"Число {i + 1}";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Получить ссылку на выбранный DataGridView
            DataGridView dataGridView = radioButton4.Checked ? dataGridView1 : dataGridView2;

            // Получить число кратности из numericUpDown2
            int multiple = (int)numericUpDown2.Value;

            // Переменная для хранения количества элементов, кратных заданному числу
            int count = 0;

            // Перебор всех элементов массива и подсчет кратных заданному числу
            for (int i = 0; i < dataGridView.RowCount; i++)
            {
                for (int j = 0; j < dataGridView.ColumnCount; j++)
                {
                    if (dataGridView[j, i].Value != null)
                    {
                        int value;
                        if (int.TryParse(dataGridView[j, i].Value.ToString(), out value))
                        {
                            if (value % multiple == 0)
                            {
                                count++;
                            }
                        }
                    }
                }
            }

            // Вывод количества элементов в label4
            label4.Text = count.ToString();
        }

        private void изменитьЦветФонаToolStripMenuItem_Click(object sender, EventArgs e)
        {
 
                // Создать диалог выбора цвета
                ColorDialog colorDialog = new ColorDialog();

                // Показать диалог и получить выбранный цвет
                if (colorDialog.ShowDialog() == DialogResult.OK)
                {
                    // Изменить цвет фона формы
                    this.BackColor = colorDialog.Color;
                }
        }

        private void изменитьШрифтToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Создать диалог выбора шрифта
            FontDialog fontDialog = new FontDialog();

            // Показать диалог и получить выбранный шрифт
            if (fontDialog.ShowDialog() == DialogResult.OK)
            {
                // Изменить шрифт всех элементов управления на форме
                foreach (Control control in this.Controls)
                {
                    control.Font = fontDialog.Font;
                }
            }
        }
    }
 }

