using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibrary;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static ClassLibrary.Ship;

namespace FormData
{
    public partial class formData : Form
    {
        private ClassLibrary.Ship.DataManager dataManager;
        private string filePath = "data.bin";
        public formData()
        {
            InitializeComponent();
            dataManager = new DataManager(filePath);
            LoadData();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            int recordCount = dataGridView1.Rows.Count - 1;
            if (recordCount <= 0)
            {
                MessageBox.Show("В базе данных отсутсвуют записи", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
            label1.Text = $"Количество записей: {recordCount}";
            int h = recordCount * 20 + 23;
            int w = 496;
            dataGridView1.ScrollBars = ScrollBars.None;
            if (recordCount > 18)
            {
                h = 383;
                dataGridView1.ScrollBars = ScrollBars.Vertical;
            }
            dataGridView1.SetBounds(12, 12, w, h);
        }
        private void LoadData()
        {
            var records = dataManager.LoadShips();
            var dt = new DataTable();

            dt.Columns.Add("Наименование");
            dt.Columns.Add("Год");
            dt.Columns.Add("Грузоподъёмность");
            dt.Columns.Add("Порт");

            foreach (var record in records)
            {
                dt.Rows.Add(record.Name, record.Year, record.Capacity, record.Port);
            }

            dataGridView1.DataSource = dt;
        }
       
    }
}
