using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace DocumentAssistant
{
    class Table
    {
        public Table(List<Element> elList,DataGridView DGV,string tab_name)
        {
            el_list = elList;
            dgv = DGV;
            Table_Name = tab_name;
        }

        List<Element> el_list;
        DataGridView dgv;
        string Table_Name;

        public void LoadData()
        {
            string zap = "Select ";
            string inner_part = "";
            for (int i = 0; i < el_list.Count; i++)
            {
                if (i != 0) zap += ", ";
                if (el_list[i].cmbox)
                {
                    zap += el_list[i].addtable + ".";
                    if (!inner_part.Contains(el_list[i].innerpart)) inner_part += " " + el_list[i].innerpart;
                }
                else
                {
                    zap += el_list[i].table + ".";
                }
                zap += el_list[i].name + " ";
            }
            zap += "from " + Table_Name+" ";
            zap += inner_part;
            SQL_Class cl=new SQL_Class();
            MySqlCommand sqlCom = new MySqlCommand(zap, cl.SQL_Connection);
            
            sqlCom.ExecuteNonQuery();
            MySqlDataAdapter dataAdapter = new MySqlDataAdapter(sqlCom);
            DataTable dt = new DataTable();
            dataAdapter.Fill(dt);


            dgv.DataSource = dt;
        }
    }
}
