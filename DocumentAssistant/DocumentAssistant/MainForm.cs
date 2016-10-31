using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DocumentAssistant
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void typeToolStripMenuItem_Click(object sender, EventArgs e)
        {
           new EditFormWide("Type", "Тип", "typetable").Show();
        }

        private void markToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new EditFormWide("Mark", "Марка", "marktable").Show();
        }

        private void statusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new EditFormWide("Status", "Статус", "statustable").Show();
        }

        private void placeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new EditFormWide("Place", "Место", "placetable").Show();
        }

        private void cheakTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new CheckType().Show();
        }

        private void baseShowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new BaseShow().Show();
        }

   

        private void MainForm_Load(object sender, EventArgs e)
        {
            SettingsClass.Load_Settings();
        }

        private void checkSettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Settings_Form().Show();
        }

        private void ownersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new EditForm("Owner", "Owner", "ownertable").Show();
        }
    }
}
