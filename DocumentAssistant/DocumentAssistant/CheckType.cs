using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DocumentAssistant
{
    public partial class CheckType : Form
    {
        XLS_Class mcl;
        public CheckType()
        {
            InitializeComponent();
        }

        private void CheckType_Load(object sender, EventArgs e)
        {

        }

        public void Check_and_Fill_DGV(XLS_Class xls, int start, int stop, int col, string table, string name)
        {
            List<string> lst = check(xls,start, stop, col, table, name);
            dgv.RowCount = lst.Count;
            for (int i = 0; i < lst.Count; i++)
            {
                dgv.Rows[i].Cells[0].Value = lst[i];
            }
        }


        private void Check_Type_But_Click(object sender, EventArgs e)
        {
            Check_and_Fill_DGV(mcl,Convert.ToInt32(start_Tbox.Text),Convert.ToInt32(stop_Tbox.Text),Properties.Settings.Default.xls_Type,"typetable","Type");
        }

        public List<string> check(XLS_Class xls,int start,int stop,int col,string table,string name)
        {
            List<string> rett = new List<string>();
            string element;
            if (XLS_Rbut.Checked)
            {
                element = "xls"+name;
            }
            else
            {
                element = name;
            }
            for (int i = start-1; i < stop-1; i++)
            {
                if (
                    SQL_Class.ReadValueInt32("select count(*) from " + table + "  where "+element + " like '%" +
                                             xls.read_val(i, col).ToString() + "%'") == 0)
                {
                    rett.Add(xls.read_val(i, col).ToString());
                }
            }
            return rett;
        }

        public XLS_Class get_xls()
        {
            FileDialog dlg = new OpenFileDialog();
            dlg.ShowDialog();
            if (File.Exists(dlg.FileName))
            {
                return new XLS_Class(dlg.FileName);
            }
            else
            {
                return null;
            }
        }

        private void get_File_Click(object sender, EventArgs e)
        {
            XLS_Class cl = get_xls();
            if (cl != null)
            {
                get_File.BackColor=Color.Green;
                mcl = cl;
            }
        }

        private void Check_Mark_But_Click(object sender, EventArgs e)
        {
            Check_and_Fill_DGV(mcl, Convert.ToInt32(start_Tbox.Text), Convert.ToInt32(stop_Tbox.Text), Properties.Settings.Default.xls_Mark, "marktable", "Mark");
        }

        private void Check_Status_But_Click(object sender, EventArgs e)
        {
            Check_and_Fill_DGV(mcl, Convert.ToInt32(start_Tbox.Text), Convert.ToInt32(stop_Tbox.Text), Properties.Settings.Default.xls_Status, "statustable", "Status");
        }

        private void Check_Place_But_Click(object sender, EventArgs e)
        {
            Check_and_Fill_DGV(mcl, Convert.ToInt32(start_Tbox.Text), Convert.ToInt32(stop_Tbox.Text), Properties.Settings.Default.xls_Place, "placetable", "Place");
        }
    }
}
