namespace DocumentAssistant
{
    partial class GetDocument
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
            this.ScanBut = new System.Windows.Forms.Button();
            this.Path_grBox = new System.Windows.Forms.GroupBox();
            this.scan_grBox = new System.Windows.Forms.GroupBox();
            this.GetPath_Rbut = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.Path_Path_Tbox = new System.Windows.Forms.TextBox();
            this.Path_GetFile = new System.Windows.Forms.Button();
            this.Path_Name_Tbox = new System.Windows.Forms.TextBox();
            this.Path_Save_But = new System.Windows.Forms.Button();
            this.scan_save_but = new System.Windows.Forms.Button();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.Path_grBox.SuspendLayout();
            this.scan_grBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // ScanBut
            // 
            this.ScanBut.Location = new System.Drawing.Point(15, 28);
            this.ScanBut.Name = "ScanBut";
            this.ScanBut.Size = new System.Drawing.Size(146, 35);
            this.ScanBut.TabIndex = 0;
            this.ScanBut.Text = "Сканировать";
            this.ScanBut.UseVisualStyleBackColor = true;
            this.ScanBut.Click += new System.EventHandler(this.button1_Click);
            // 
            // Path_grBox
            // 
            this.Path_grBox.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Path_grBox.Controls.Add(this.Path_Save_But);
            this.Path_grBox.Controls.Add(this.Path_Name_Tbox);
            this.Path_grBox.Controls.Add(this.Path_GetFile);
            this.Path_grBox.Controls.Add(this.Path_Path_Tbox);
            this.Path_grBox.Location = new System.Drawing.Point(12, 47);
            this.Path_grBox.Name = "Path_grBox";
            this.Path_grBox.Size = new System.Drawing.Size(742, 162);
            this.Path_grBox.TabIndex = 1;
            this.Path_grBox.TabStop = false;
            this.Path_grBox.Text = "Указать путь к документу";
            // 
            // scan_grBox
            // 
            this.scan_grBox.BackColor = System.Drawing.SystemColors.ControlDark;
            this.scan_grBox.Controls.Add(this.scan_save_but);
            this.scan_grBox.Controls.Add(this.pictureBox);
            this.scan_grBox.Controls.Add(this.ScanBut);
            this.scan_grBox.Location = new System.Drawing.Point(760, 48);
            this.scan_grBox.Name = "scan_grBox";
            this.scan_grBox.Size = new System.Drawing.Size(1050, 819);
            this.scan_grBox.TabIndex = 2;
            this.scan_grBox.TabStop = false;
            this.scan_grBox.Text = "Сканировать изображение";
            // 
            // GetPath_Rbut
            // 
            this.GetPath_Rbut.AutoSize = true;
            this.GetPath_Rbut.Checked = true;
            this.GetPath_Rbut.Location = new System.Drawing.Point(341, 20);
            this.GetPath_Rbut.Name = "GetPath_Rbut";
            this.GetPath_Rbut.Size = new System.Drawing.Size(199, 21);
            this.GetPath_Rbut.TabIndex = 3;
            this.GetPath_Rbut.TabStop = true;
            this.GetPath_Rbut.Text = "Указать путь к документу";
            this.GetPath_Rbut.UseVisualStyleBackColor = true;
            this.GetPath_Rbut.CheckedChanged += new System.EventHandler(this.GetPath_Rbut_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(1100, 20);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(206, 21);
            this.radioButton2.TabIndex = 4;
            this.radioButton2.Text = "Сканировать изображение";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // Path_Path_Tbox
            // 
            this.Path_Path_Tbox.Location = new System.Drawing.Point(6, 114);
            this.Path_Path_Tbox.Name = "Path_Path_Tbox";
            this.Path_Path_Tbox.Size = new System.Drawing.Size(730, 22);
            this.Path_Path_Tbox.TabIndex = 0;
            // 
            // Path_GetFile
            // 
            this.Path_GetFile.Location = new System.Drawing.Point(6, 29);
            this.Path_GetFile.Name = "Path_GetFile";
            this.Path_GetFile.Size = new System.Drawing.Size(148, 35);
            this.Path_GetFile.TabIndex = 1;
            this.Path_GetFile.Text = "Get File";
            this.Path_GetFile.UseVisualStyleBackColor = true;
            this.Path_GetFile.Click += new System.EventHandler(this.Path_GetFile_Click);
            // 
            // Path_Name_Tbox
            // 
            this.Path_Name_Tbox.Location = new System.Drawing.Point(6, 86);
            this.Path_Name_Tbox.Name = "Path_Name_Tbox";
            this.Path_Name_Tbox.Size = new System.Drawing.Size(335, 22);
            this.Path_Name_Tbox.TabIndex = 2;
            // 
            // Path_Save_But
            // 
            this.Path_Save_But.Enabled = false;
            this.Path_Save_But.Location = new System.Drawing.Point(6, 142);
            this.Path_Save_But.Name = "Path_Save_But";
            this.Path_Save_But.Size = new System.Drawing.Size(115, 35);
            this.Path_Save_But.TabIndex = 3;
            this.Path_Save_But.Text = "Save";
            this.Path_Save_But.UseVisualStyleBackColor = true;
            this.Path_Save_But.Click += new System.EventHandler(this.Path_Save_But_Click);
            // 
            // scan_save_but
            // 
            this.scan_save_but.Location = new System.Drawing.Point(15, 703);
            this.scan_save_but.Name = "scan_save_but";
            this.scan_save_but.Size = new System.Drawing.Size(107, 27);
            this.scan_save_but.TabIndex = 4;
            this.scan_save_but.Text = "Save";
            this.scan_save_but.UseVisualStyleBackColor = true;
            this.scan_save_but.Click += new System.EventHandler(this.scan_save_but_Click);
            // 
            // pictureBox
            // 
            this.pictureBox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBox.Image = global::DocumentAssistant.Properties.Resources.up;
            this.pictureBox.Location = new System.Drawing.Point(14, 72);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(569, 574);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox.TabIndex = 1;
            this.pictureBox.TabStop = false;
            // 
            // GetDocument
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1822, 891);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.GetPath_Rbut);
            this.Controls.Add(this.scan_grBox);
            this.Controls.Add(this.Path_grBox);
            this.Name = "GetDocument";
            this.Text = "GetDocument";
            this.Path_grBox.ResumeLayout(false);
            this.Path_grBox.PerformLayout();
            this.scan_grBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ScanBut;
        private System.Windows.Forms.GroupBox Path_grBox;
        private System.Windows.Forms.TextBox Path_Path_Tbox;
        private System.Windows.Forms.GroupBox scan_grBox;
        private System.Windows.Forms.RadioButton GetPath_Rbut;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.TextBox Path_Name_Tbox;
        private System.Windows.Forms.Button Path_GetFile;
        private System.Windows.Forms.Button Path_Save_But;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Button scan_save_but;
    }
}