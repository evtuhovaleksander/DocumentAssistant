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
    public partial class HistoryForm : Form
    {
        private int ID;
        public HistoryForm(int id)
        {
            InitializeComponent();
            ID = id;
            load_data();
        }

        void load_data()
        {
            string zap = "select ID, ItemID, Log, Date, Who from logs where ItemID=" + ID;
            log_dgv.DataSource = FuncClass.get_dataTable(zap);
            doc_dgv.RowCount = SQL_Class.ReadValueInt32("select count(*) from Documents where ItemID=" + ID);
            SQL_Class cl = new SQL_Class();
            cl.ReadValues("select ID, Name from documents where ItemID="+ID);
            
            int i = 0;
            while (cl.SQL_DataReader.Read())
            {
                doc_dgv.Rows[i].Cells[0].Value=cl.get_int(0);
                doc_dgv.Rows[i].Cells[1].Value = cl.get_string(1);
                i++;
            }
        }

      
        private void doc_dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex > 1 && e.RowIndex > -1)
            {
                int id = Convert.ToInt32(doc_dgv.Rows[e.RowIndex].Cells[0].Value);
                if (e.ColumnIndex==2)DocumentDirectory.open_document(id) ;
                if (e.ColumnIndex == 3)
                {
                    DocumentDirectory.delete_document(id);
                    load_data();
                }
            }
        }

        private void log_dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void HistoryForm_Load(object sender, EventArgs e)
        {

        }

        private void Add_Doc_But_Click(object sender, EventArgs e)
        {
            DocumentDirectory.add_document(ID);
            load_data();
        }

       
    }
}
