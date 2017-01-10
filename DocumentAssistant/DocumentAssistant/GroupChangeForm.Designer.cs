namespace DocumentAssistant
{
    partial class GroupChangeForm
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
            this.Acept_but = new System.Windows.Forms.Button();
            this.Cancel_But = new System.Windows.Forms.Button();
            this.cmb = new System.Windows.Forms.ComboBox();
            this.lb = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Acept_but
            // 
            this.Acept_but.Location = new System.Drawing.Point(125, 123);
            this.Acept_but.Name = "Acept_but";
            this.Acept_but.Size = new System.Drawing.Size(123, 28);
            this.Acept_but.TabIndex = 0;
            this.Acept_but.Text = "Acept";
            this.Acept_but.UseVisualStyleBackColor = true;
            this.Acept_but.Click += new System.EventHandler(this.Acept_but_Click);
            // 
            // Cancel_But
            // 
            this.Cancel_But.Location = new System.Drawing.Point(272, 123);
            this.Cancel_But.Name = "Cancel_But";
            this.Cancel_But.Size = new System.Drawing.Size(123, 28);
            this.Cancel_But.TabIndex = 1;
            this.Cancel_But.Text = "Cancel";
            this.Cancel_But.UseVisualStyleBackColor = true;
            this.Cancel_But.Click += new System.EventHandler(this.Cancel_But_Click);
            // 
            // cmb
            // 
            this.cmb.FormattingEnabled = true;
            this.cmb.Location = new System.Drawing.Point(125, 83);
            this.cmb.Name = "cmb";
            this.cmb.Size = new System.Drawing.Size(270, 24);
            this.cmb.TabIndex = 2;
            // 
            // lb
            // 
            this.lb.AutoSize = true;
            this.lb.Location = new System.Drawing.Point(12, 86);
            this.lb.Name = "lb";
            this.lb.Size = new System.Drawing.Size(46, 17);
            this.lb.TabIndex = 3;
            this.lb.Text = "label1";
            // 
            // GroupChangeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 163);
            this.Controls.Add(this.lb);
            this.Controls.Add(this.cmb);
            this.Controls.Add(this.Cancel_But);
            this.Controls.Add(this.Acept_but);
            this.Name = "GroupChangeForm";
            this.Text = "GroupChangeForm";
            this.Load += new System.EventHandler(this.GroupChangeForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Acept_but;
        private System.Windows.Forms.Button Cancel_But;
        private System.Windows.Forms.ComboBox cmb;
        private System.Windows.Forms.Label lb;
    }
}