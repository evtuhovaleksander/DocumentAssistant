using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DocumentAssistant
{
    public static class CMB
    {
        public static int get_id(ComboBox box, string name, string table)
        {
            return SQL_Class.ReadValueInt32("select ID from " + table + " where " + name + " ='" +
                                         box.SelectedItem.ToString() + "'");
        }

        public static List<string> get_ordered_datasource(string name, string table)
        {
            return SQL_Class.get_data_Source("select " + name + " from " + table + "  order by " + name);
        }

    }
}
