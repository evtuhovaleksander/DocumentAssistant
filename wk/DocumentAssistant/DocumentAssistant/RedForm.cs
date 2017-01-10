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
    public partial class RedForm : Form
    {
       public int ID;
        FormBuilder bld;
        public RedForm(int i,FormBuilder ibld)
        {
            InitializeComponent();
            ID = i;
            bld = ibld;
        }

        private void RedForm_Load(object sender, EventArgs e)
        {

        }

        private void Add_But_Click(object sender, EventArgs e)
        {
            bld.Add_To_Base();
        }

        private void Save_But_Click(object sender, EventArgs e)
        {
            bld.Save_To_Base();
        }

        private void Delete_But_Click(object sender, EventArgs e)
        {
            bld.Delete_To_Base();
        }
    }
}
