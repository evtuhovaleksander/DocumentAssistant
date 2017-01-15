namespace DocumentAssistant
{
    partial class CompareForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.get_File = new System.Windows.Forms.Button();
            this.stop_Tbox = new System.Windows.Forms.TextBox();
            this.start_Tbox = new System.Windows.Forms.TextBox();
            this.base_and_xls_dgv = new System.Windows.Forms.DataGridView();
            this.Serial2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.base_only_dgv = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xls_only_dgv = new System.Windows.Forms.DataGridView();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Serial1_cm = new System.Windows.Forms.CheckBox();
            this.Serial2_cm = new System.Windows.Forms.CheckBox();
            this.Place_cm = new System.Windows.Forms.CheckBox();
            this.Date_cm = new System.Windows.Forms.CheckBox();
            this.Prise_cm = new System.Windows.Forms.CheckBox();
            this.Mark_cm = new System.Windows.Forms.CheckBox();
            this.Owner_CmBox = new System.Windows.Forms.ComboBox();
            this.OS_CmBox = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.Mark_as_Complete = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.AutoCheck_But = new System.Windows.Forms.Button();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.Check_Start_Stop_Mark = new System.Windows.Forms.Button();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.ExcelBut = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.base_and_xls_dgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.base_only_dgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xls_only_dgv)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.groupBox10.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(19, 30);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(332, 69);
            this.button1.TabIndex = 1;
            this.button1.Text = "Compare";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // get_File
            // 
            this.get_File.Location = new System.Drawing.Point(6, 21);
            this.get_File.Name = "get_File";
            this.get_File.Size = new System.Drawing.Size(421, 73);
            this.get_File.TabIndex = 17;
            this.get_File.Text = "Взять файл";
            this.get_File.UseVisualStyleBackColor = true;
            this.get_File.Click += new System.EventHandler(this.get_File_Click);
            // 
            // stop_Tbox
            // 
            this.stop_Tbox.Enabled = false;
            this.stop_Tbox.Location = new System.Drawing.Point(92, 51);
            this.stop_Tbox.Name = "stop_Tbox";
            this.stop_Tbox.Size = new System.Drawing.Size(100, 22);
            this.stop_Tbox.TabIndex = 14;
            // 
            // start_Tbox
            // 
            this.start_Tbox.Enabled = false;
            this.start_Tbox.Location = new System.Drawing.Point(92, 23);
            this.start_Tbox.Name = "start_Tbox";
            this.start_Tbox.Size = new System.Drawing.Size(100, 22);
            this.start_Tbox.TabIndex = 13;
            // 
            // base_and_xls_dgv
            // 
            this.base_and_xls_dgv.AllowUserToAddRows = false;
            this.base_and_xls_dgv.AllowUserToDeleteRows = false;
            this.base_and_xls_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.base_and_xls_dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Serial2});
            this.base_and_xls_dgv.Location = new System.Drawing.Point(16, 45);
            this.base_and_xls_dgv.Name = "base_and_xls_dgv";
            this.base_and_xls_dgv.ReadOnly = true;
            this.base_and_xls_dgv.RowTemplate.Height = 24;
            this.base_and_xls_dgv.Size = new System.Drawing.Size(283, 671);
            this.base_and_xls_dgv.TabIndex = 18;
            this.base_and_xls_dgv.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.base_and_xls_dgv_CellDoubleClick);
            this.base_and_xls_dgv.DoubleClick += new System.EventHandler(this.base_and_xls_dgv_DoubleClick);
            // 
            // Serial2
            // 
            this.Serial2.HeaderText = "Serial2";
            this.Serial2.Name = "Serial2";
            this.Serial2.ReadOnly = true;
            // 
            // base_only_dgv
            // 
            this.base_only_dgv.AllowUserToAddRows = false;
            this.base_only_dgv.AllowUserToDeleteRows = false;
            this.base_only_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.base_only_dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1});
            this.base_only_dgv.Location = new System.Drawing.Point(339, 45);
            this.base_only_dgv.Name = "base_only_dgv";
            this.base_only_dgv.ReadOnly = true;
            this.base_only_dgv.RowTemplate.Height = 24;
            this.base_only_dgv.Size = new System.Drawing.Size(294, 671);
            this.base_only_dgv.TabIndex = 19;
            this.base_only_dgv.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.base_only_dgv_CellDoubleClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Serial2";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // xls_only_dgv
            // 
            this.xls_only_dgv.AllowUserToAddRows = false;
            this.xls_only_dgv.AllowUserToDeleteRows = false;
            this.xls_only_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.xls_only_dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column2});
            this.xls_only_dgv.Location = new System.Drawing.Point(668, 45);
            this.xls_only_dgv.Name = "xls_only_dgv";
            this.xls_only_dgv.ReadOnly = true;
            this.xls_only_dgv.RowTemplate.Height = 24;
            this.xls_only_dgv.Size = new System.Drawing.Size(294, 671);
            this.xls_only_dgv.TabIndex = 20;
            this.xls_only_dgv.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.xls_only_dgv_CellDoubleClick);
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Serial2";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(129, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 17);
            this.label3.TabIndex = 21;
            this.label3.Text = "Полные пары";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(475, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 17);
            this.label4.TabIndex = 22;
            this.label4.Text = "Только в базе";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(803, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 17);
            this.label5.TabIndex = 23;
            this.label5.Text = "Только в xls";
            // 
            // Serial1_cm
            // 
            this.Serial1_cm.AutoSize = true;
            this.Serial1_cm.Location = new System.Drawing.Point(19, 32);
            this.Serial1_cm.Name = "Serial1_cm";
            this.Serial1_cm.Size = new System.Drawing.Size(74, 21);
            this.Serial1_cm.TabIndex = 24;
            this.Serial1_cm.Text = "Serial1";
            this.Serial1_cm.UseVisualStyleBackColor = true;
            // 
            // Serial2_cm
            // 
            this.Serial2_cm.AutoSize = true;
            this.Serial2_cm.Location = new System.Drawing.Point(19, 59);
            this.Serial2_cm.Name = "Serial2_cm";
            this.Serial2_cm.Size = new System.Drawing.Size(74, 21);
            this.Serial2_cm.TabIndex = 25;
            this.Serial2_cm.Text = "Serial2";
            this.Serial2_cm.UseVisualStyleBackColor = true;
            // 
            // Place_cm
            // 
            this.Place_cm.AutoSize = true;
            this.Place_cm.Location = new System.Drawing.Point(19, 86);
            this.Place_cm.Name = "Place_cm";
            this.Place_cm.Size = new System.Drawing.Size(65, 21);
            this.Place_cm.TabIndex = 26;
            this.Place_cm.Text = "Place";
            this.Place_cm.UseVisualStyleBackColor = true;
            // 
            // Date_cm
            // 
            this.Date_cm.AutoSize = true;
            this.Date_cm.Location = new System.Drawing.Point(19, 140);
            this.Date_cm.Name = "Date_cm";
            this.Date_cm.Size = new System.Drawing.Size(60, 21);
            this.Date_cm.TabIndex = 28;
            this.Date_cm.Text = "Date";
            this.Date_cm.UseVisualStyleBackColor = true;
            // 
            // Prise_cm
            // 
            this.Prise_cm.AutoSize = true;
            this.Prise_cm.Location = new System.Drawing.Point(19, 113);
            this.Prise_cm.Name = "Prise_cm";
            this.Prise_cm.Size = new System.Drawing.Size(62, 21);
            this.Prise_cm.TabIndex = 27;
            this.Prise_cm.Text = "Prise";
            this.Prise_cm.UseVisualStyleBackColor = true;
            // 
            // Mark_cm
            // 
            this.Mark_cm.AutoSize = true;
            this.Mark_cm.Location = new System.Drawing.Point(19, 167);
            this.Mark_cm.Name = "Mark_cm";
            this.Mark_cm.Size = new System.Drawing.Size(61, 21);
            this.Mark_cm.TabIndex = 29;
            this.Mark_cm.Text = "Mark";
            this.Mark_cm.UseVisualStyleBackColor = true;
            // 
            // Owner_CmBox
            // 
            this.Owner_CmBox.FormattingEnabled = true;
            this.Owner_CmBox.Location = new System.Drawing.Point(136, 33);
            this.Owner_CmBox.Name = "Owner_CmBox";
            this.Owner_CmBox.Size = new System.Drawing.Size(188, 24);
            this.Owner_CmBox.TabIndex = 30;
            this.Owner_CmBox.SelectedIndexChanged += new System.EventHandler(this.Owner_CmBox_SelectedIndexChanged);
            // 
            // OS_CmBox
            // 
            this.OS_CmBox.Enabled = false;
            this.OS_CmBox.FormattingEnabled = true;
            this.OS_CmBox.Location = new System.Drawing.Point(136, 64);
            this.OS_CmBox.Name = "OS_CmBox";
            this.OS_CmBox.Size = new System.Drawing.Size(188, 24);
            this.OS_CmBox.TabIndex = 31;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(57, 36);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 17);
            this.label6.TabIndex = 32;
            this.label6.Text = "Владелец";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(102, 67);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(28, 17);
            this.label7.TabIndex = 33;
            this.label7.Text = "ОС";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1579, 770);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(294, 32);
            this.button2.TabIndex = 34;
            this.button2.Text = "Экспорт данных утерянных в базе";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.groupBox1.Controls.Add(this.get_File);
            this.groupBox1.Location = new System.Drawing.Point(12, 87);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(433, 100);
            this.groupBox1.TabIndex = 35;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "2е действие: выбери файл";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.groupBox3.Controls.Add(this.Owner_CmBox);
            this.groupBox3.Controls.Add(this.OS_CmBox);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Location = new System.Drawing.Point(12, 397);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(433, 109);
            this.groupBox3.TabIndex = 37;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "5е действие: Укажи владельца и тип ТМЦ/ОС";
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.groupBox4.Controls.Add(this.Serial1_cm);
            this.groupBox4.Controls.Add(this.Serial2_cm);
            this.groupBox4.Controls.Add(this.Place_cm);
            this.groupBox4.Controls.Add(this.Prise_cm);
            this.groupBox4.Controls.Add(this.Date_cm);
            this.groupBox4.Controls.Add(this.Mark_cm);
            this.groupBox4.Location = new System.Drawing.Point(12, 512);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(433, 202);
            this.groupBox4.TabIndex = 38;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "6е действие: Укажи параметры сравнения";
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.groupBox5.Controls.Add(this.button1);
            this.groupBox5.Location = new System.Drawing.Point(12, 720);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(433, 112);
            this.groupBox5.TabIndex = 39;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "7е действие:  СРАВНИ";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.base_and_xls_dgv);
            this.groupBox6.Controls.Add(this.base_only_dgv);
            this.groupBox6.Controls.Add(this.xls_only_dgv);
            this.groupBox6.Controls.Add(this.label3);
            this.groupBox6.Controls.Add(this.label4);
            this.groupBox6.Controls.Add(this.label5);
            this.groupBox6.Location = new System.Drawing.Point(475, 12);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(991, 732);
            this.groupBox6.TabIndex = 40;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Результаты";
            // 
            // Mark_as_Complete
            // 
            this.Mark_as_Complete.Enabled = false;
            this.Mark_as_Complete.Location = new System.Drawing.Point(911, 770);
            this.Mark_as_Complete.Name = "Mark_as_Complete";
            this.Mark_as_Complete.Size = new System.Drawing.Size(310, 44);
            this.Mark_as_Complete.TabIndex = 41;
            this.Mark_as_Complete.Text = "Пометить полные пары статусом \"СВЕРЕННО\"";
            this.Mark_as_Complete.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Enabled = false;
            this.button3.Location = new System.Drawing.Point(1250, 770);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(294, 44);
            this.button3.TabIndex = 42;
            this.button3.Text = "Пометить данные хранимые только в базе статусом \"Ушло из ведомости\"";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Enabled = false;
            this.button4.Location = new System.Drawing.Point(1250, 820);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(294, 29);
            this.button4.TabIndex = 43;
            this.button4.Text = "Экспорт данных утерянных в ведомости";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // groupBox7
            // 
            this.groupBox7.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.groupBox7.Controls.Add(this.AutoCheck_But);
            this.groupBox7.Location = new System.Drawing.Point(12, 315);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(433, 76);
            this.groupBox7.TabIndex = 47;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "4е действие: Авто проверка";
            // 
            // AutoCheck_But
            // 
            this.AutoCheck_But.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.AutoCheck_But.Location = new System.Drawing.Point(13, 21);
            this.AutoCheck_But.Name = "AutoCheck_But";
            this.AutoCheck_But.Size = new System.Drawing.Size(331, 43);
            this.AutoCheck_But.TabIndex = 12;
            this.AutoCheck_But.Text = "Автопроверка";
            this.AutoCheck_But.UseVisualStyleBackColor = false;
            this.AutoCheck_But.Click += new System.EventHandler(this.AutoCheck_But_Click);
            // 
            // groupBox8
            // 
            this.groupBox8.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.groupBox8.Controls.Add(this.groupBox9);
            this.groupBox8.Controls.Add(this.Check_Start_Stop_Mark);
            this.groupBox8.Location = new System.Drawing.Point(12, 193);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(433, 116);
            this.groupBox8.TabIndex = 45;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "3е действие: Укажи в каком диапазоне сканировать xls документ";
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.start_Tbox);
            this.groupBox9.Controls.Add(this.stop_Tbox);
            this.groupBox9.Controls.Add(this.label8);
            this.groupBox9.Controls.Add(this.textBox1);
            this.groupBox9.Controls.Add(this.label9);
            this.groupBox9.Controls.Add(this.textBox2);
            this.groupBox9.Location = new System.Drawing.Point(227, 24);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(200, 86);
            this.groupBox9.TabIndex = 22;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "Индексы";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 26);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 17);
            this.label8.TabIndex = 4;
            this.label8.Text = "Start Index";
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(92, 23);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 54);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(74, 17);
            this.label9.TabIndex = 5;
            this.label9.Text = "Stop Index";
            // 
            // textBox2
            // 
            this.textBox2.Enabled = false;
            this.textBox2.Location = new System.Drawing.Point(92, 51);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 22);
            this.textBox2.TabIndex = 2;
            // 
            // Check_Start_Stop_Mark
            // 
            this.Check_Start_Stop_Mark.Location = new System.Drawing.Point(6, 42);
            this.Check_Start_Stop_Mark.Name = "Check_Start_Stop_Mark";
            this.Check_Start_Stop_Mark.Size = new System.Drawing.Size(198, 55);
            this.Check_Start_Stop_Mark.TabIndex = 6;
            this.Check_Start_Stop_Mark.Text = "Проверить наличие маркеров ";
            this.Check_Start_Stop_Mark.UseVisualStyleBackColor = true;
            this.Check_Start_Stop_Mark.Click += new System.EventHandler(this.Check_Start_Stop_Mark_Click);
            // 
            // groupBox10
            // 
            this.groupBox10.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.groupBox10.Controls.Add(this.ExcelBut);
            this.groupBox10.Location = new System.Drawing.Point(12, 12);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Size = new System.Drawing.Size(433, 69);
            this.groupBox10.TabIndex = 46;
            this.groupBox10.TabStop = false;
            this.groupBox10.Text = "1е действие: Проверь процессы незакрытых Excel программ";
            // 
            // ExcelBut
            // 
            this.ExcelBut.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ExcelBut.Location = new System.Drawing.Point(34, 21);
            this.ExcelBut.Name = "ExcelBut";
            this.ExcelBut.Size = new System.Drawing.Size(368, 33);
            this.ExcelBut.TabIndex = 12;
            this.ExcelBut.Text = "УБЕДИСЬ ЧТО ЗАКРЫТЫ ВСЕ ПРОЦЕССЫ EXCELL";
            this.ExcelBut.UseVisualStyleBackColor = false;
            // 
            // CompareForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1914, 889);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.groupBox8);
            this.Controls.Add(this.Mark_as_Complete);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox10);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button2);
            this.Name = "CompareForm";
            this.Text = "CompareForm";
            this.Load += new System.EventHandler(this.CompareForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.base_and_xls_dgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.base_only_dgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xls_only_dgv)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox8.ResumeLayout(false);
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            this.groupBox10.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button get_File;
        private System.Windows.Forms.TextBox stop_Tbox;
        private System.Windows.Forms.TextBox start_Tbox;
        private System.Windows.Forms.DataGridView base_and_xls_dgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn Serial2;
        private System.Windows.Forms.DataGridView base_only_dgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridView xls_only_dgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox Serial1_cm;
        private System.Windows.Forms.CheckBox Serial2_cm;
        private System.Windows.Forms.CheckBox Place_cm;
        private System.Windows.Forms.CheckBox Date_cm;
        private System.Windows.Forms.CheckBox Prise_cm;
        private System.Windows.Forms.CheckBox Mark_cm;
        private System.Windows.Forms.ComboBox Owner_CmBox;
        private System.Windows.Forms.ComboBox OS_CmBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button Mark_as_Complete;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Button AutoCheck_But;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button Check_Start_Stop_Mark;
        private System.Windows.Forms.GroupBox groupBox10;
        private System.Windows.Forms.Button ExcelBut;
    }
}