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
            List<string> str=new List<string>();
            string zap = "select Owner from ownertable";
            SQL_Class cl=new SQL_Class();
            cl.ReadValues(zap);
            while (cl.SQL_DataReader.Read())
            {
                str.Add(cl.get_string(0));
            }
            comboBox1.DataSource = str;
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

       

        private void get_File_Click(object sender, EventArgs e)
        {
            XLS_Class cl = XLS_Class.get_xls();
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

        private void FillBase_Click(object sender, EventArgs e)
        {
            int start = Convert.ToInt32(start_Tbox.Text);
            int stop = Convert.ToInt32(stop_Tbox.Text);

            for (int i = start - 1; i < stop - 1; i++)
            {
                Compare_Element el = Compare_Element.get_el_as_base_el(mcl,i);


                string zap = "insert into itemtable Serial,Serial2,Mark,Type,Status,Place,Text,Text2,Text3,Text4,Text5,Text6,Owner"+
                    " Values ('"+ el.Serial + "','"+ el.Serial2 + "',"+ el.Mark + 
                    ","+ el.Type + ","+ el.Status + ","+ el.Place + 
                    ",'"+ el.Text + "','"+ el.Text2 + "','"+ el.Text3 + "','"+ el.Text4 + "','"+ el.Text5 + "','',"+comboBox1.SelectedIndex+")";
                SQL_Class.Execute(zap);
            }
            
        }
    }
}
