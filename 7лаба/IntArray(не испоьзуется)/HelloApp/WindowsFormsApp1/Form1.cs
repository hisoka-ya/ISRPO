using System;
using System.Collections.Generic;
using System.IO;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;


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
                    openFileDialog.Filter = "Text files (*.txt)|*.txt"; // Настраиваем фильтр для диалога выбора файла
                    if (openFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        var fileLines = File.ReadAllLines(openFileDialog.FileName);
                        var numbers = new List<double>();

                        // Перебираем каждую строку и преобразуем в числа
                        foreach (var line in fileLines)
                        {
                            // Разделяем строку на части и пытаемся преобразовать каждую часть в число
                            var parts = line.Split(new[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);
                            foreach (var part in parts)
                            {
                                if (double.TryParse(part, out double num))
                                {
                                    numbers.Add(num);
                                }
                            }
                        }

                        // Здесь мы убираем проверку на длину
                        array = numbers.ToArray();
                        if (array.Length == 0)
                        {
                            MessageBox.Show("Файл пуст. Пожалуйста, выберите другой файл.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            // Пропускаем, если ячейка не изменяется
            // if (e.FormattedValue == null || e.FormattedValue.ToString() == dataGridView1[e.ColumnIndex, e.RowIndex].Value?.ToString())
            //{
            //    return;
            //}

            // Проверка на числовое значение
            if (!double.TryParse(e.FormattedValue.ToString(), out double number))
            {
                e.Cancel = true;
                MessageBox.Show("Пожалуйста, введите число.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void DataGridView2_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            // Пропускаем, если ячейка не изменяется
            // if (e.FormattedValue == null || e.FormattedValue.ToString() == dataGridView2[e.ColumnIndex, e.RowIndex].Value?.ToString())
            // {
            //     return;
            //  }

            // Проверка на числовое значение
            if (!double.TryParse(e.FormattedValue.ToString(), out double number))
            {
                e.Cancel = true;
                MessageBox.Show("Пожалуйста, введите число.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SumArray(DataGridView dataGridView)
        {
            double sum = 0;

            for (int i = 0; i < dataGridView.RowCount; i++)
            {
                for (int j = 0; j < dataGridView.ColumnCount; j++)
                {
                    if (dataGridView[j, i].Value != null)
                    {
                        double value;
                        if (double.TryParse(dataGridView[j, i].Value.ToString(), out value))
                        {
                            sum += value;
                        }
                    }
                }
            }

            label4.Text = sum.ToString();
        }

        private void суммаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SumArray(dataGridView1);
        }

        private void количествоToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SumArray(dataGridView2);
        }


        private void сложениеМассивовToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Проверка, что оба массива заполнены
            if (dataGridView1.RowCount == 0 || dataGridView2.RowCount == 0)
            {
                MessageBox.Show("Оба массива должны содержать данные.");
                return;
            }

            // Проверка, что количество столбцов в массивах совпадает
            if (dataGridView1.ColumnCount != dataGridView2.ColumnCount)
            {
                MessageBox.Show("Количество столбцов в массивах должно совпадать.");
                return;
            }

            // Создание новой сетки результатов
            dataGridView3.RowCount = dataGridView1.RowCount;
            dataGridView3.ColumnCount = dataGridView1.ColumnCount;


            // Сложение значений соответствующих ячеек сеток
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                for (int j = 0; j < dataGridView1.ColumnCount; j++)
                {
                    // Получение значений ячеек
                    decimal value1 = 0;
                    if (!decimal.TryParse(dataGridView1.Rows[i].Cells[j].Value?.ToString(), out value1))
                    {
                        value1 = 0;
                    }

                    decimal value2 = 0;
                    if (!decimal.TryParse(dataGridView2.Rows[i].Cells[j].Value?.ToString(), out value2))
                    {
                        value2 = 0;
                    }

                    // Сложение значений
                    decimal sum = value1 + value2;

                    // Запись результата в сетку результатов
                    dataGridView3.Rows[i].Cells[j].Value = sum;
                    for (int a = 0; a < dataGridView3.Columns.Count; a++)
                    {
                        dataGridView3.Columns[a].HeaderText = $"Число {a + 1}";
                    }
                }
            }

            // Вывод результата на метку
            label7.Text = $"Итог сложения двух массивов: ";
        }

        private void массив1МассивToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Вычесть(dataGridView2, dataGridView1, dataGridView3);
            label7.Text = $"Итог вычитание массива 1 из массива 2: ";

        }

        private void массив2МассивToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Вычесть(dataGridView1, dataGridView2, dataGridView3);
            label7.Text = $"Итог вычитание массива 2 из массива 1: ";
        }

        private void Вычесть(DataGridView dataGridView1, DataGridView dataGridView2, DataGridView dataGridView3)
        {
            // Проверка на одинаковое количество строк в dataGridView1 и dataGridView2
            if (dataGridView1.RowCount != dataGridView2.RowCount)
            {
                MessageBox.Show("Количество строк в массивах должно быть одинаковым.");
                return;
            }

            // Выделение памяти для dataGridView3
            dataGridView3.ColumnCount = dataGridView1.ColumnCount;
            dataGridView3.RowCount = dataGridView1.RowCount;

            // Перебор всех ячеек в dataGridView1 и dataGridView2
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                for (int j = 0; j < dataGridView1.ColumnCount; j++)
                {
                    // Вычитание значений из ячеек dataGridView1 и dataGridView2
                    decimal результат = decimal.Parse(dataGridView1[j, i].Value.ToString()) - decimal.Parse(dataGridView2[j, i].Value.ToString());

                    // Присвоение результата в соответствующую ячейку dataGridView3
                    dataGridView3[j, i].Value = результат;
                }
            }

            // Установка заголовков столбцов в dataGridView3
            for (int i = 0; i < dataGridView3.ColumnCount; i++)
            {
                dataGridView3.Columns[i].HeaderText = $"Число {i + 1}";
            }
        }

        private void массивToolStripMenuItem_Click(object sender, EventArgs e)
        {
            double[,] array1 = GetArrayFromDataGridView(dataGridView1);

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
            double[,] array2 = GetArrayFromDataGridView(dataGridView2);

            // Сортировать массив в порядке возрастания, оставляя отрицательные и нулевые элементы на своих местах
            SortArray(array2, true);

            // Вывести отсортированный массив в dataGridView3
            DisplayArrayInDataGridView(dataGridView3, array2);

            // Обновить метку label7
            label7.Text = "Отсортированный массив 2";

        }
        private double[,] GetArrayFromDataGridView(DataGridView dataGridView)
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

