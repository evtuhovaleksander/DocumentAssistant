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
    public partial class BaseShow : Form
    {
        //FormBuilder builder;
        Table tbl;
        public BaseShow()
        {
            InitializeComponent();
            List<Element> lst = new List<Element>();
            lst.Add(new Element("itemtable", "ID", false, false, ""));
            lst.Add(new Element("itemtable", "Text", true, false, ""));
            lst.Add(new Element("itemtable", "Mark", false, true, "marktable"));
            tbl = new Table(lst, dgv, "itemtable");
            tbl.LoadData();
        }

        private void BaseShow_Load(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tbl.LoadData();
        }

        private void dgv_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex!=-1)
                if (dgv.Rows[e.RowIndex].Cells[0].Value != null)
                {
                    //RedForm frm = new RedForm();
                    //FormBuilder builder = new FormBuilder(tbl, new Point(50, 50), frm);
                    //frm.Refresh();
                    //frm.Show();
                    //builder.Load_Element(Convert.ToInt32(dgv.Rows[e.RowIndex].Cells[0].Value));
                    FormBuilder.Prepare_Form_To_Edit(tbl,new Point(50,50), Convert.ToInt32(dgv.Rows[e.RowIndex].Cells[0].Value));
                }
        }
    }
}
