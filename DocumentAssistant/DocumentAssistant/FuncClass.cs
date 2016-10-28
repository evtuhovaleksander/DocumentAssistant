using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DocumentAssistant
{
    static class FuncClass
    {
        public static ComboBox PrepareComboBox(ComboBox inp, Element el,string MainTable)
        {
            List<string> ds=new List<string>();
            SQL_Class cl=new SQL_Class();
            string zap = "select " + el.name + " from ";
            if (el.cmbox)
            {
                zap += el.addtable;
            }
            else
            {
                zap += MainTable;
            }

            cl.ReadValues(zap);
            while (cl.SQL_DataReader.Read())
            {
                ds.Add(cl.SQL_DataReader.GetString(0));
            }

            inp.DataSource = ds;
            return inp;
        }
    }
}
