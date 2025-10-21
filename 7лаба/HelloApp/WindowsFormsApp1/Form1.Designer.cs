namespace WindowsFormsApp1
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
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.вычислитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.суммаЭлементовToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.суммаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.количествоToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сложениеМассивовToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вычитаниеМассивовToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.массив2МассивToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.массив1МассивToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сортировкаПоложительныхЭлтовToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.массивToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.массивToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.настройкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.изменитьЦветФонаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.изменитьШрифтToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Размер массива";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.вычислитьToolStripMenuItem,
            this.настройкаToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // вычислитьToolStripMenuItem
            // 
            this.вычислитьToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.суммаЭлементовToolStripMenuItem,
            this.сложениеМассивовToolStripMenuItem,
            this.вычитаниеМассивовToolStripMenuItem,
            this.сортировкаПоложительныхЭлтовToolStripMenuItem});
            this.вычислитьToolStripMenuItem.Name = "вычислитьToolStripMenuItem";
            this.вычислитьToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
            this.вычислитьToolStripMenuItem.Text = "Вычислить";
            // 
            // суммаЭлементовToolStripMenuItem
            // 
            this.суммаЭлементовToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.суммаToolStripMenuItem,
            this.количествоToolStripMenuItem});
            this.суммаЭлементовToolStripMenuItem.Name = "суммаЭлементовToolStripMenuItem";
            this.суммаЭлементовToolStripMenuItem.Size = new System.Drawing.Size(293, 22);
            this.суммаЭлементовToolStripMenuItem.Text = "сумма элементов";
            // 
            // суммаToolStripMenuItem
            // 
            this.суммаToolStripMenuItem.Name = "суммаToolStripMenuItem";
            this.суммаToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.суммаToolStripMenuItem.Text = "массив 1";
            this.суммаToolStripMenuItem.Click += new System.EventHandler(this.суммаToolStripMenuItem_Click);
            // 
            // количествоToolStripMenuItem
            // 
            this.количествоToolStripMenuItem.Name = "количествоToolStripMenuItem";
            this.количествоToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.количествоToolStripMenuItem.Text = "массив 2";
            this.количествоToolStripMenuItem.Click += new System.EventHandler(this.количествоToolStripMenuItem_Click);
            // 
            // сложениеМассивовToolStripMenuItem
            // 
            this.сложениеМассивовToolStripMenuItem.Name = "сложениеМассивовToolStripMenuItem";
            this.сложениеМассивовToolStripMenuItem.Size = new System.Drawing.Size(293, 22);
            this.сложениеМассивовToolStripMenuItem.Text = "сложение массивов";
            this.сложениеМассивовToolStripMenuItem.Click += new System.EventHandler(this.сложениеМассивовToolStripMenuItem_Click);
            // 
            // вычитаниеМассивовToolStripMenuItem
            // 
            this.вычитаниеМассивовToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.массив2МассивToolStripMenuItem,
            this.массив1МассивToolStripMenuItem});
            this.вычитаниеМассивовToolStripMenuItem.Name = "вычитаниеМассивовToolStripMenuItem";
            this.вычитаниеМассивовToolStripMenuItem.Size = new System.Drawing.Size(293, 22);
            this.вычитаниеМассивовToolStripMenuItem.Text = "вычитание массивов";
            // 
            // массив2МассивToolStripMenuItem
            // 
            this.массив2МассивToolStripMenuItem.Name = "массив2МассивToolStripMenuItem";
            this.массив2МассивToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.массив2МассивToolStripMenuItem.Text = "массив 1 - массив 2";
            this.массив2МассивToolStripMenuItem.Click += new System.EventHandler(this.массив2МассивToolStripMenuItem_Click);
            // 
            // массив1МассивToolStripMenuItem
            // 
            this.массив1МассивToolStripMenuItem.Name = "массив1МассивToolStripMenuItem";
            this.массив1МассивToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.массив1МассивToolStripMenuItem.Text = "массив 2 - массив 1";
            this.массив1МассивToolStripMenuItem.Click += new System.EventHandler(this.массив1МассивToolStripMenuItem_Click);
            // 
            // сортировкаПоложительныхЭлтовToolStripMenuItem
            // 
            this.сортировкаПоложительныхЭлтовToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.массивToolStripMenuItem,
            this.массивToolStripMenuItem1});
            this.сортировкаПоложительныхЭлтовToolStripMenuItem.Name = "сортировкаПоложительныхЭлтовToolStripMenuItem";
            this.сортировкаПоложительныхЭлтовToolStripMenuItem.Size = new System.Drawing.Size(293, 22);
            this.сортировкаПоложительныхЭлтовToolStripMenuItem.Text = "сортировка положительных элементов";
            // 
            // массивToolStripMenuItem
            // 
            this.массивToolStripMenuItem.Name = "массивToolStripMenuItem";
            this.массивToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.массивToolStripMenuItem.Text = "1 массив";
            this.массивToolStripMenuItem.Click += new System.EventHandler(this.массивToolStripMenuItem_Click);
            // 
            // массивToolStripMenuItem1
            // 
            this.массивToolStripMenuItem1.Name = "массивToolStripMenuItem1";
            this.массивToolStripMenuItem1.Size = new System.Drawing.Size(123, 22);
            this.массивToolStripMenuItem1.Text = "2 массив";
            this.массивToolStripMenuItem1.Click += new System.EventHandler(this.массивToolStripMenuItem1_Click);
            // 
            // настройкаToolStripMenuItem
            // 
            this.настройкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.изменитьЦветФонаToolStripMenuItem,
            this.изменитьШрифтToolStripMenuItem});
            this.настройкаToolStripMenuItem.Name = "настройкаToolStripMenuItem";
            this.настройкаToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.настройкаToolStripMenuItem.Text = "Настройки";
            // 
            // изменитьЦветФонаToolStripMenuItem
            // 
            this.изменитьЦветФонаToolStripMenuItem.Name = "изменитьЦветФонаToolStripMenuItem";
            this.изменитьЦветФонаToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.изменитьЦветФонаToolStripMenuItem.Text = "Изменить  цвет фона";
            this.изменитьЦветФонаToolStripMenuItem.Click += new System.EventHandler(this.изменитьЦветФонаToolStripMenuItem_Click);
            // 
            // изменитьШрифтToolStripMenuItem
            // 
            this.изменитьШрифтToolStripMenuItem.Name = "изменитьШрифтToolStripMenuItem";
            this.изменитьШрифтToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.изменитьШрифтToolStripMenuItem.Text = "Изменить шрифт";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(567, 52);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(122, 33);
            this.button1.TabIndex = 5;
            this.button1.Text = "Заполнить массивы";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(6, 26);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(71, 17);
            this.radioButton1.TabIndex = 6;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "случайно";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(6, 49);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(66, 17);
            this.radioButton2.TabIndex = 7;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "вручную";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(6, 72);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(132, 17);
            this.radioButton3.TabIndex = 8;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "из текстового файла";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton3);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Location = new System.Drawing.Point(211, 49);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(152, 96);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Способ ввода массива ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(30, 522);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 16);
            this.label3.TabIndex = 10;
            this.label3.Text = "Результат:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(116, 522);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(15, 18);
            this.label4.TabIndex = 12;
            this.label4.Text = "  ";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView1.Location = new System.Drawing.Point(31, 190);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridView1.Size = new System.Drawing.Size(715, 66);
            this.dataGridView1.TabIndex = 13;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(31, 65);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(134, 20);
            this.numericUpDown1.TabIndex = 14;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioButton5);
            this.groupBox2.Controls.Add(this.radioButton4);
            this.groupBox2.Location = new System.Drawing.Point(379, 49);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(152, 96);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Выбор массива ";
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.Location = new System.Drawing.Point(6, 49);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(72, 17);
            this.radioButton5.TabIndex = 7;
            this.radioButton5.TabStop = true;
            this.radioButton5.Text = "массив 2\r\n";
            this.radioButton5.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(6, 26);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(72, 17);
            this.radioButton4.TabIndex = 6;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "массив 1";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(31, 118);
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(134, 20);
            this.numericUpDown2.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Число кратности";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(567, 110);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(122, 33);
            this.button2.TabIndex = 19;
            this.button2.Text = "Расчитать кратность";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AllowUserToResizeColumns = false;
            this.dataGridView2.AllowUserToResizeRows = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView2.Location = new System.Drawing.Point(31, 293);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersVisible = false;
            this.dataGridView2.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridView2.Size = new System.Drawing.Size(715, 66);
            this.dataGridView2.TabIndex = 20;
            // 
            // dataGridView3
            // 
            this.dataGridView3.AllowUserToAddRows = false;
            this.dataGridView3.AllowUserToDeleteRows = false;
            this.dataGridView3.AllowUserToResizeColumns = false;
            this.dataGridView3.AllowUserToResizeRows = false;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView3.Location = new System.Drawing.Point(32, 430);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.ReadOnly = true;
            this.dataGridView3.RowHeadersVisible = false;
            this.dataGridView3.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView3.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridView3.Size = new System.Drawing.Size(715, 66);
            this.dataGridView3.TabIndex = 21;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 174);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 22;
            this.label5.Text = "Массив 1";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(30, 277);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 23;
            this.label6.Text = "Массив 2";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label7.Location = new System.Drawing.Point(33, 412);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(15, 15);
            this.label7.TabIndex = 24;
            this.label7.Text = "  ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(800, 562);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.numericUpDown2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Обработка массивов";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem вычислитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem суммаЭлементовToolStripMenuItem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ToolStripMenuItem сложениеМассивовToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem вычитаниеМассивовToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сортировкаПоложительныхЭлтовToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem настройкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem изменитьЦветФонаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem изменитьШрифтToolStripMenuItem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ToolStripMenuItem суммаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem количествоToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem массивToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem массивToolStripMenuItem1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.ToolStripMenuItem массив2МассивToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem массив1МассивToolStripMenuItem;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ColorDialog colorDialog1;
    }
}

