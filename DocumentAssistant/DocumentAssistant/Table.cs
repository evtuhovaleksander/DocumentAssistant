using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DocumentAssistant
{
    class Table
    {
        public Table(List<Element> elList,DataGridView DGV)
        {
            el_list = elList;
            dgv = DGV;
        }

        List<Element> el_list;
        DataGridView dgv;
        string Table_Name;

        void LoadData()
        {
            string zap = "Select ";
            for (int i = 0; i < el_list.Count; i++)
            {
                if (i == 0)
                {
                    zap += " " + el_list[i].Name + " ";
                }
                else
                {
                    zap += " ," + el_list[i].Name + " ";
                }
                
            }


        }
    }
}
