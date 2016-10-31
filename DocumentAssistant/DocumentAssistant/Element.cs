using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentAssistant
{
    public class Compare_Pare_Mas
    {
       public List<Compare_Pare> pre_mas;
        public List<Compare_Pare> dual_mas;
        public List<Compare_Pare> xls_only_mas;
        public List<Compare_Pare> base_only_mas;
        //public List<Compare_Pare> sql_mas;
        public List<Compare_Pare> all_mas;



        public List<string> Serial2_base; 
        public static Compare_Pare_Mas get_base_elements()
        {
            Compare_Pare_Mas rett=new Compare_Pare_Mas();
            string zap = "Select itemtable.ID,itemtable.Serial,itemtable.Serial2" +
                         "itemtable.Mark,itemtable.Type,itemtable.Status,itemtable.Place"+
                         "itemtable.Text,itemtable.Text2,itemtable.Text3,itemtable.Text4,itemtable.Text5,itemtable.Text6";
            SQL_Class cl=new SQL_Class();
            cl.ReadValues(zap);
            while (cl.SQL_DataReader.Read())
            {
                Compare_Element el = new Compare_Element();

                el.ID = cl.get_int(0);

                el.Serial = cl.get_string(1);
                el.Serial2 = cl.get_string(2);

                el.Markid = cl.get_int(3);
                el.Typeid = cl.get_int(4);
                el.Statusid = cl.get_int(5);
                el.Placeid = cl.get_int(6);
                Compare_Pare pare=new Compare_Pare();
                pare.base_el = el;
                rett.pre_mas.Add(pare);
                rett.Serial2_base.Add(el.Serial2);
            }
            return rett;
        }
    }
    public class Compare_Pare
    {
       public Compare_Element base_el;
       public Compare_Element xls_el;
    }
    public class Compare_Element
    {
        int select_id_where_name(string name,string tablename,string like)
        {
            string zap = "Select ID from "+tablename+" where "+ name+" like '%"+like+"%'";
            return SQL_Class.ReadValueInt32(zap);
        }
        int select_id_where_xlsname(string name, string tablename, string like)
        {
            string zap = "Select ID from " + tablename + " where xls" + name + " like '%" + like + "%'";
            return SQL_Class.ReadValueInt32(zap);
        }
        public void read_other_base()
        {
            Typeid=select_id_where_name("Type","typetable",Type);
            Markid = select_id_where_name("Mark", "marktable", Mark);
            Statusid = select_id_where_name("Status", "statustable", Status);
            Placeid = select_id_where_name("Place", "placetable", Place);
        }

       public  void read_other_xls()
        {
            Typeid = select_id_where_xlsname("Type", "typetable", Type);
            Markid = select_id_where_xlsname("Mark", "marktable", Mark);
            Statusid = select_id_where_xlsname("Status", "statustable", Status);
            Placeid = select_id_where_xlsname("Place", "placetable", Place);
        }

        public Compare_Element (int id, string serial, string serial2, string type, string mark, string status, string place, string text, string text2, string text3)
        {
            ID = id;
            Serial = serial;
            Serial2 = serial2;
            Type = type;
            Mark = mark;
            Status = status;
            Place = place;
            Text = text;
            Text2 = text2;
            Text3 = text3;
        }

        public Compare_Element()
        {
        }

        //public static Compare_Element get_el_from_base(int i)
        //{
        //    Compare_Element el = new Compare_Element();
        //    SQL_Class.
        //    el.Mark = mcl.read_val(i, Properties.Settings.Default.xls_Mark).ToString();
        //    el.Type = mcl.read_val(i, Properties.Settings.Default.xls_Type).ToString();
        //    el.Status = mcl.read_val(i, Properties.Settings.Default.xls_Status).ToString();
        //    el.Place = mcl.read_val(i, Properties.Settings.Default.xls_Place).ToString();

        //    el.Text = mcl.read_val(i, Properties.Settings.Default.xls_Text).ToString();
        //    el.Text2 = mcl.read_val(i, Properties.Settings.Default.xls_Text2).ToString();
        //    el.Text3 = mcl.read_val(i, Properties.Settings.Default.xls_Text3).ToString();
        //    el.Text4 = mcl.read_val(i, Properties.Settings.Default.xls_Text4).ToString();
        //    el.Text5 = mcl.read_val(i, Properties.Settings.Default.xls_Text5).ToString();

        //    el.Serial = mcl.read_val(i, Properties.Settings.Default.xls_Serial).ToString();
        //    el.Serial2 = mcl.read_val(i, Properties.Settings.Default.xls_Serial2).ToString();

        //    el.read_other_base();
        //    return el;
        //}

        public static Compare_Element get_el_as_base_el(XLS_Class mcl,int i)
        {
            Compare_Element el = new Compare_Element();
            el.Mark = mcl.read_val(i, Properties.Settings.Default.xls_Mark).ToString();
            el.Type = mcl.read_val(i, Properties.Settings.Default.xls_Type).ToString();
            el.Status = mcl.read_val(i, Properties.Settings.Default.xls_Status).ToString();
            el.Place = mcl.read_val(i, Properties.Settings.Default.xls_Place).ToString();

            el.Text = mcl.read_val(i, Properties.Settings.Default.xls_Text).ToString();
            el.Text2 = mcl.read_val(i, Properties.Settings.Default.xls_Text2).ToString();
            el.Text3 = mcl.read_val(i, Properties.Settings.Default.xls_Text3).ToString();
            el.Text4 = mcl.read_val(i, Properties.Settings.Default.xls_Text4).ToString();
            el.Text5 = mcl.read_val(i, Properties.Settings.Default.xls_Text5).ToString();

            el.Serial = mcl.read_val(i, Properties.Settings.Default.xls_Serial).ToString();
            el.Serial2 = mcl.read_val(i, Properties.Settings.Default.xls_Serial2).ToString();

            el.read_other_base();
            return el;
        }

        public static Compare_Element get_el_as_xls_el(XLS_Class mcl, int i)
        {
            Compare_Element el = new Compare_Element();
            el.Mark = mcl.read_val(i, Properties.Settings.Default.xls_Mark).ToString();
            el.Type = mcl.read_val(i, Properties.Settings.Default.xls_Type).ToString();
            el.Status = mcl.read_val(i, Properties.Settings.Default.xls_Status).ToString();
            el.Place = mcl.read_val(i, Properties.Settings.Default.xls_Place).ToString();

            el.Text = mcl.read_val(i, Properties.Settings.Default.xls_Text).ToString();
            el.Text2 = mcl.read_val(i, Properties.Settings.Default.xls_Text2).ToString();
            el.Text3 = mcl.read_val(i, Properties.Settings.Default.xls_Text3).ToString();
            el.Text4 = mcl.read_val(i, Properties.Settings.Default.xls_Text4).ToString();
            el.Text5 = mcl.read_val(i, Properties.Settings.Default.xls_Text5).ToString();

            el.Serial = mcl.read_val(i, Properties.Settings.Default.xls_Serial).ToString();
            el.Serial2 = mcl.read_val(i, Properties.Settings.Default.xls_Serial2).ToString();

            el.read_other_xls();
            return el;
        }

        public int ID;
        public string Serial;
        public string Serial2;
        public string Type;
        public string Mark;
        public string Status;
        public string Place;
        public string Text;
        public string Text2;
        public string Text3;
        public string Text4;
        public string Text5;
        public int Typeid;
        public int Markid;
        public int Statusid;
        public int Placeid;
    }

    public class Element
    {
        public Element(string table, string name, bool cons, bool cmbox, string addtable)
        {
           // this.table = table;
            this.name = name;
            this.cons = cons;
            this.cmbox = cmbox;
            this.addtable = addtable;

        }

        //public string table;
        public string name;

        public bool cons;

        public bool cmbox;
        public string addtable;
        public string innerpart;
    }
}
