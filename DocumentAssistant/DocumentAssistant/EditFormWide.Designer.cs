namespace DocumentAssistant
{
    partial class EditFormWide
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
            this.SaveChangeBut = new System.Windows.Forms.Button();
            this.typetableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.typetableBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv
            // 
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(12, 12);
            this.dgv.Name = "dgv";
            this.dgv.RowTemplate.Height = 24;
            this.dgv.Size = new System.Drawing.Size(1495, 241);
            this.dgv.TabIndex = 1;
            // 
            // SaveChangeBut
            // 
            this.SaveChangeBut.Location = new System.Drawing.Point(12, 259);
            this.SaveChangeBut.Name = "SaveChangeBut";
            this.SaveChangeBut.Size = new System.Drawing.Size(147, 23);
            this.SaveChangeBut.TabIndex = 2;
            this.SaveChangeBut.Text = "SaveChange";
            this.SaveChangeBut.UseVisualStyleBackColor = true;
            this.SaveChangeBut.Click += new System.EventHandler(this.button1_Click);
            // 
            // EditFormWide
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1519, 529);
            this.Controls.Add(this.SaveChangeBut);
            this.Controls.Add(this.dgv);
            this.Name = "EditFormWide";
            this.Text = "EditForm";
            this.Load += new System.EventHandler(this.EditForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.typetableBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgv;
       
        private System.Windows.Forms.BindingSource typetableBindingSource;
        
        private System.Windows.Forms.Button SaveChangeBut;
    }
}