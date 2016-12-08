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
            this.start_Tbox = new System.Windows.Forms.TextBox();
            this.stop_Tbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Check_Type_But = new System.Windows.Forms.Button();
            this.Check_Mark_But = new System.Windows.Forms.Button();
            this.Check_Status_But = new System.Windows.Forms.Button();
            this.Check_Place_But = new System.Windows.Forms.Button();
            this.get_File = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.check_OS = new System.Windows.Forms.Button();
            this.Check_Owner = new System.Windows.Forms.Button();
            this.Place2_Check = new System.Windows.Forms.Button();
            this.FillBase = new System.Windows.Forms.Button();
            this.XLS_Rbut = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Val});
            this.dgv.Location = new System.Drawing.Point(462, 12);
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.RowTemplate.Height = 24;
            this.dgv.Size = new System.Drawing.Size(1065, 970);
            this.dgv.TabIndex = 0;
            // 
            // Val
            // 
            this.Val.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Val.HeaderText = "Value";
            this.Val.Name = "Val";
            this.Val.ReadOnly = true;
            // 
            // start_Tbox
            // 
            this.start_Tbox.Location = new System.Drawing.Point(179, 46);
            this.start_Tbox.Name = "start_Tbox";
            this.start_Tbox.Size = new System.Drawing.Size(100, 22);
            this.start_Tbox.TabIndex = 1;
            this.start_Tbox.Text = "3";
            // 
            // stop_Tbox
            // 
            this.stop_Tbox.Location = new System.Drawing.Point(179, 74);
            this.stop_Tbox.Name = "stop_Tbox";
            this.stop_Tbox.Size = new System.Drawing.Size(100, 22);
            this.stop_Tbox.TabIndex = 2;
            this.stop_Tbox.Text = "475";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(93, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Start Index";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(93, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Stop Index";
            // 
            // Check_Type_But
            // 
            this.Check_Type_But.Location = new System.Drawing.Point(6, 21);
            this.Check_Type_But.Name = "Check_Type_But";
            this.Check_Type_But.Size = new System.Drawing.Size(121, 41);
            this.Check_Type_But.TabIndex = 8;
            this.Check_Type_But.Text = "Check Type";
            this.Check_Type_But.UseVisualStyleBackColor = true;
            this.Check_Type_But.Click += new System.EventHandler(this.Check_Type_But_Click);
            // 
            // Check_Mark_But
            // 
            this.Check_Mark_But.Location = new System.Drawing.Point(6, 68);
            this.Check_Mark_But.Name = "Check_Mark_But";
            this.Check_Mark_But.Size = new System.Drawing.Size(121, 41);
            this.Check_Mark_But.TabIndex = 9;
            this.Check_Mark_But.Text = "Check Mark";
            this.Check_Mark_But.UseVisualStyleBackColor = true;
            this.Check_Mark_But.Click += new System.EventHandler(this.Check_Mark_But_Click);
            // 
            // Check_Status_But
            // 
            this.Check_Status_But.Location = new System.Drawing.Point(6, 115);
            this.Check_Status_But.Name = "Check_Status_But";
            this.Check_Status_But.Size = new System.Drawing.Size(121, 41);
            this.Check_Status_But.TabIndex = 10;
            this.Check_Status_But.Text = "Check Status";
            this.Check_Status_But.UseVisualStyleBackColor = true;
            this.Check_Status_But.Click += new System.EventHandler(this.Check_Status_But_Click);
            // 
            // Check_Place_But
            // 
            this.Check_Place_But.Location = new System.Drawing.Point(6, 162);
            this.Check_Place_But.Name = "Check_Place_But";
            this.Check_Place_But.Size = new System.Drawing.Size(121, 41);
            this.Check_Place_But.TabIndex = 11;
            this.Check_Place_But.Text = "Check Place";
            this.Check_Place_But.UseVisualStyleBackColor = true;
            this.Check_Place_But.Click += new System.EventHandler(this.Check_Place_But_Click);
            // 
            // get_File
            // 
            this.get_File.Location = new System.Drawing.Point(34, 34);
            this.get_File.Name = "get_File";
            this.get_File.Size = new System.Drawing.Size(331, 43);
            this.get_File.TabIndex = 12;
            this.get_File.Text = "Взять файл";
            this.get_File.UseVisualStyleBackColor = true;
            this.get_File.Click += new System.EventHandler(this.get_File_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Controls.Add(this.check_OS);
            this.groupBox1.Controls.Add(this.Check_Owner);
            this.groupBox1.Controls.Add(this.Place2_Check);
            this.groupBox1.Controls.Add(this.Check_Type_But);
            this.groupBox1.Controls.Add(this.Check_Place_But);
            this.groupBox1.Controls.Add(this.Check_Mark_But);
            this.groupBox1.Controls.Add(this.Check_Status_But);
            this.groupBox1.Location = new System.Drawing.Point(12, 445);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(227, 352);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "4е действие:  Сверяй данные";
            // 
            // check_OS
            // 
            this.check_OS.Location = new System.Drawing.Point(6, 300);
            this.check_OS.Name = "check_OS";
            this.check_OS.Size = new System.Drawing.Size(121, 41);
            this.check_OS.TabIndex = 14;
            this.check_OS.Text = "Check OS";
            this.check_OS.UseVisualStyleBackColor = true;
            this.check_OS.Click += new System.EventHandler(this.check_OS_Click);
            // 
            // Check_Owner
            // 
            this.Check_Owner.Location = new System.Drawing.Point(6, 253);
            this.Check_Owner.Name = "Check_Owner";
            this.Check_Owner.Size = new System.Drawing.Size(121, 41);
            this.Check_Owner.TabIndex = 13;
            this.Check_Owner.Text = "Check Owner";
            this.Check_Owner.UseVisualStyleBackColor = true;
            this.Check_Owner.Click += new System.EventHandler(this.Check_Owner_Click);
            // 
            // Place2_Check
            // 
            this.Place2_Check.Location = new System.Drawing.Point(6, 209);
            this.Place2_Check.Name = "Place2_Check";
            this.Place2_Check.Size = new System.Drawing.Size(121, 41);
            this.Place2_Check.TabIndex = 12;
            this.Place2_Check.Text = "Check Place2";
            this.Place2_Check.UseVisualStyleBackColor = true;
            this.Place2_Check.Click += new System.EventHandler(this.Place2_Check_Click);
            // 
            // FillBase
            // 
            this.FillBase.Enabled = false;
            this.FillBase.Location = new System.Drawing.Point(18, 813);
            this.FillBase.Name = "FillBase";
            this.FillBase.Size = new System.Drawing.Size(198, 29);
            this.FillBase.TabIndex = 14;
            this.FillBase.Text = "FillBase";
            this.FillBase.UseVisualStyleBackColor = true;
            this.FillBase.Click += new System.EventHandler(this.FillBase_Click);
            // 
            // XLS_Rbut
            // 
            this.XLS_Rbut.AutoSize = true;
            this.XLS_Rbut.Location = new System.Drawing.Point(17, 34);
            this.XLS_Rbut.Name = "XLS_Rbut";
            this.XLS_Rbut.Size = new System.Drawing.Size(92, 21);
            this.XLS_Rbut.TabIndex = 15;
            this.XLS_Rbut.Text = "XLS типы";
            this.XLS_Rbut.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(17, 62);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(98, 21);
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
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(433, 97);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "1е действие: Выбери сверяешь базовые типы или типы xls";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.groupBox3.Controls.Add(this.get_File);
            this.groupBox3.Location = new System.Drawing.Point(12, 213);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(433, 97);
            this.groupBox3.TabIndex = 19;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "3е действие: Выбери xls файл";
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.groupBox4.Controls.Add(this.button1);
            this.groupBox4.Location = new System.Drawing.Point(12, 124);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(433, 69);
            this.groupBox4.TabIndex = 20;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "2е действие: Проверь себя!!!!";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button1.Location = new System.Drawing.Point(34, 20);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(331, 43);
            this.button1.TabIndex = 12;
            this.button1.Text = "УБЕДИСЬ ЧТО ЗАКРЫТЫ ВСЕ ПРОЦЕССЫ EXCELL";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.groupBox5.Controls.Add(this.start_Tbox);
            this.groupBox5.Controls.Add(this.stop_Tbox);
            this.groupBox5.Controls.Add(this.label1);
            this.groupBox5.Controls.Add(this.label2);
            this.groupBox5.Location = new System.Drawing.Point(12, 323);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(433, 116);
            this.groupBox5.TabIndex = 20;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "4е действие: Укажи в каком диапазоне сканировать xls документ";
            // 
            // CheckType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1539, 994);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.FillBase);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgv);
            this.Name = "CheckType";
            this.Text = "CheckType";
            this.Load += new System.EventHandler(this.CheckType_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
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
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button FillBase;
        private System.Windows.Forms.RadioButton XLS_Rbut;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Val;
        private System.Windows.Forms.Button check_OS;
        private System.Windows.Forms.Button Check_Owner;
        private System.Windows.Forms.Button Place2_Check;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox5;
    }
}