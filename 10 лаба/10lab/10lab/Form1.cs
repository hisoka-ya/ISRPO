using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibrary;
using static ClassLibrary.Ship;

namespace _10lab
{

    public partial class Form1 : Form
    {
        private ClassLibrary.Ship.DataManager dataManager;

        public Form1()
        {
            InitializeComponent();
            var array = comboBox1.SelectedItem;
            dataManager = new DataManager("data.bin");
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void изменитьШрифтToolStripMenuItem_Click(object sender, EventArgs e)
        {
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

        private void изменитьЦветШрифтаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();

            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                this.ForeColor = colorDialog.Color;
            }
        }

        private void записатьВФайлToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text) ||
             string.IsNullOrWhiteSpace(textBox2.Text) ||
             numericUpDown1.Value == 0 || 
             comboBox1.SelectedIndex == -1) 
            {
                MessageBox.Show("Пожалуйста, заполните все поля.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                var record = new Ship(
                    textBox1.Text,
                    int.Parse(textBox2.Text),
                    numericUpDown1.Value,
                    comboBox1.SelectedItem.ToString()
                );

                dataManager.AddRecord(record);
                MessageBox.Show("Запись добавлена!");
            }
            
            
        }

        private void просмотрДанныхToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormData.formData about = new FormData.formData();
            DialogResult result = about.ShowDialog();
        }

        private void найтиПоНаименованиюToolStripMenuItem_Click(object sender, EventArgs e)
        {
            numericUpDown1.Value = 0;
            string shipName = textBox1.Text.Trim();
            Ship foundShip = dataManager.FindRecordsByName(shipName);


            if (foundShip != null)
            {
                textBox1.Text = foundShip.Name;
                textBox2.Text = foundShip.Year.ToString();
                numericUpDown1.Value = foundShip.Capacity;
                comboBox1.SelectedItem = foundShip.Port;
            }
            else
            {
                MessageBox.Show("Корабль не найден.");
                // Очистка полей, если корабль не найден
                textBox2.Clear();
                numericUpDown1.Value = 0;
                comboBox1.SelectedItem = null;
            }
        }

        private void отредактироватьЗаписьToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(textBox1.Text) ||
             string.IsNullOrWhiteSpace(textBox2.Text) ||
             numericUpDown1.Value == 0 ||
             comboBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Пожалуйста, заполните все поля.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string shipName = textBox1.Text.Trim();

                Ship updatedShip = new Ship(
                    name: shipName,
                    year: int.Parse(textBox2.Text),
                    capacity: numericUpDown1.Value,
                    port: comboBox1.SelectedItem.ToString()
                );

                try
                {
                    dataManager.EditShip(updatedShip);
                    MessageBox.Show("Запись успешно обновлена.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            int currentYear = DateTime.Now.Year;
            if (int.TryParse(textBox2.Text, out int inputYear))
            {
                if (inputYear > currentYear)
                {
                    MessageBox.Show("Введите год не больше текущего года.");
                    textBox2.Focus();
                    textBox2.Text = currentYear.ToString();
                }
            }
        }
    }
 }
