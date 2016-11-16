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
    public partial class EditFormWide : Form
    {
        string TableName;
        string RusName;
        string FName;
        public EditFormWide(string FName, string RusName, string TableName)
        {
            InitializeComponent();
            this.FName = FName;
            this.RusName = RusName;
            this.TableName = TableName;
            dgv.Columns.Clear();
            dgv.Columns.Add("ID", "ID");
            dgv.Columns.Add(FName, RusName);
            dgv.Columns.Add("xls"+FName,"xls "+ RusName);
            dgv.Columns[2].AutoSizeMode=DataGridViewAutoSizeColumnMode.Fill;
        }

        private void EditForm_Load(object sender, EventArgs e)
        {
           load_info();
        }

        public void load_info()
        {
            int count = SQL_Class.ReadValueInt32("Select Count(*) from " + TableName);
            dgv.RowCount = count + 1;
            string zap = "Select ID," + FName + ", xls"+FName+" from " + TableName;
            SQL_Class cl = new SQL_Class();
            cl.ReadValues(zap);

            int i = 0;
            while (cl.SQL_DataReader.Read())
            {
                dgv.Rows[i].Cells[0].Value = cl.get_int(0);
                dgv.Rows[i].Cells[1].Value = cl.SQL_DataReader.GetValue(1);
                dgv.Rows[i].Cells[2].Value = cl.SQL_DataReader.GetValue(2);
                i++;
            }
            cl.Manualy_Close_Connection2();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(dgv.RowCount.ToString());
            SQL_Class.Execute("truncate " + TableName);
            for (int i = 0; i < dgv.RowCount-1; i++)
            {
                string str = "insert into " + TableName + " (ID," + FName + ", xls"+FName+") Values (" +
                             dgv.Rows[i].Cells[0].Value.ToString() + ",'" + dgv.Rows[i].Cells[1].Value.ToString() + "','"+ dgv.Rows[i].Cells[2].Value .ToString()+ "')";
                SQL_Class.Execute(str);
            }
            load_info();
        }
    }
}
