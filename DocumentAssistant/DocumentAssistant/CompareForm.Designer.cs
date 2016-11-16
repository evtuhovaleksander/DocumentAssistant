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
            ((System.ComponentModel.ISupportInitialize)(this.base_and_xls_dgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.base_only_dgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xls_only_dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(497, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(76, 34);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // get_File
            // 
            this.get_File.Location = new System.Drawing.Point(381, 5);
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
            this.label2.Location = new System.Drawing.Point(189, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 17);
            this.label2.TabIndex = 16;
            this.label2.Text = "Stop Index";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(189, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 17);
            this.label1.TabIndex = 15;
            this.label1.Text = "Start Index";
            // 
            // stop_Tbox
            // 
            this.stop_Tbox.Location = new System.Drawing.Point(275, 33);
            this.stop_Tbox.Name = "stop_Tbox";
            this.stop_Tbox.Size = new System.Drawing.Size(100, 22);
            this.stop_Tbox.TabIndex = 14;
            this.stop_Tbox.Text = "5";
            // 
            // start_Tbox
            // 
            this.start_Tbox.Location = new System.Drawing.Point(275, 5);
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
            this.base_and_xls_dgv.Location = new System.Drawing.Point(12, 123);
            this.base_and_xls_dgv.Name = "base_and_xls_dgv";
            this.base_and_xls_dgv.ReadOnly = true;
            this.base_and_xls_dgv.RowTemplate.Height = 24;
            this.base_and_xls_dgv.Size = new System.Drawing.Size(294, 403);
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
            this.base_only_dgv.Location = new System.Drawing.Point(335, 123);
            this.base_only_dgv.Name = "base_only_dgv";
            this.base_only_dgv.ReadOnly = true;
            this.base_only_dgv.RowTemplate.Height = 24;
            this.base_only_dgv.Size = new System.Drawing.Size(294, 403);
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
            this.xls_only_dgv.Location = new System.Drawing.Point(664, 123);
            this.xls_only_dgv.Name = "xls_only_dgv";
            this.xls_only_dgv.ReadOnly = true;
            this.xls_only_dgv.RowTemplate.Height = 24;
            this.xls_only_dgv.Size = new System.Drawing.Size(294, 403);
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
            this.label3.Location = new System.Drawing.Point(125, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 17);
            this.label3.TabIndex = 21;
            this.label3.Text = "Base and Xls";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(471, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 17);
            this.label4.TabIndex = 22;
            this.label4.Text = "base_only";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(799, 96);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 17);
            this.label5.TabIndex = 23;
            this.label5.Text = "xls_only";
            // 
            // CompareForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1299, 538);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.xls_only_dgv);
            this.Controls.Add(this.base_only_dgv);
            this.Controls.Add(this.base_and_xls_dgv);
            this.Controls.Add(this.get_File);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.stop_Tbox);
            this.Controls.Add(this.start_Tbox);
            this.Controls.Add(this.button1);
            this.Name = "CompareForm";
            this.Text = "CompareForm";
            this.Load += new System.EventHandler(this.CompareForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.base_and_xls_dgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.base_only_dgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xls_only_dgv)).EndInit();
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
    }
}