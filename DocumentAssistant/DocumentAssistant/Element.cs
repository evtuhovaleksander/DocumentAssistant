using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace DocumentAssistant
{
    public class Compare_Pare_Mas
    {
        public Compare_Pare_Mas()
        {
            pre_mas =new List<Compare_Pare>();
            dual_mas = new List<Compare_Pare>();
            xls_only_mas = new List<Compare_Pare>();
            base_only_mas = new List<Compare_Pare>();
            all_mas = new List<Compare_Pare>();
            Serial2_base=new List<string>();
        }

        public List<Compare_Pare> pre_mas;
        public List<Compare_Pare> dual_mas;
        public List<Compare_Pare> xls_only_mas;
        public List<Compare_Pare> base_only_mas;
        //public List<Compare_Pare> sql_mas;
        public List<Compare_Pare> all_mas;



        public List<string> Serial2_base; 
        public static Compare_Pare_Mas get_base_elements(int ownerID,int OSiD)//--
        {
            Compare_Pare_Mas rett=new Compare_Pare_Mas();
            string zap = "Select itemtable.ID,itemtable.Serial,itemtable.Serial2," +
                         "itemtable.Mark,itemtable.Type,itemtable.Status,itemtable.Place,"+
                         "itemtable.Text,itemtable.Text2,itemtable.Text3,itemtable.Text4,itemtable.Text5,itemtable.Text6 "+
                         ",itemtable.Place2, itemtable.Prise, itemtable.OS, itemtable.Date,itemtable.Status2 from itemtable where (itemtable.Owner="+ownerID+" and itemtable.OS="+OSiD+")";
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

                el.Place2id= cl.get_int(13);
                el.Prise = cl.get_string(14);
                el.OSID = cl.get_int(15);
                el.date = cl.SQL_DataReader.GetDateTime(16);
                el.Status2id = cl.get_int(17);
                el.Text = cl.get_string(7);
                el.Text2 = cl.get_string(8);
                el.Text3 = cl.get_string(9);
                el.Text4 = cl.get_string(10);
                el.Text5 = cl.get_string(11);
                el.Text6 = cl.get_string(12);


                el.read_other_names_base();
                Compare_Pare pare=new Compare_Pare();
                pare.base_el = el;
                rett.pre_mas.Add(pare);
                rett.Serial2_base.Add(el.Serial2);
            }
            cl.Manualy_Close_Connection2();


            for (int i = 0; i < rett.pre_mas.Count; i++)
            {
                rett.pre_mas[i].base_el.read_other_names_base();
            }

            return rett;
        }
    }
    public class Compare_Pare
    {
       public Compare_Element base_el;
       public Compare_Element xls_el;
        public bool full_pair;
        public bool equal;


        public Compare_Pare CloneComparePare()
        {
            return (Compare_Pare) MemberwiseClone();
        }


        public void check_equalence(bool Serial,bool Serial2,bool Place,bool Mark,bool date,bool Prise)
        {
            if (base_el == null || xls_el == null)
            {
                full_pair = false;
            }
            else
            {
                full_pair = true;
                equal = true;
                
                if ((base_el.Serial != xls_el.Serial)&&Serial)
                    equal = false;
                if ((base_el.Serial2 != xls_el.Serial2) && Serial2)
                    equal = false;
                if ((base_el.Markid != xls_el.Markid)&&Mark)
                    equal = false;
                if ((base_el.Placeid != xls_el.Placeid)&&Place)
                    equal = false;
                if ((base_el.date != xls_el.date)&&date)
                    equal = false;
                if ((base_el.Prise != xls_el.Prise) && Prise)
                    equal = false;
            }
        }
    }
    public class Compare_Element
    {


        public Compare_Element CloneElement()
        {
            return (Compare_Element) MemberwiseClone();
        }

        string select_name_where_id(string name, string tablename, int i)
        {
            string zap = "Select " + tablename+"."+name +" from " + tablename + " where ID= "+i;
            object ob = SQL_Class.ReadValue(zap);
            if (ob == null)
            {
                return "";
            }
            else
            {
                return ob.ToString();
            }

        }

        int select_id_where_name(string name,string tablename,string like)
        {
            string zap = "Select ID from "+tablename+ " where "+tablename+"." + name+" = '"+like+"'";
            object ob= SQL_Class.ReadValue(zap);
            if (ob == null)
            {
                return -1;
            }
            else
            {
                return Convert.ToInt32(ob);
            }
            
        }
        int select_id_where_xlsname(string name, string tablename, string like)
        {
            string zap = "Select ID from " + tablename + " where " + tablename + ".xls" + name + " like '%" + like + "%'";
            object ob = SQL_Class.ReadValue(zap);
            if (ob == null)
            {
                return -1;
            }
            else
            {
                return Convert.ToInt32(ob);
            }
        }
        public void read_other_ids_base()
        {
            Typeid=select_id_where_name("Type","typetable",Type);
            Markid = select_id_where_name("Mark", "marktable", Mark);
            Statusid = select_id_where_name("Status", "statustable", Status);
            Placeid = select_id_where_name("Place", "placetable", Place);
            OwnerID = select_id_where_name("Owner", "ownertable", Owner);
            Place2id = select_id_where_name("Place2", "place2table", Place2);
            OSID = select_id_where_name("OS", "ostable", OS);
            Status2id = select_id_where_name("Status2", "status2table", Status2);
        }

        public void read_other_names_base()//++
        {
            Type = select_name_where_id("Type", "typetable", Typeid);
            Mark= select_name_where_id("Mark", "marktable", Markid);
            Status= select_name_where_id("Status", "statustable", Statusid);
            Status2 = select_name_where_id("Status2", "status2table", Status2id);
            Place = select_name_where_id("Place", "placetable", Placeid);
            Owner = select_name_where_id("Owner", "ownertable", OwnerID);

            Place2 = select_name_where_id("Place2", "place2table", Place2id);
            OS = select_name_where_id("OS", "ostable", OSID);

        }

        public  void read_other_xls() //++
        {
            Typeid = select_id_where_xlsname("Type", "typetable", Type);
            Markid = select_id_where_xlsname("Mark", "marktable", Mark);
            Statusid = select_id_where_xlsname("Status", "statustable", Status);
            Placeid = select_id_where_xlsname("Place", "placetable", Place);
            OwnerID = select_id_where_name("Owner", "ownertable", Owner);

            Place2id= select_id_where_xlsname("Place2", "place2table", Place2);
            OSID = select_id_where_xlsname("OS", "ostable", OS);
        }

       

        public Compare_Element()
        {

            Markid = RandomFull.get_rand_int();
            Typeid  = RandomFull.get_rand_int();
            Statusid = RandomFull.get_rand_int();
            Placeid = RandomFull.get_rand_int();
            Place2id = RandomFull.get_rand_int();
            Placeid = RandomFull.get_rand_int();
            OSID = RandomFull.get_rand_int();
            Status2id = RandomFull.get_rand_int();
        }

      
        public static Compare_Element get_el_as_base_el(XLS_Class mcl,int i)//++
        {
            Compare_Element el = new Compare_Element();
            el.Mark = mcl.read_val(i, Properties.Settings.Default.xls_Mark).ToString();
            el.Type = mcl.read_val(i, Properties.Settings.Default.xls_Type).ToString();
            el.Status = mcl.read_val(i, Properties.Settings.Default.xls_Status).ToString();
            el.Place = mcl.read_val(i, Properties.Settings.Default.xls_Place).ToString();
            el.Status2 = mcl.read_val(i, Properties.Settings.Default.xls_Status2).ToString();
            el.Text = mcl.read_val(i, Properties.Settings.Default.xls_Text).ToString();
            el.Text2 = mcl.read_val(i, Properties.Settings.Default.xls_Text2).ToString();
            el.Text3 = mcl.read_val(i, Properties.Settings.Default.xls_Text3).ToString();
            el.Text4 = mcl.read_val(i, Properties.Settings.Default.xls_Text4).ToString();
            el.Text5 = mcl.read_val(i, Properties.Settings.Default.xls_Text5).ToString();

            el.Serial = mcl.read_val(i, Properties.Settings.Default.xls_Serial).ToString();
            el.Serial2 = mcl.read_val(i, Properties.Settings.Default.xls_Serial2).ToString();
            el.Owner= mcl.read_val(i, Properties.Settings.Default.xls_Owner).ToString();


            el.Prise = (mcl.read_val(i, Properties.Settings.Default.xls_Prise)).ToString();
            el.date = FuncClass.get_Date(mcl.read_val(i, Properties.Settings.Default.xls_Date).ToString());
            el.OS = mcl.read_val(i, Properties.Settings.Default.xls_OS).ToString();
            el.Place2 = mcl.read_val(i, Properties.Settings.Default.xls_Place2).ToString();


            el.read_other_ids_base();
            return el;
        }

        public static Compare_Element get_el_as_xls_el(XLS_Class mcl, int i)//++
        {
            Compare_Element el = new Compare_Element();
            el.Mark = mcl.read_val(i, Properties.Settings.Default.xls_Mark).ToString();
            el.Type = mcl.read_val(i, Properties.Settings.Default.xls_Type).ToString();
            el.Status = mcl.read_val(i, Properties.Settings.Default.xls_Status).ToString();
            el.Status2 = "";
            el.Place = mcl.read_val(i, Properties.Settings.Default.xls_Place).ToString();

            el.Text = mcl.read_val(i, Properties.Settings.Default.xls_Text).ToString();
            el.Text2 = mcl.read_val(i, Properties.Settings.Default.xls_Text2).ToString();
            el.Text3 = mcl.read_val(i, Properties.Settings.Default.xls_Text3).ToString();
            el.Text4 = mcl.read_val(i, Properties.Settings.Default.xls_Text4).ToString();
            el.Text5 = mcl.read_val(i, Properties.Settings.Default.xls_Text5).ToString();

            el.Serial = mcl.read_val(i, Properties.Settings.Default.xls_Serial).ToString();
            el.Serial2 = mcl.read_val(i, Properties.Settings.Default.xls_Serial2).ToString();

            el.Prise = mcl.read_val(i, Properties.Settings.Default.xls_Prise).ToString();
            el.date = FuncClass.get_Date(mcl.read_val(i, Properties.Settings.Default.xls_Date).ToString());
            el.OS = mcl.read_val(i, Properties.Settings.Default.xls_OS).ToString();
            el.Place2 = mcl.read_val(i, Properties.Settings.Default.xls_Place2).ToString();
            el.Status2id = RandomFull.get_rand_int();

            el.read_other_xls();
            return el;
        }
        public static Compare_Element get_el_as_xls_el_for_cmp(XLS_Class mcl, int i) //++11
        {
            Compare_Element el = new Compare_Element();
            el.Mark = mcl.read_val(i, Properties.Settings.Default.xls_Mark).ToString();
            el.Type = mcl.read_val(i, Properties.Settings.Default.xls_Type).ToString();
            el.Status = mcl.read_val(i, Properties.Settings.Default.xls_Status).ToString();
            el.Status2 = ""; 
            el.Place = mcl.read_val(i, Properties.Settings.Default.xls_Place).ToString();
            el.Owner= mcl.read_val(i, Properties.Settings.Default.xls_Owner).ToString();
            

            el.Serial = mcl.read_val(i, Properties.Settings.Default.xls_Serial).ToString();
            el.Serial2 = mcl.read_val(i, Properties.Settings.Default.xls_Serial2).ToString();

            el.Prise = (mcl.read_val(i, Properties.Settings.Default.xls_Prise)).ToString();
            el.date = FuncClass.get_Date(mcl.read_val(i, Properties.Settings.Default.xls_Date).ToString());
            el.OS = mcl.read_val(i, Properties.Settings.Default.xls_OS).ToString();
            el.Place2 = mcl.read_val(i, Properties.Settings.Default.xls_Place2).ToString();
            el.Status2id = RandomFull.get_rand_int();



            el.read_other_xls();
            return el;
        }


        public int ID;

        public string Serial;
        public string Serial2;

        public string Text;
        public string Text2;
        public string Text3;
        public string Text4;
        public string Text5;
        public string Text6;

        public DateTime date;
        public string Prise;
        public string OS;

        public string Type;
        public string Mark;
        public string Status;
        public string Status2;
        public string Place;
        public string Place2;
        public string Owner;


        public int Typeid;
        public int Markid;
        public int Statusid;
        public int Status2id;
        public int Placeid;
        public int Place2id;
        public int OwnerID;
        public int OSID;
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


    public static class RandomFull
    {
        public static Random rnd = new Random();
        public static int get_rand_int()
        {
            
            int i = rnd.Next(0, 100);
            for (int j = 0; j < i; j++)
            {
                rnd.Next();
            }
            int rett = -rnd.Next(1, 36000);
            Console.WriteLine(rett);
            return rett;
        }
    }
}
