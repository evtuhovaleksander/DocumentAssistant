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
            Properties.Settings.Default.xls_Type = get_set("SType");
            Properties.Settings.Default.xls_Mark = get_set("SMark");
            Properties.Settings.Default.xls_Place = get_set("SPlace");
            Properties.Settings.Default.xls_Status = get_set("SStatus");
            Properties.Settings.Default.xls_Status2 = get_set("SStatus2");
            Properties.Settings.Default.xls_Place2 = get_set("SPlace2");
            Properties.Settings.Default.xls_Owner = get_set("SOwner");


            Properties.Settings.Default.xls_Date = get_set("SDate");
            Properties.Settings.Default.xls_OS = get_set("SOS");
            Properties.Settings.Default.xls_Prise = get_set("SPrise");
           


            Properties.Settings.Default.xls_Serial = get_set("SSerial");
            Properties.Settings.Default.xls_Serial2 = get_set("SSerial2");

            Properties.Settings.Default.xls_Text = get_set("SText");
            Properties.Settings.Default.xls_Text2 = get_set("SText2");
            Properties.Settings.Default.xls_Text3 = get_set("SText3");
            Properties.Settings.Default.xls_Text4 = get_set("SText4");
            Properties.Settings.Default.xls_Text5 = get_set("SText5");
            Properties.Settings.Default.xls_Text6 = get_set("SText6");

            Properties.Settings.Default.Save();
        }

        public static int get_set(string name)
        {
            return SQL_Class.ReadValueInt32("select settingstable.Index from settingstable where settingstable.Setting like '%" + name + "%'");
        }
    }
}
