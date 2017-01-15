namespace DocumentAssistant
{
    partial class CheckType
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
            this.dgv = new System.Windows.Forms.DataGridView();
            this.Val = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.basecol = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.start_Tbox = new System.Windows.Forms.TextBox();
            this.stop_Tbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Check_Type_But = new System.Windows.Forms.Button();
            this.Check_Mark_But = new System.Windows.Forms.Button();
            this.Check_Status_But = new System.Windows.Forms.Button();
            this.Check_Place_But = new System.Windows.Forms.Button();
            this.get_File = new System.Windows.Forms.Button();
            this.check_GrBox = new System.Windows.Forms.GroupBox();
            this.check_OS = new System.Windows.Forms.Button();
            this.Check_Owner = new System.Windows.Forms.Button();
            this.Place2_Check = new System.Windows.Forms.Button();
            this.FillBase = new System.Windows.Forms.Button();
            this.XLS_Rbut = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.ExcelBut = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.Check_Start_Stop_Mark = new System.Windows.Forms.Button();
            this.update_GrBox = new System.Windows.Forms.GroupBox();
            this.Update_OS_But = new System.Windows.Forms.Button();
            this.Update_Owner_But = new System.Windows.Forms.Button();
            this.Update_Place2_But = new System.Windows.Forms.Button();
            this.Update_Type_But = new System.Windows.Forms.Button();
            this.Update_Place_But = new System.Windows.Forms.Button();
            this.Update_Mark_But = new System.Windows.Forms.Button();
            this.Update_Status_But = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.AutoCheck_But = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.check_GrBox.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.update_GrBox.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Val,
            this.basecol});
            this.dgv.Location = new System.Drawing.Point(346, 10);
            this.dgv.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgv.Name = "dgv";
            this.dgv.RowTemplate.Height = 24;
            this.dgv.Size = new System.Drawing.Size(1071, 788);
            this.dgv.TabIndex = 0;
            // 
            // Val
            // 
            this.Val.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Val.HeaderText = "Value";
            this.Val.Name = "Val";
            // 
            // basecol
            // 
            this.basecol.HeaderText = "Выбери соответствие из базы";
            this.basecol.Name = "basecol";
            this.basecol.Width = 400;
            // 
            // start_Tbox
            // 
            this.start_Tbox.Enabled = false;
            this.start_Tbox.Location = new System.Drawing.Point(69, 19);
            this.start_Tbox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.start_Tbox.Name = "start_Tbox";
            this.start_Tbox.Size = new System.Drawing.Size(76, 20);
            this.start_Tbox.TabIndex = 1;
            // 
            // stop_Tbox
            // 
            this.stop_Tbox.Enabled = false;
            this.stop_Tbox.Location = new System.Drawing.Point(69, 41);
            this.stop_Tbox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.stop_Tbox.Name = "stop_Tbox";
            this.stop_Tbox.Size = new System.Drawing.Size(76, 20);
            this.stop_Tbox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 21);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Start Index";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 44);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Stop Index";
            // 
            // Check_Type_But
            // 
            this.Check_Type_But.Location = new System.Drawing.Point(4, 17);
            this.Check_Type_But.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Check_Type_But.Name = "Check_Type_But";
            this.Check_Type_But.Size = new System.Drawing.Size(160, 33);
            this.Check_Type_But.TabIndex = 8;
            this.Check_Type_But.Text = "Check Type";
            this.Check_Type_But.UseVisualStyleBackColor = true;
            this.Check_Type_But.Click += new System.EventHandler(this.Check_Type_But_Click);
            // 
            // Check_Mark_But
            // 
            this.Check_Mark_But.Location = new System.Drawing.Point(4, 55);
            this.Check_Mark_But.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Check_Mark_But.Name = "Check_Mark_But";
            this.Check_Mark_But.Size = new System.Drawing.Size(160, 33);
            this.Check_Mark_But.TabIndex = 9;
            this.Check_Mark_But.Text = "Check Mark";
            this.Check_Mark_But.UseVisualStyleBackColor = true;
            this.Check_Mark_But.Click += new System.EventHandler(this.Check_Mark_But_Click);
            // 
            // Check_Status_But
            // 
            this.Check_Status_But.Location = new System.Drawing.Point(4, 93);
            this.Check_Status_But.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Check_Status_But.Name = "Check_Status_But";
            this.Check_Status_But.Size = new System.Drawing.Size(160, 33);
            this.Check_Status_But.TabIndex = 10;
            this.Check_Status_But.Text = "Check Status";
            this.Check_Status_But.UseVisualStyleBackColor = true;
            this.Check_Status_But.Click += new System.EventHandler(this.Check_Status_But_Click);
            // 
            // Check_Place_But
            // 
            this.Check_Place_But.Location = new System.Drawing.Point(4, 132);
            this.Check_Place_But.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Check_Place_But.Name = "Check_Place_But";
            this.Check_Place_But.Size = new System.Drawing.Size(160, 33);
            this.Check_Place_But.TabIndex = 11;
            this.Check_Place_But.Text = "Check Place";
            this.Check_Place_But.UseVisualStyleBackColor = true;
            this.Check_Place_But.Click += new System.EventHandler(this.Check_Place_But_Click);
            // 
            // get_File
            // 
            this.get_File.Location = new System.Drawing.Point(4, 17);
            this.get_File.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.get_File.Name = "get_File";
            this.get_File.Size = new System.Drawing.Size(316, 57);
            this.get_File.TabIndex = 12;
            this.get_File.Text = "Взять файл";
            this.get_File.UseVisualStyleBackColor = true;
            this.get_File.Click += new System.EventHandler(this.get_File_Click);
            // 
            // check_GrBox
            // 
            this.check_GrBox.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.check_GrBox.Controls.Add(this.check_OS);
            this.check_GrBox.Controls.Add(this.Check_Owner);
            this.check_GrBox.Controls.Add(this.Place2_Check);
            this.check_GrBox.Controls.Add(this.Check_Type_But);
            this.check_GrBox.Controls.Add(this.Check_Place_But);
            this.check_GrBox.Controls.Add(this.Check_Mark_But);
            this.check_GrBox.Controls.Add(this.Check_Status_But);
            this.check_GrBox.Enabled = false;
            this.check_GrBox.Location = new System.Drawing.Point(9, 442);
            this.check_GrBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.check_GrBox.Name = "check_GrBox";
            this.check_GrBox.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.check_GrBox.Size = new System.Drawing.Size(169, 286);
            this.check_GrBox.TabIndex = 13;
            this.check_GrBox.TabStop = false;
            this.check_GrBox.Text = "6е действие:  Сверяй данные";
            // 
            // check_OS
            // 
            this.check_OS.Location = new System.Drawing.Point(4, 244);
            this.check_OS.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.check_OS.Name = "check_OS";
            this.check_OS.Size = new System.Drawing.Size(160, 33);
            this.check_OS.TabIndex = 14;
            this.check_OS.Text = "Check OS";
            this.check_OS.UseVisualStyleBackColor = true;
            this.check_OS.Click += new System.EventHandler(this.check_OS_Click);
            // 
            // Check_Owner
            // 
            this.Check_Owner.Location = new System.Drawing.Point(4, 206);
            this.Check_Owner.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Check_Owner.Name = "Check_Owner";
            this.Check_Owner.Size = new System.Drawing.Size(160, 33);
            this.Check_Owner.TabIndex = 13;
            this.Check_Owner.Text = "Check Owner";
            this.Check_Owner.UseVisualStyleBackColor = true;
            this.Check_Owner.Click += new System.EventHandler(this.Check_Owner_Click);
            // 
            // Place2_Check
            // 
            this.Place2_Check.Location = new System.Drawing.Point(4, 170);
            this.Place2_Check.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Place2_Check.Name = "Place2_Check";
            this.Place2_Check.Size = new System.Drawing.Size(160, 33);
            this.Place2_Check.TabIndex = 12;
            this.Place2_Check.Text = "Check Place2";
            this.Place2_Check.UseVisualStyleBackColor = true;
            this.Place2_Check.Click += new System.EventHandler(this.Place2_Check_Click);
            // 
            // FillBase
            // 
            this.FillBase.Location = new System.Drawing.Point(189, 756);
            this.FillBase.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.FillBase.Name = "FillBase";
            this.FillBase.Size = new System.Drawing.Size(148, 24);
            this.FillBase.TabIndex = 14;
            this.FillBase.Text = "FillBase";
            this.FillBase.UseVisualStyleBackColor = true;
            this.FillBase.Click += new System.EventHandler(this.FillBase_Click);
            // 
            // XLS_Rbut
            // 
            this.XLS_Rbut.AutoSize = true;
            this.XLS_Rbut.Location = new System.Drawing.Point(13, 28);
            this.XLS_Rbut.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.XLS_Rbut.Name = "XLS_Rbut";
            this.XLS_Rbut.Size = new System.Drawing.Size(73, 17);
            this.XLS_Rbut.TabIndex = 15;
            this.XLS_Rbut.Text = "XLS типы";
            this.XLS_Rbut.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(13, 50);
            this.radioButton1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(77, 17);
            this.radioButton1.TabIndex = 16;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Base типы";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.groupBox2.Controls.Add(this.XLS_Rbut);
            this.groupBox2.Controls.Add(this.radioButton1);
            this.groupBox2.Location = new System.Drawing.Point(9, 10);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Size = new System.Drawing.Size(325, 79);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "1е действие: Выбери сверяешь базовые типы или типы xls";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.groupBox3.Controls.Add(this.get_File);
            this.groupBox3.Location = new System.Drawing.Point(9, 173);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox3.Size = new System.Drawing.Size(325, 79);
            this.groupBox3.TabIndex = 19;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "3е действие: Выбери xls файл";
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.groupBox4.Controls.Add(this.ExcelBut);
            this.groupBox4.Location = new System.Drawing.Point(9, 101);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox4.Size = new System.Drawing.Size(325, 56);
            this.groupBox4.TabIndex = 20;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "2е действие: Проверь процессы незакрытых Excel программ";
            // 
            // ExcelBut
            // 
            this.ExcelBut.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ExcelBut.Location = new System.Drawing.Point(26, 17);
            this.ExcelBut.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ExcelBut.Name = "ExcelBut";
            this.ExcelBut.Size = new System.Drawing.Size(276, 27);
            this.ExcelBut.TabIndex = 12;
            this.ExcelBut.Text = "УБЕДИСЬ ЧТО ЗАКРЫТЫ ВСЕ ПРОЦЕССЫ EXCELL";
            this.ExcelBut.UseVisualStyleBackColor = false;
            this.ExcelBut.Click += new System.EventHandler(this.ExcelBut_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.groupBox5.Controls.Add(this.groupBox6);
            this.groupBox5.Controls.Add(this.Check_Start_Stop_Mark);
            this.groupBox5.Location = new System.Drawing.Point(9, 262);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox5.Size = new System.Drawing.Size(325, 94);
            this.groupBox5.TabIndex = 20;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "4е действие: Укажи в каком диапазоне сканировать xls документ";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.label1);
            this.groupBox6.Controls.Add(this.start_Tbox);
            this.groupBox6.Controls.Add(this.label2);
            this.groupBox6.Controls.Add(this.stop_Tbox);
            this.groupBox6.Location = new System.Drawing.Point(170, 20);
            this.groupBox6.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox6.Size = new System.Drawing.Size(150, 70);
            this.groupBox6.TabIndex = 22;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Индексы";
            // 
            // Check_Start_Stop_Mark
            // 
            this.Check_Start_Stop_Mark.Location = new System.Drawing.Point(4, 34);
            this.Check_Start_Stop_Mark.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Check_Start_Stop_Mark.Name = "Check_Start_Stop_Mark";
            this.Check_Start_Stop_Mark.Size = new System.Drawing.Size(148, 45);
            this.Check_Start_Stop_Mark.TabIndex = 6;
            this.Check_Start_Stop_Mark.Text = "Проверить наличие маркеров ";
            this.Check_Start_Stop_Mark.UseVisualStyleBackColor = true;
            this.Check_Start_Stop_Mark.Click += new System.EventHandler(this.Check_Start_Stop_Mark_Click);
            // 
            // update_GrBox
            // 
            this.update_GrBox.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.update_GrBox.Controls.Add(this.Update_OS_But);
            this.update_GrBox.Controls.Add(this.Update_Owner_But);
            this.update_GrBox.Controls.Add(this.Update_Place2_But);
            this.update_GrBox.Controls.Add(this.Update_Type_But);
            this.update_GrBox.Controls.Add(this.Update_Place_But);
            this.update_GrBox.Controls.Add(this.Update_Mark_But);
            this.update_GrBox.Controls.Add(this.Update_Status_But);
            this.update_GrBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.update_GrBox.Location = new System.Drawing.Point(182, 444);
            this.update_GrBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.update_GrBox.Name = "update_GrBox";
            this.update_GrBox.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.update_GrBox.Size = new System.Drawing.Size(160, 286);
            this.update_GrBox.TabIndex = 15;
            this.update_GrBox.TabStop = false;
            this.update_GrBox.Text = "7е действие:  Обновляй данные";
            // 
            // Update_OS_But
            // 
            this.Update_OS_But.Enabled = false;
            this.Update_OS_But.Location = new System.Drawing.Point(4, 244);
            this.Update_OS_But.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Update_OS_But.Name = "Update_OS_But";
            this.Update_OS_But.Size = new System.Drawing.Size(147, 33);
            this.Update_OS_But.TabIndex = 14;
            this.Update_OS_But.Text = "Обновить OS";
            this.Update_OS_But.UseVisualStyleBackColor = true;
            this.Update_OS_But.Click += new System.EventHandler(this.Update_OS_But_Click);
            // 
            // Update_Owner_But
            // 
            this.Update_Owner_But.Enabled = false;
            this.Update_Owner_But.Location = new System.Drawing.Point(4, 206);
            this.Update_Owner_But.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Update_Owner_But.Name = "Update_Owner_But";
            this.Update_Owner_But.Size = new System.Drawing.Size(147, 33);
            this.Update_Owner_But.TabIndex = 13;
            this.Update_Owner_But.Text = "Обновить Owner";
            this.Update_Owner_But.UseVisualStyleBackColor = true;
            this.Update_Owner_But.Click += new System.EventHandler(this.Update_Owner_But_Click);
            // 
            // Update_Place2_But
            // 
            this.Update_Place2_But.Enabled = false;
            this.Update_Place2_But.Location = new System.Drawing.Point(4, 170);
            this.Update_Place2_But.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Update_Place2_But.Name = "Update_Place2_But";
            this.Update_Place2_But.Size = new System.Drawing.Size(147, 33);
            this.Update_Place2_But.TabIndex = 12;
            this.Update_Place2_But.Text = "Обновить Place2";
            this.Update_Place2_But.UseVisualStyleBackColor = true;
            this.Update_Place2_But.Click += new System.EventHandler(this.Update_Place2_But_Click);
            // 
            // Update_Type_But
            // 
            this.Update_Type_But.Enabled = false;
            this.Update_Type_But.Location = new System.Drawing.Point(4, 17);
            this.Update_Type_But.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Update_Type_But.Name = "Update_Type_But";
            this.Update_Type_But.Size = new System.Drawing.Size(147, 33);
            this.Update_Type_But.TabIndex = 8;
            this.Update_Type_But.Text = "Обновить Type";
            this.Update_Type_But.UseVisualStyleBackColor = true;
            this.Update_Type_But.Click += new System.EventHandler(this.Update_Type_But_Click);
            // 
            // Update_Place_But
            // 
            this.Update_Place_But.Enabled = false;
            this.Update_Place_But.Location = new System.Drawing.Point(4, 132);
            this.Update_Place_But.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Update_Place_But.Name = "Update_Place_But";
            this.Update_Place_But.Size = new System.Drawing.Size(147, 33);
            this.Update_Place_But.TabIndex = 11;
            this.Update_Place_But.Text = "Обновить Place";
            this.Update_Place_But.UseVisualStyleBackColor = true;
            this.Update_Place_But.Click += new System.EventHandler(this.Update_Place_But_Click);
            // 
            // Update_Mark_But
            // 
            this.Update_Mark_But.Enabled = false;
            this.Update_Mark_But.Location = new System.Drawing.Point(4, 55);
            this.Update_Mark_But.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Update_Mark_But.Name = "Update_Mark_But";
            this.Update_Mark_But.Size = new System.Drawing.Size(147, 33);
            this.Update_Mark_But.TabIndex = 9;
            this.Update_Mark_But.Text = "Обновить Mark";
            this.Update_Mark_But.UseVisualStyleBackColor = true;
            this.Update_Mark_But.Click += new System.EventHandler(this.Update_Mark_But_Click);
            // 
            // Update_Status_But
            // 
            this.Update_Status_But.Enabled = false;
            this.Update_Status_But.Location = new System.Drawing.Point(4, 93);
            this.Update_Status_But.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Update_Status_But.Name = "Update_Status_But";
            this.Update_Status_But.Size = new System.Drawing.Size(147, 33);
            this.Update_Status_But.TabIndex = 10;
            this.Update_Status_But.Text = "Обновить Status";
            this.Update_Status_But.UseVisualStyleBackColor = true;
            this.Update_Status_But.Click += new System.EventHandler(this.Update_Status_But_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.groupBox1.Controls.Add(this.AutoCheck_But);
            this.groupBox1.Location = new System.Drawing.Point(9, 370);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(325, 62);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "5е действие: Авто проверка";
            // 
            // AutoCheck_But
            // 
            this.AutoCheck_But.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.AutoCheck_But.Location = new System.Drawing.Point(45, 17);
            this.AutoCheck_But.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.AutoCheck_But.Name = "AutoCheck_But";
            this.AutoCheck_But.Size = new System.Drawing.Size(248, 35);
            this.AutoCheck_But.TabIndex = 12;
            this.AutoCheck_But.Text = "Автопроверка";
            this.AutoCheck_But.UseVisualStyleBackColor = false;
            this.AutoCheck_But.Click += new System.EventHandler(this.AutoCheck_But_Click);
            // 
            // CheckType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1426, 808);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.update_GrBox);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.FillBase);
            this.Controls.Add(this.check_GrBox);
            this.Controls.Add(this.dgv);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "CheckType";
            this.Text = "CheckType";
            this.Load += new System.EventHandler(this.CheckType_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.check_GrBox.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.update_GrBox.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.TextBox start_Tbox;
        private System.Windows.Forms.TextBox stop_Tbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Check_Type_But;
        private System.Windows.Forms.Button Check_Mark_But;
        private System.Windows.Forms.Button Check_Status_But;
        private System.Windows.Forms.Button Check_Place_But;
        private System.Windows.Forms.Button get_File;
        private System.Windows.Forms.GroupBox check_GrBox;
        private System.Windows.Forms.Button FillBase;
        private System.Windows.Forms.RadioButton XLS_Rbut;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Button check_OS;
        private System.Windows.Forms.Button Check_Owner;
        private System.Windows.Forms.Button Place2_Check;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button ExcelBut;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Val;
        private System.Windows.Forms.DataGridViewComboBoxColumn basecol;
        private System.Windows.Forms.GroupBox update_GrBox;
        private System.Windows.Forms.Button Update_OS_But;
        private System.Windows.Forms.Button Update_Owner_But;
        private System.Windows.Forms.Button Update_Place2_But;
        private System.Windows.Forms.Button Update_Type_But;
        private System.Windows.Forms.Button Update_Place_But;
        private System.Windows.Forms.Button Update_Mark_But;
        private System.Windows.Forms.Button Update_Status_But;
        private System.Windows.Forms.Button Check_Start_Stop_Mark;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button AutoCheck_But;
        private System.Windows.Forms.GroupBox groupBox6;
    }
}