using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentAssistant
{
    class SettingsClass
    {
        public static void Load_Settings()
        {
            Properties.Settings.Default.xls_Mark = get_set("Mark");
            Properties.Settings.Default.xls_Place = get_set("Place");
            Properties.Settings.Default.xls_Status = get_set("Status");
            Properties.Settings.Default.xls_Serial = get_set("Serial");
            Properties.Settings.Default.xls_Serial2 = get_set("Serial2");
            Properties.Settings.Default.xls_Text = get_set("Text");
            Properties.Settings.Default.xls_Text2 = get_set("Text2");
            Properties.Settings.Default.xls_Text3 = get_set("Text3");
            Properties.Settings.Default.xls_Text4 = get_set("Text4");
            Properties.Settings.Default.xls_Text5 = get_set("Text5");
            Properties.Settings.Default.xls_Text6 = get_set("Text6");
            Properties.Settings.Default.Save();
        }

        public static int get_set(string name)
        {
            return SQL_Class.ReadValueInt32("select 'Index' from settingstable where 'Settings'='" + name + "'");
        }
    }
}
