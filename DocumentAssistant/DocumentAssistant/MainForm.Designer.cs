namespace DocumentAssistant
{
    partial class MainForm
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
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.mainToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.baseShowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tablesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.typeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.markToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.placeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.place2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ownersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cheakTypeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mainToolStripMenuItem,
            this.settingsToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(1123, 28);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip";
            // 
            // mainToolStripMenuItem
            // 
            this.mainToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.baseShowToolStripMenuItem,
            this.toolStripMenuItem2});
            this.mainToolStripMenuItem.Name = "mainToolStripMenuItem";
            this.mainToolStripMenuItem.Size = new System.Drawing.Size(54, 24);
            this.mainToolStripMenuItem.Text = "Main";
            // 
            // baseShowToolStripMenuItem
            // 
            this.baseShowToolStripMenuItem.Name = "baseShowToolStripMenuItem";
            this.baseShowToolStripMenuItem.Size = new System.Drawing.Size(231, 26);
            this.baseShowToolStripMenuItem.Text = "Рабта с БД";
            this.baseShowToolStripMenuItem.Click += new System.EventHandler(this.baseShowToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(231, 26);
            this.toolStripMenuItem2.Text = "Свести базу и отчеты";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tablesToolStripMenuItem,
            this.ownersToolStripMenuItem,
            this.cheakTypeToolStripMenuItem,
            this.checkSettingsToolStripMenuItem});
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(74, 24);
            this.settingsToolStripMenuItem.Text = "Settings";
            // 
            // tablesToolStripMenuItem
            // 
            this.tablesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.typeToolStripMenuItem,
            this.markToolStripMenuItem,
            this.placeToolStripMenuItem,
            this.place2ToolStripMenuItem,
            this.oSToolStripMenuItem});
            this.tablesToolStripMenuItem.Name = "tablesToolStripMenuItem";
            this.tablesToolStripMenuItem.Size = new System.Drawing.Size(299, 26);
            this.tablesToolStripMenuItem.Text = "Таблицы типов";
            // 
            // typeToolStripMenuItem
            // 
            this.typeToolStripMenuItem.Name = "typeToolStripMenuItem";
            this.typeToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.typeToolStripMenuItem.Text = "Тип";
            this.typeToolStripMenuItem.Click += new System.EventHandler(this.typeToolStripMenuItem_Click);
            // 
            // markToolStripMenuItem
            // 
            this.markToolStripMenuItem.Name = "markToolStripMenuItem";
            this.markToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.markToolStripMenuItem.Text = "Марка";
            this.markToolStripMenuItem.Click += new System.EventHandler(this.markToolStripMenuItem_Click);
            // 
            // placeToolStripMenuItem
            // 
            this.placeToolStripMenuItem.Name = "placeToolStripMenuItem";
            this.placeToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.placeToolStripMenuItem.Text = "Место";
            this.placeToolStripMenuItem.Click += new System.EventHandler(this.placeToolStripMenuItem_Click);
            // 
            // place2ToolStripMenuItem
            // 
            this.place2ToolStripMenuItem.Name = "place2ToolStripMenuItem";
            this.place2ToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.place2ToolStripMenuItem.Text = "Место2";
            this.place2ToolStripMenuItem.Click += new System.EventHandler(this.place2ToolStripMenuItem_Click);
            // 
            // oSToolStripMenuItem
            // 
            this.oSToolStripMenuItem.Name = "oSToolStripMenuItem";
            this.oSToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.oSToolStripMenuItem.Text = "ОС/ТМЦ";
            this.oSToolStripMenuItem.Click += new System.EventHandler(this.oSToolStripMenuItem_Click);
            // 
            // ownersToolStripMenuItem
            // 
            this.ownersToolStripMenuItem.Name = "ownersToolStripMenuItem";
            this.ownersToolStripMenuItem.Size = new System.Drawing.Size(299, 26);
            this.ownersToolStripMenuItem.Text = "Таблица владельцев";
            this.ownersToolStripMenuItem.Click += new System.EventHandler(this.ownersToolStripMenuItem_Click);
            // 
            // cheakTypeToolStripMenuItem
            // 
            this.cheakTypeToolStripMenuItem.Name = "cheakTypeToolStripMenuItem";
            this.cheakTypeToolStripMenuItem.Size = new System.Drawing.Size(299, 26);
            this.cheakTypeToolStripMenuItem.Text = "Сверить типы";
            this.cheakTypeToolStripMenuItem.Click += new System.EventHandler(this.cheakTypeToolStripMenuItem_Click);
            // 
            // checkSettingsToolStripMenuItem
            // 
            this.checkSettingsToolStripMenuItem.Name = "checkSettingsToolStripMenuItem";
            this.checkSettingsToolStripMenuItem.Size = new System.Drawing.Size(299, 26);
            this.checkSettingsToolStripMenuItem.Text = "Проверить текущие настройки";
            this.checkSettingsToolStripMenuItem.Click += new System.EventHandler(this.checkSettingsToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1123, 34);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem mainToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tablesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem typeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem markToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem placeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ownersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cheakTypeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem baseShowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem checkSettingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem place2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem oSToolStripMenuItem;
    }
}