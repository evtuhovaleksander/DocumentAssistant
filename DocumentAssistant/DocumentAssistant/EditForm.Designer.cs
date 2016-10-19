namespace DocumentAssistant
{
    partial class EditForm
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
            this.components = new System.ComponentModel.Container();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.typetableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.documentassistantDataSet = new DocumentAssistant.documentassistantDataSet();
            this.typetableTableAdapter = new DocumentAssistant.documentassistantDataSetTableAdapters.typetableTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.typetableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentassistantDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv
            // 
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(12, 12);
            this.dgv.Name = "dgv";
            this.dgv.RowTemplate.Height = 24;
            this.dgv.Size = new System.Drawing.Size(1063, 241);
            this.dgv.TabIndex = 1;
            // 
            // typetableBindingSource
            // 
            this.typetableBindingSource.DataMember = "typetable";
            this.typetableBindingSource.DataSource = this.documentassistantDataSet;
            // 
            // documentassistantDataSet
            // 
            this.documentassistantDataSet.DataSetName = "documentassistantDataSet";
            this.documentassistantDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // typetableTableAdapter
            // 
            this.typetableTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(14, 267);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // EditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1087, 311);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgv);
            this.Name = "EditForm";
            this.Text = "EditForm";
            this.Load += new System.EventHandler(this.EditForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.typetableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentassistantDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgv;
        private documentassistantDataSet documentassistantDataSet;
        private System.Windows.Forms.BindingSource typetableBindingSource;
        private documentassistantDataSetTableAdapters.typetableTableAdapter typetableTableAdapter;
        private System.Windows.Forms.Button button1;
    }
}