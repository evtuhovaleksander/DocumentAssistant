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

        }

        public bool Check_and_Fill_DGV(XLS_Class xls, int start, int stop, int col, string table, string name)
        {
            disable_all_update();
            List<string> lst = FuncClass.check(xls, start, stop, col, table, name,XLS_Rbut.Checked);

            Buffer.buffer = lst;
            DataGridViewComboBoxCell tmp = new DataGridViewComboBoxCell();
            List<string> tmp2 = new List<string>();
            tmp2.Add("----");
            tmp2.AddRange(SQL_Class.get_data_Source("select " + name + " from " + table));
            tmp.DataSource = tmp2;
            dgv.Columns[1].CellTemplate = tmp;
            dgv.Rows.Clear();
            dgv.RowCount = lst.Count;

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
        

       


        private void get_File_Click(object sender, EventArgs e)
        {
            XLS_Class cl = XLS_Class.get_xls();
            if (cl != null)
            {
                get_File.BackColor = Color.Green;
                mcl = cl;
            }
        }


        public void disable_all_update()
        {
            Update_Mark_But.Enabled = false;
            Update_Type_But.Enabled = false;
            Update_Status_But.Enabled = false;
            Update_Place2_But.Enabled = false;
            Update_Place_But.Enabled = false;
            Update_Owner_But.Enabled = false;
            Update_OS_But.Enabled = false;
        }


        private void Check_Mark_But_Click(object sender, EventArgs e)
        {

            if (Check_and_Fill_DGV(mcl, Convert.ToInt32(start_Tbox.Text), Convert.ToInt32(stop_Tbox.Text), Properties.Settings.Default.xls_Mark, "marktable", "Mark"))
            {
                MessageBox.Show("OK!!!!");
            }
            else
            {
                Update_Mark_But.Enabled = true;
            }
        }

        private void Check_Status_But_Click(object sender, EventArgs e)
        {

            if (Check_and_Fill_DGV(mcl, Convert.ToInt32(start_Tbox.Text), Convert.ToInt32(stop_Tbox.Text), Properties.Settings.Default.xls_Status, "statustable", "Status"))
            {
                MessageBox.Show("OK!!!!");
            }
            else
            {
                Update_Status_But.Enabled = true;
            }
        }

        private void Check_Place_But_Click(object sender, EventArgs e)
        {

            if (Check_and_Fill_DGV(mcl, Convert.ToInt32(start_Tbox.Text), Convert.ToInt32(stop_Tbox.Text), Properties.Settings.Default.xls_Place, "placetable", "Place"))
            {
                MessageBox.Show("OK!!!!");
            }
            else
            {
                Update_Place_But.Enabled = true;
            }
        }

        private void Check_Type_But_Click(object sender, EventArgs e)
        {

            if (Check_and_Fill_DGV(mcl, Convert.ToInt32(start_Tbox.Text), Convert.ToInt32(stop_Tbox.Text),
                Properties.Settings.Default.xls_Type, "typetable", "Type"))
            {
                MessageBox.Show("OK!!!!");
            }
            else
            {
                Update_Type_But.Enabled = true;
            }
        }






        private void check_OS_Click(object sender, EventArgs e)
        {

            if (Check_and_Fill_DGV(mcl, Convert.ToInt32(start_Tbox.Text), Convert.ToInt32(stop_Tbox.Text),
                DocumentAssistant.Properties.Settings.Default.xls_OS, "ostable", "OS"))
            {
                MessageBox.Show("OK!!!!");
            }
            else
            {
                Update_OS_But.Enabled = true;
            }
        }

        private void Check_Owner_Click(object sender, EventArgs e)
        {
            if (Check_and_Fill_DGV(mcl, Convert.ToInt32(start_Tbox.Text), Convert.ToInt32(stop_Tbox.Text),
               Properties.Settings.Default.xls_Owner, "ownertable", "Owner"))
            {
                MessageBox.Show("OK!!!!");
            }
            else
            {
                Update_Owner_But.Enabled = true;
            }
        }

        private void Place2_Check_Click(object sender, EventArgs e)
        {
            if (Check_and_Fill_DGV(mcl, Convert.ToInt32(start_Tbox.Text), Convert.ToInt32(stop_Tbox.Text),
              Properties.Settings.Default.xls_Place2, "place2table", "Place2"))
            {
                MessageBox.Show("OK!!!!");
            }
            else
            {
                Update_Place2_But.Enabled = true;
            }
        }

        private void ExcelBut_Click(object sender, EventArgs e)
        {
          FuncClass.check_excel(ExcelBut);
        }




        private void FillBase_Click(object sender, EventArgs e) //--------
        {
            int start = Convert.ToInt32(start_Tbox.Text);
            int stop = Convert.ToInt32(stop_Tbox.Text);

            for (int i = start; i < stop; i++)
            {
                Compare_Element el = Compare_Element.get_el_as_base_el(mcl, i);


                string zap = "insert into itemtable (itemtable.Serial,itemtable.Serial2, itemtable.Mark, itemtable.Type, itemtable.Status,itemtable.Place,             itemtable.Text,itemtable.Text2,itemtable.Text3,itemtable.Text4,itemtable.Text5,itemtable.Text6,itemtable.Owner," +
                    "itemtable.Place2,itemtable.OS,itemtable.Date,itemtable.Prise" +
                    ") Values ('" + el.Serial + "','" + el.Serial2 + "'," + el.Markid +
                    "," + el.Typeid + "," + el.Statusid + "," + el.Placeid +
                    ",'" + el.Text + "','" + el.Text2 + "','" + el.Text3 + "','" + el.Text4 + "','" + el.Text5 + "',''," + el.OwnerID + "," + el.Place2id + "," + el.OSID + ",'" + el.date + "','" + el.Prise + "')";
                SQL_Class.Execute(zap);
            }

        }

        public void Update_One_Item(string name, string table, string fr, string addition)
        {
            int id = SQL_Class.ReadValueInt32("select ID from " + table + "  where " + name + "='" + fr + "'");
            string old = SQL_Class.ReadValueString("select xls" + name + " from " + table + " where ID=" + id);
            old += " " + addition;
            SQL_Class.Execute("Update " + table + " set xls" + name + "='" + old + "' where ID=" + id);
        }

       

        private void Check_Start_Stop_Mark_Click(object sender, EventArgs e)
        {
            start_Tbox.Text = "";
            stop_Tbox.Text = "";
            check_GrBox.Enabled = false;
            for (int i = 1; i < 9000; i++)
            {

                string str = mcl.read_val(i, 1).ToString();

                if (str == "#start")
                {
                    start_Tbox.Text = (i + 1).ToString();
                }

                if (str == "#stop")
                {
                    stop_Tbox.Text = (i).ToString(); break;
                }
            }

            if (start_Tbox.Text == "")
            {
                MessageBox.Show("No Start Mark Found!!");
            }
            else
            {
                if (stop_Tbox.Text == "")
                {
                    MessageBox.Show("No Stop Mark Found!!");
                }
                else
                {
                    check_GrBox.Enabled = true;
                }
            }

        }

        private void AutoCheck_But_Click(object sender, EventArgs e)
        {

            if (Check_and_Fill_DGV(mcl, Convert.ToInt32(start_Tbox.Text), Convert.ToInt32(stop_Tbox.Text),
                Properties.Settings.Default.xls_Mark, "marktable", "Mark"))
            {
                Check_Mark_But.BackColor = Color.Green;
            }
            else
            {
                Check_Mark_But.BackColor = Color.Red;
            }

            if (Check_and_Fill_DGV(mcl, Convert.ToInt32(start_Tbox.Text), Convert.ToInt32(stop_Tbox.Text), Properties.Settings.Default.xls_Status, "statustable", "Status"))
            {
                Check_Status_But.BackColor = Color.Green;
            }
            else
            {
                Check_Status_But.BackColor = Color.Red;
            }

            if (Check_and_Fill_DGV(mcl, Convert.ToInt32(start_Tbox.Text), Convert.ToInt32(stop_Tbox.Text), Properties.Settings.Default.xls_Place, "placetable", "Place"))
            {
                Check_Place_But.BackColor = Color.Green;
            }
            else
            {
                Check_Place_But.BackColor = Color.Red;
            }

            if (Check_and_Fill_DGV(mcl, Convert.ToInt32(start_Tbox.Text), Convert.ToInt32(stop_Tbox.Text),
                Properties.Settings.Default.xls_Type, "typetable", "Type"))
            {
                Check_Type_But.BackColor = Color.Green;
            }
            else
            {
                Check_Type_But.BackColor = Color.Red;
            }
            if (Check_and_Fill_DGV(mcl, Convert.ToInt32(start_Tbox.Text), Convert.ToInt32(stop_Tbox.Text),
                DocumentAssistant.Properties.Settings.Default.xls_OS, "ostable", "OS"))
            {
                check_OS.BackColor = Color.Green;
            }
            else
            {
                check_OS.BackColor = Color.Red;
            }


            if (Check_and_Fill_DGV(mcl, Convert.ToInt32(start_Tbox.Text), Convert.ToInt32(stop_Tbox.Text),
               Properties.Settings.Default.xls_Owner, "ownertable", "Owner"))
            {
                Check_Owner.BackColor = Color.Green;
            }
            else
            {
                Check_Owner.BackColor = Color.Red;
            }


            if (Check_and_Fill_DGV(mcl, Convert.ToInt32(start_Tbox.Text), Convert.ToInt32(stop_Tbox.Text),
              Properties.Settings.Default.xls_Place2, "place2table", "Place2"))
            {
                Place2_Check.BackColor = Color.Green;
            }
            else
            {
                Place2_Check.BackColor = Color.Red;
            }
        }



        public void Update_But_Click(string Name, string TableName)
        {
            for (int i = 0; i < dgv.RowCount; i++)
            {
                if (dgv.Rows[i].Cells[1].Value != null)
                    if (dgv.Rows[i].Cells[1].Value.ToString() != "----")
                    {
                        Update_One_Item(Name, TableName, dgv.Rows[i].Cells[1].Value.ToString(), dgv.Rows[i].Cells[0].Value.ToString());
                    }
            }
            Check_Type_But_Click(null, null);
        }

        private void Update_Type_But_Click(object sender, EventArgs e)
        {
            Update_But_Click("Type", "typetable");
        }

        private void Update_Mark_But_Click(object sender, EventArgs e)
        {
            Update_But_Click("Mark", "marktable");
        }

        private void Update_Status_But_Click(object sender, EventArgs e)
        {
            Update_But_Click("Status", "statustable");
        }

        private void Update_Place_But_Click(object sender, EventArgs e)
        {
            Update_But_Click("Place", "placetable");
        }

        private void Update_Place2_But_Click(object sender, EventArgs e)
        {
            Update_But_Click("Place2", "place2table");
        }

        private void Update_Owner_But_Click(object sender, EventArgs e)
        {
            Update_But_Click("Owner", "ownertable");
        }

        private void Update_OS_But_Click(object sender, EventArgs e)
        {
            Update_But_Click("OS", "ostable");
        }
    }
}
