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
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Val});
            this.dgv.Location = new System.Drawing.Point(12, 12);
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.RowTemplate.Height = 24;
            this.dgv.Size = new System.Drawing.Size(256, 476);
            this.dgv.TabIndex = 0;
            // 
            // Val
            // 
            this.Val.HeaderText = "Value";
            this.Val.Name = "Val";
            this.Val.ReadOnly = true;
            // 
            // start_Tbox
            // 
            this.start_Tbox.Location = new System.Drawing.Point(360, 12);
            this.start_Tbox.Name = "start_Tbox";
            this.start_Tbox.Size = new System.Drawing.Size(100, 22);
            this.start_Tbox.TabIndex = 1;
            this.start_Tbox.Text = "1";
            // 
            // stop_Tbox
            // 
            this.stop_Tbox.Location = new System.Drawing.Point(360, 40);
            this.stop_Tbox.Name = "stop_Tbox";
            this.stop_Tbox.Size = new System.Drawing.Size(100, 22);
            this.stop_Tbox.TabIndex = 2;
            this.stop_Tbox.Text = "5";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(274, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Start Index";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(274, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Stop Index";
            // 
            // Check_Type_But
            // 
            this.Check_Type_But.Location = new System.Drawing.Point(277, 96);
            this.Check_Type_But.Name = "Check_Type_But";
            this.Check_Type_But.Size = new System.Drawing.Size(121, 41);
            this.Check_Type_But.TabIndex = 8;
            this.Check_Type_But.Text = "Check Type";
            this.Check_Type_But.UseVisualStyleBackColor = true;
            this.Check_Type_But.Click += new System.EventHandler(this.Check_Type_But_Click);
            // 
            // Check_Mark_But
            // 
            this.Check_Mark_But.Location = new System.Drawing.Point(277, 143);
            this.Check_Mark_But.Name = "Check_Mark_But";
            this.Check_Mark_But.Size = new System.Drawing.Size(121, 41);
            this.Check_Mark_But.TabIndex = 9;
            this.Check_Mark_But.Text = "Check Mark";
            this.Check_Mark_But.UseVisualStyleBackColor = true;
            // 
            // Check_Status_But
            // 
            this.Check_Status_But.Location = new System.Drawing.Point(277, 190);
            this.Check_Status_But.Name = "Check_Status_But";
            this.Check_Status_But.Size = new System.Drawing.Size(121, 41);
            this.Check_Status_But.TabIndex = 10;
            this.Check_Status_But.Text = "Check Status";
            this.Check_Status_But.UseVisualStyleBackColor = true;
            // 
            // Check_Place_But
            // 
            this.Check_Place_But.Location = new System.Drawing.Point(277, 237);
            this.Check_Place_But.Name = "Check_Place_But";
            this.Check_Place_But.Size = new System.Drawing.Size(121, 41);
            this.Check_Place_But.TabIndex = 11;
            this.Check_Place_But.Text = "Check Place";
            this.Check_Place_But.UseVisualStyleBackColor = true;
            // 
            // get_File
            // 
            this.get_File.Location = new System.Drawing.Point(404, 96);
            this.get_File.Name = "get_File";
            this.get_File.Size = new System.Drawing.Size(149, 41);
            this.get_File.TabIndex = 12;
            this.get_File.Text = "get_File";
            this.get_File.UseVisualStyleBackColor = true;
            this.get_File.Click += new System.EventHandler(this.get_File_Click);
            // 
            // CheckType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 500);
            this.Controls.Add(this.get_File);
            this.Controls.Add(this.Check_Place_But);
            this.Controls.Add(this.Check_Status_But);
            this.Controls.Add(this.Check_Mark_But);
            this.Controls.Add(this.Check_Type_But);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.stop_Tbox);
            this.Controls.Add(this.start_Tbox);
            this.Controls.Add(this.dgv);
            this.Name = "CheckType";
            this.Text = "CheckType";
            this.Load += new System.EventHandler(this.CheckType_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn Val;
        private System.Windows.Forms.TextBox start_Tbox;
        private System.Windows.Forms.TextBox stop_Tbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Check_Type_But;
        private System.Windows.Forms.Button Check_Mark_But;
        private System.Windows.Forms.Button Check_Status_But;
        private System.Windows.Forms.Button Check_Place_But;
        private System.Windows.Forms.Button get_File;
    }
}