namespace _10lab
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.записатьВФайлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.просмотрДанныхToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.найтиПоНаименованиюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.отредактироватьЗаписьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.параметрыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.изменитьШрифтToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.изменитьЦветШрифтаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(237, 92);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(144, 20);
            this.textBox1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(32, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Наименование корабля";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(89, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(260, 24);
            this.label3.TabIndex = 3;
            this.label3.Text = "Введите данные корабля";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(32, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Год постройки";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(237, 131);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(144, 20);
            this.textBox2.TabIndex = 4;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(32, 204);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "Порт приписки";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(32, 169);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(199, 16);
            this.label6.TabIndex = 7;
            this.label6.Text = "Дедвейт (грузоподъёмность)";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Pink;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.параметрыToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(411, 25);
            this.menuStrip1.TabIndex = 14;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.BackColor = System.Drawing.Color.Pink;
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.записатьВФайлToolStripMenuItem,
            this.просмотрДанныхToolStripMenuItem,
            this.найтиПоНаименованиюToolStripMenuItem,
            this.отредактироватьЗаписьToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(53, 21);
            this.файлToolStripMenuItem.Text = "файл";
            // 
            // записатьВФайлToolStripMenuItem
            // 
            this.записатьВФайлToolStripMenuItem.Name = "записатьВФайлToolStripMenuItem";
            this.записатьВФайлToolStripMenuItem.Size = new System.Drawing.Size(240, 22);
            this.записатьВФайлToolStripMenuItem.Text = "записать в файл";
            this.записатьВФайлToolStripMenuItem.Click += new System.EventHandler(this.записатьВФайлToolStripMenuItem_Click);
            // 
            // просмотрДанныхToolStripMenuItem
            // 
            this.просмотрДанныхToolStripMenuItem.Name = "просмотрДанныхToolStripMenuItem";
            this.просмотрДанныхToolStripMenuItem.Size = new System.Drawing.Size(240, 22);
            this.просмотрДанныхToolStripMenuItem.Text = "просмотр данных";
            this.просмотрДанныхToolStripMenuItem.Click += new System.EventHandler(this.просмотрДанныхToolStripMenuItem_Click);
            // 
            // найтиПоНаименованиюToolStripMenuItem
            // 
            this.найтиПоНаименованиюToolStripMenuItem.Name = "найтиПоНаименованиюToolStripMenuItem";
            this.найтиПоНаименованиюToolStripMenuItem.Size = new System.Drawing.Size(240, 22);
            this.найтиПоНаименованиюToolStripMenuItem.Text = "найти по наименованию";
            this.найтиПоНаименованиюToolStripMenuItem.Click += new System.EventHandler(this.найтиПоНаименованиюToolStripMenuItem_Click);
            // 
            // отредактироватьЗаписьToolStripMenuItem
            // 
            this.отредактироватьЗаписьToolStripMenuItem.Name = "отредактироватьЗаписьToolStripMenuItem";
            this.отредактироватьЗаписьToolStripMenuItem.Size = new System.Drawing.Size(240, 22);
            this.отредактироватьЗаписьToolStripMenuItem.Text = "отредактировать запись";
            this.отредактироватьЗаписьToolStripMenuItem.Click += new System.EventHandler(this.отредактироватьЗаписьToolStripMenuItem_Click);
            // 
            // параметрыToolStripMenuItem
            // 
            this.параметрыToolStripMenuItem.BackColor = System.Drawing.Color.Pink;
            this.параметрыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.изменитьШрифтToolStripMenuItem,
            this.изменитьЦветШрифтаToolStripMenuItem});
            this.параметрыToolStripMenuItem.Name = "параметрыToolStripMenuItem";
            this.параметрыToolStripMenuItem.Size = new System.Drawing.Size(94, 21);
            this.параметрыToolStripMenuItem.Text = "параметры";
            // 
            // изменитьШрифтToolStripMenuItem
            // 
            this.изменитьШрифтToolStripMenuItem.Name = "изменитьШрифтToolStripMenuItem";
            this.изменитьШрифтToolStripMenuItem.Size = new System.Drawing.Size(237, 22);
            this.изменитьШрифтToolStripMenuItem.Text = "изменить шрифт";
            this.изменитьШрифтToolStripMenuItem.Click += new System.EventHandler(this.изменитьШрифтToolStripMenuItem_Click);
            // 
            // изменитьЦветШрифтаToolStripMenuItem
            // 
            this.изменитьЦветШрифтаToolStripMenuItem.Name = "изменитьЦветШрифтаToolStripMenuItem";
            this.изменитьЦветШрифтаToolStripMenuItem.Size = new System.Drawing.Size(237, 22);
            this.изменитьЦветШрифтаToolStripMenuItem.Text = "изменить цвет шрифта";
            this.изменитьЦветШрифтаToolStripMenuItem.Click += new System.EventHandler(this.изменитьЦветШрифтаToolStripMenuItem_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Новороссийск",
            "Порт Восточный",
            "Приморск",
            "Мурманск",
            "Порт-Кавказ",
            "Ванино",
            "Туапсе",
            "Находка"});
            this.comboBox1.Location = new System.Drawing.Point(237, 204);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(144, 21);
            this.comboBox1.TabIndex = 15;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(237, 165);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            5500,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(144, 20);
            this.numericUpDown1.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(411, 263);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Управление морскими перевозками";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem записатьВФайлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem просмотрДанныхToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem найтиПоНаименованиюToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem отредактироватьЗаписьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem параметрыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem изменитьШрифтToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem изменитьЦветШрифтаToolStripMenuItem;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
    }
}

