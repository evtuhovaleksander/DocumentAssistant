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
    public partial class EditForm : Form
    {
        public EditForm(string Name, string RusName, string Table)
        {
            InitializeComponent();
            dgv.Columns.Clear();
            dgv.Columns.Add("ID", "ID");
            dgv.Columns.Add(Name, RusName);
        }

        private void EditForm_Load(object sender, EventArgs e)
        {
            
        }
    }
}
