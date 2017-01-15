﻿namespace DocumentAssistant
{
    partial class HistoryForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.log_dgv = new System.Windows.Forms.DataGridView();
            this.doc_dgv = new System.Windows.Forms.DataGridView();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Add_Doc_But = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.log_dgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.doc_dgv)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.log_dgv);
            this.groupBox1.Location = new System.Drawing.Point(9, 10);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(1768, 376);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // log_dgv
            // 
            this.log_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.log_dgv.Location = new System.Drawing.Point(4, 17);
            this.log_dgv.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.log_dgv.Name = "log_dgv";
            this.log_dgv.RowTemplate.Height = 24;
            this.log_dgv.Size = new System.Drawing.Size(1760, 354);
            this.log_dgv.TabIndex = 0;
            this.log_dgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.log_dgv_CellContentClick);
            // 
            // doc_dgv
            // 
            this.doc_dgv.AllowUserToAddRows = false;
            this.doc_dgv.AllowUserToDeleteRows = false;
            this.doc_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.doc_dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column5,
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.doc_dgv.Location = new System.Drawing.Point(4, 17);
            this.doc_dgv.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.doc_dgv.Name = "doc_dgv";
            this.doc_dgv.ReadOnly = true;
            this.doc_dgv.RowTemplate.Height = 24;
            this.doc_dgv.Size = new System.Drawing.Size(523, 271);
            this.doc_dgv.TabIndex = 1;
            this.doc_dgv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.doc_dgv_CellClick);
           
            // 
            // Column5
            // 
            this.Column5.HeaderText = "ID";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Название";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Открыть";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Изменить";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Удалить";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.doc_dgv);
            this.groupBox2.Location = new System.Drawing.Point(9, 391);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Size = new System.Drawing.Size(532, 292);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // Add_Doc_But
            // 
            this.Add_Doc_But.Location = new System.Drawing.Point(552, 400);
            this.Add_Doc_But.Name = "Add_Doc_But";
            this.Add_Doc_But.Size = new System.Drawing.Size(158, 76);
            this.Add_Doc_But.TabIndex = 3;
            this.Add_Doc_But.Text = "Add cocument";
            this.Add_Doc_But.UseVisualStyleBackColor = true;
            this.Add_Doc_But.Click += new System.EventHandler(this.Add_Doc_But_Click);
            // 
            // HistoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1786, 693);
            this.Controls.Add(this.Add_Doc_But);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "HistoryForm";
            this.Text = "HistoryForm";
            this.Load += new System.EventHandler(this.HistoryForm_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.log_dgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.doc_dgv)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView log_dgv;
        private System.Windows.Forms.DataGridView doc_dgv;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewButtonColumn Column2;
        private System.Windows.Forms.DataGridViewButtonColumn Column3;
        private System.Windows.Forms.DataGridViewButtonColumn Column4;
        private System.Windows.Forms.Button Add_Doc_But;
    }
}