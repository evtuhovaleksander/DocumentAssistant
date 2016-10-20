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
        public BaseShow()
        {
            InitializeComponent();
        }

        private void BaseShow_Load(object sender, EventArgs e)
        {
            //List<string> mas =new List<string>();
            //mas.Add("dw");
            
            //((DataGridViewComboBoxColumn) dgv.Columns[3]).DataSource = mas;
            List<Element> lst =new List<Element>();
            lst.Add(new Element("itemtable","ID",false,false,""));
            lst.Add(new Element("itemtable", "Text", true, false, ""));
            lst.Add(new Element("itemtable", "Mark", false, true, "marktable"));
            Table tbl=new Table(lst,dgv2,"itemtable");
            tbl.LoadData();
        }
    }
}
