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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.base_and_xls_dgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.base_only_dgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xls_only_dgv)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(19, 30);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(332, 153);
            this.button1.TabIndex = 1;
            this.button1.Text = "Compare";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // get_File
            // 
            this.get_File.Location = new System.Drawing.Point(42, 31);
            this.get_File.Name = "get_File";
            this.get_File.Size = new System.Drawing.Size(110, 50);
            this.get_File.TabIndex = 17;
            this.get_File.Text = "get_File";
            this.get_File.UseVisualStyleBackColor = true;
            this.get_File.Click += new System.EventHandler(this.get_File_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(65, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 17);
            this.label2.TabIndex = 16;
            this.label2.Text = "Stop Index";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(65, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 17);
            this.label1.TabIndex = 15;
            this.label1.Text = "Start Index";
            // 
            // stop_Tbox
            // 
            this.stop_Tbox.Location = new System.Drawing.Point(151, 70);
            this.stop_Tbox.Name = "stop_Tbox";
            this.stop_Tbox.Size = new System.Drawing.Size(100, 22);
            this.stop_Tbox.TabIndex = 14;
            this.stop_Tbox.Text = "5";
            // 
            // start_Tbox
            // 
            this.start_Tbox.Location = new System.Drawing.Point(151, 42);
            this.start_Tbox.Name = "start_Tbox";
            this.start_Tbox.Size = new System.Drawing.Size(100, 22);
            this.start_Tbox.TabIndex = 13;
            this.start_Tbox.Text = "1";
            // 
            // base_and_xls_dgv
            // 
            this.base_and_xls_dgv.AllowUserToAddRows = false;
            this.base_and_xls_dgv.AllowUserToDeleteRows = false;
            this.base_and_xls_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.base_and_xls_dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Serial2});
            this.base_and_xls_dgv.Location = new System.Drawing.Point(445, 131);
            this.base_and_xls_dgv.Name = "base_and_xls_dgv";
            this.base_and_xls_dgv.ReadOnly = true;
            this.base_and_xls_dgv.RowTemplate.Height = 24;
            this.base_and_xls_dgv.Size = new System.Drawing.Size(294, 671);
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
            this.base_only_dgv.Location = new System.Drawing.Point(768, 131);
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
            this.xls_only_dgv.Location = new System.Drawing.Point(1097, 131);
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
            this.label3.Location = new System.Drawing.Point(558, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 17);
            this.label3.TabIndex = 21;
            this.label3.Text = "Полные пары";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(904, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 17);
            this.label4.TabIndex = 22;
            this.label4.Text = "Только в базе";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1232, 104);
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
            this.button2.Location = new System.Drawing.Point(1097, 808);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(294, 55);
            this.button2.TabIndex = 34;
            this.button2.Text = "Экспорт не найденных";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.groupBox1.Controls.Add(this.get_File);
            this.groupBox1.Location = new System.Drawing.Point(106, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 35;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "1е действие: выбери файл";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.groupBox2.Controls.Add(this.start_Tbox);
            this.groupBox2.Controls.Add(this.stop_Tbox);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(12, 131);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(388, 109);
            this.groupBox2.TabIndex = 36;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "2е действие: Укажи рабочий диапазон внутри файла";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.groupBox3.Controls.Add(this.Owner_CmBox);
            this.groupBox3.Controls.Add(this.OS_CmBox);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Location = new System.Drawing.Point(12, 261);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(388, 109);
            this.groupBox3.TabIndex = 37;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "3е действие: Укажи владельца и тип ТМЦ/ОС";
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
            this.groupBox4.Location = new System.Drawing.Point(12, 376);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(388, 202);
            this.groupBox4.TabIndex = 38;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "4е действие: Укажи параметры сравнения";
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.groupBox5.Controls.Add(this.button1);
            this.groupBox5.Location = new System.Drawing.Point(12, 600);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(388, 202);
            this.groupBox5.TabIndex = 39;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "5е действие:  СРАВНИ";
            // 
            // CompareForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1590, 875);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.xls_only_dgv);
            this.Controls.Add(this.base_only_dgv);
            this.Controls.Add(this.base_and_xls_dgv);
            this.Name = "CompareForm";
            this.Text = "CompareForm";
            this.Load += new System.EventHandler(this.CompareForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.base_and_xls_dgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.base_only_dgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xls_only_dgv)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button get_File;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
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
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
    }
}