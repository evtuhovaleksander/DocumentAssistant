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
    public partial class GroupChangeForm : Form
    {

        Element el;
        public int id = -1;
        public bool Acept = false;
        public GroupChangeForm(Element inp)
        {
            InitializeComponent();
            el = inp;
            cmb.DataSource = CMB.get_ordered_datasource(el.name, el.addtable);//SQL_Class.get_data_Source("select " + el.name + " from " + el.addtable));
            lb.Text = el.name;

        }

        private void GroupChangeForm_Load(object sender, EventArgs e)
        {
            
        }

        private void Acept_but_Click(object sender, EventArgs e)
        {
            Acept = true;
            id =
                SQL_Class.ReadValueInt32("select ID from " + el.addtable + " where " + el.name + " ='" +
                                         cmb.SelectedItem.ToString() + "'");
            Close();
        }

        private void Cancel_But_Click(object sender, EventArgs e)
        {
           Close();
        }
    }
}
