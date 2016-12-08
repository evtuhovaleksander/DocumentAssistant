using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
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
            //List<string> str=new List<string>();
            //string zap = "select Owner from ownertable";
            //SQL_Class cl=new SQL_Class();
            //cl.ReadValues(zap);
            //while (cl.SQL_DataReader.Read())
            //{
            //    str.Add(cl.get_string(0));
            //}
            //comboBox1.DataSource = str;
            //cl.Manualy_Close_Connection2();
        }

        public bool Check_and_Fill_DGV(XLS_Class xls, int start, int stop, int col, string table, string name)
        {
            
            List<string> lst = check(xls,start, stop, col, table, name);
            dgv.RowCount = lst.Count;
            Buffer.buffer = lst;
            for (int i = 0; i < lst.Count; i++)
            {
                dgv.Rows[i].Cells[0].Value = lst[i];
            }
            if (lst.Count != 0)
            {
                return false;

            }
            else
            {
                return true;
            }
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
            for (int i = start; i < stop; i++)
            {
                if (
                    SQL_Class.ReadValueInt32("select count(*) from " + table + "  where "+element + " like '%" +
                                             xls.read_val(i, col).ToString() + "%'") < 0)
                {
                    if(!rett.Contains(xls.read_val(i, col).ToString()))rett.Add(xls.read_val(i, col).ToString());
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
            if (Check_and_Fill_DGV(mcl, Convert.ToInt32(start_Tbox.Text), Convert.ToInt32(stop_Tbox.Text), Properties.Settings.Default.xls_Mark, "marktable", "Mark"))
            {
                MessageBox.Show("OK!!!!");
            }
        }

        private void Check_Status_But_Click(object sender, EventArgs e)
        {
            if (Check_and_Fill_DGV(mcl, Convert.ToInt32(start_Tbox.Text), Convert.ToInt32(stop_Tbox.Text), Properties.Settings.Default.xls_Status, "statustable", "Status"))
            {
                MessageBox.Show("OK!!!!");
            }
        }

        private void Check_Place_But_Click(object sender, EventArgs e)
        {

            if (Check_and_Fill_DGV(mcl, Convert.ToInt32(start_Tbox.Text), Convert.ToInt32(stop_Tbox.Text), Properties.Settings.Default.xls_Place, "placetable", "Place"))
            {
                MessageBox.Show("OK!!!!");
            }
        }

        private void Check_Type_But_Click(object sender, EventArgs e)
        {
            if (Check_and_Fill_DGV(mcl, Convert.ToInt32(start_Tbox.Text), Convert.ToInt32(stop_Tbox.Text),
                Properties.Settings.Default.xls_Type, "typetable", "Type"))
            {
                MessageBox.Show("OK!!!!");
            }
        }









        private void FillBase_Click(object sender, EventArgs e) //--------
        {
            int start = Convert.ToInt32(start_Tbox.Text);
            int stop = Convert.ToInt32(stop_Tbox.Text);
            
            for (int i = start ; i < stop ; i++)
            {
                Compare_Element el = Compare_Element.get_el_as_base_el(mcl,i);


                string zap = "insert into itemtable (itemtable.Serial,itemtable.Serial2, itemtable.Mark, itemtable.Type, itemtable.Status,itemtable.Place,             itemtable.Text,itemtable.Text2,itemtable.Text3,itemtable.Text4,itemtable.Text5,itemtable.Text6,itemtable.Owner," +
                    "itemtable.Place2,itemtable.OS,itemtable.Date,itemtable.Prise" +
                    ") Values ('"+ el.Serial + "','"+ el.Serial2 + "',"+ el.Markid + 
                    ","+ el.Typeid + ","+ el.Statusid + ","+ el.Placeid + 
                    ",'"+ el.Text + "','"+ el.Text2 + "','"+ el.Text3 + "','"+ el.Text4 + "','"+ el.Text5 + "','',"+el.OwnerID+","+el.Place2id+","+el.OSID+",'"+el.date+"','"+el.Prise+"')";
                SQL_Class.Execute(zap);
            }
            
        }

        private void check_OS_Click(object sender, EventArgs e)
        {
            int j=DocumentAssistant.Properties.Settings.Default.xls_OS;
            if (Check_and_Fill_DGV(mcl, Convert.ToInt32(start_Tbox.Text), Convert.ToInt32(stop_Tbox.Text),
                DocumentAssistant.Properties.Settings.Default.xls_OS, "ostable", "OS"))
            {
                MessageBox.Show("OK!!!!");
            }
        }

        private void Check_Owner_Click(object sender, EventArgs e)
        {
            if (Check_and_Fill_DGV(mcl, Convert.ToInt32(start_Tbox.Text), Convert.ToInt32(stop_Tbox.Text),
               Properties.Settings.Default.xls_Owner, "ownertable", "Owner"))
            {
                MessageBox.Show("OK!!!!");
            }
        }

        private void Place2_Check_Click(object sender, EventArgs e)
        {
            if (Check_and_Fill_DGV(mcl, Convert.ToInt32(start_Tbox.Text), Convert.ToInt32(stop_Tbox.Text),
              Properties.Settings.Default.xls_Place2, "place2table", "Place2"))
            {
                MessageBox.Show("OK!!!!");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i = 0;
            foreach (var VARIABLE in Process.GetProcesses())
            {
                if (VARIABLE.ProcessName.Contains("xcell")) i++;

            }
            if (i != 0) MessageBox.Show("Найдено " + i + " копий работающих программы Excel");
        }
    }
}
