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
    public partial class BaseShow : Form
    {
        //FormBuilder builder;
        Table tbl;
        public BaseShow()
        {
            InitializeComponent();


            Type_CmBox.DataSource = SQL_Class.get_data_Source("select Type from typetable");
            Place_CmBox.DataSource = SQL_Class.get_data_Source("select Place from placetable");
            Place2_CmBox.DataSource = SQL_Class.get_data_Source("select Place2 from place2table");
            OS_CmBox.DataSource = SQL_Class.get_data_Source("select OS from ostable");
            Owner_CmBox.DataSource = SQL_Class.get_data_Source("select Owner from ownertable");











            List<Element> lst = new List<Element>();
            lst.Add(new Element("itemtable", "ID", false, false, ""));
            lst.Add(new Element("itemtable", "Serial", true, false, ""));                         //
            lst.Add(new Element("itemtable", "Serial2", true, false, ""));                        //

            lst.Add(new Element("itemtable", "Mark", false, true, "marktable"));
            lst.Add(new Element("itemtable", "Type", false, true, "typetable"));
            lst.Add(new Element("itemtable", "Place", false, true, "placetable"));
            lst.Add(new Element("itemtable", "Place2", false, true, "place2table"));
            lst.Add(new Element("itemtable", "Status", false, true, "statustable"));
            lst.Add(new Element("itemtable", "OS", false, true, "ostable"));

            lst.Add(new Element("itemtable", "Text", true, false, ""));                            //
            lst.Add(new Element("itemtable", "Text2", true, false, ""));                           //      
            lst.Add(new Element("itemtable", "Text3", true, false, ""));//
            lst.Add(new Element("itemtable", "Text4", true, false, ""));//
            lst.Add(new Element("itemtable", "Text5", true, false, ""));//
            lst.Add(new Element("itemtable", "Text6", true, false, ""));//

            lst.Add(new Element("itemtable", "Prise", true, false, ""));//
            lst.Add(new Element("itemtable", "Date", true, false, ""));//

            lst.Add(new Element("itemtable", "Owner", false, true, "ownertable"));

            tbl = new Table(lst, dgv, "itemtable");
            tbl.LoadData();
        }

        private void BaseShow_Load(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tbl.LoadData();
        }

        private void dgv_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex!=-1)
                if (dgv.Rows[e.RowIndex].Cells[0].Value != null)
                {
                    FormBuilder.Prepare_Form_To_Edit(tbl,new Point(50,50), Convert.ToInt32(dgv.Rows[e.RowIndex].Cells[0].Value));
                }
        }

        private void Add_but_Click(object sender, EventArgs e)
        {
            FormBuilder.Prepare_Form_To_Add(tbl, new Point(50, 50));
        }

        private void button1_Click_1(object sender, EventArgs e)
        {


            DataTable table = tbl.ret_Datatable(get_request());
            dgv.DataSource = table;
            int i = 0;
            for (int j = 0; j < dgv.Columns.Count; j++)
            {
                if (dgv.Columns[j].Name == "Status") i = j;
            }

            for (int j = 0; j < dgv.Rows.Count; j++)
            {
                string vl = "nan";
                try
                {
                    vl = dgv.Rows[j].Cells[i].Value.ToString();
                }
                catch (Exception)
                {
                    
                  
                }

                Color col=get_col( vl);
                dgv.Rows[j].DefaultCellStyle.BackColor = col;
            }
            dgv.Refresh();
        }

        public Color get_col(string val)
        {
            switch (val)
            {
                case "Сверено":
                    return st1.BackColor;
                    break;
                case "Передано":
                    return st2.BackColor;
                    break;
                case "Списано":
                    return st3.BackColor;
                    break;
                case "Утилизировано":
                    return st4.BackColor;
                    break;
                case "Уточнить":
                    return st5.BackColor;
                    break;

                case "Найти":
                    return st6.BackColor;
                    break;
                case "-":
                    return st7.BackColor;
                    break;
            }
            return Color.FloralWhite;
        }

        public string get_request()
        {
            string request = "";
            string preDeep = get_PreDeep_where_part();
            string main = tbl.get_firstPartOfRequest();
            List<string> orlike = get_all_OrLike();


            if (orlike.Count != 0)
            {
                foreach (var VARIABLE in orlike)
                {
                    request += "Union " + main + " where (" + preDeep + "  " + VARIABLE + ")";
                }
            }
            else
            {
                request += " " + main + " where (" + preDeep + ")";
            }

            return request;
        }

        public string get_PreDeep_where_part()
        {
            string where = "TRUE";

            where += get_one_Where_Block(Serial_1_TBox, Serial_1_CmBox, "itemtable.Serial");
            where += get_one_Where_Block(Serial_2_TBox, Serial_2_CmBox, "itemtable.Serial2");

            where += get_one_Where_Block(Text_1_TBox, Text_1_CmBox, "itemtable.Text");
            where += get_one_Where_Block(Text_2_TBox, Text_2_CmBox, "itemtable.Text2");
            where += get_one_Where_Block(Text_3_TBox, Text_3_CmBox, "itemtable.Text3");
            where += get_one_Where_Block(Text_4_TBox, Text_4_CmBox, "itemtable.Text4");
            where += get_one_Where_Block(Text_5_TBox, Text_5_CmBox, "itemtable.Text5");
            where += get_one_Where_Block(Text_6_TBox, Text_6_CmBox, "itemtable.Text6");

            where += get_stat_part();

            where += get_Typethized_part();

            return where;
        }

        public string get_one_Where_Block(TextBox tb, ComboBox cmb, string field)
        {
            string rett = " AND ";
            switch (cmb.SelectedIndex)
            {
                case 0:
                    rett = "";
                    break;
                case 1:
                    rett += field + "='" + tb.Text + "' ";
                    break;
                case 2:
                    rett += field + " like '%" + tb.Text + "%' ";
                    break;
                case 3:
                    rett += field + " like '" + tb.Text + "%' ";
                    break;
                case 4:
                    rett += field + " like '%" + tb.Text + "' ";
                    break;
                default:
                    rett = "";
                    break;
            }
            return rett;
        }

        public string get_stat_part()
        {
            string where = " AND (FALSE";

            if (st1_ChBox.Checked) where += " OR itemtable.Status=1 ";
            if (st2_ChBox.Checked) where += " OR itemtable.Status=2 ";
            if (st3_ChBox.Checked) where += " OR itemtable.Status=3 ";
            if (st4_ChBox.Checked) where += " OR itemtable.Status=4 ";
            if (st5_ChBox.Checked) where += " OR itemtable.Status=5 ";
            if (st6_ChBox.Checked) where += " OR itemtable.Status=6 ";
            where += ")";

            if (where == " AND (FALSE)") where = "";



            return where;
        }

        public string get_Typethized_part()
        {
            string where = " AND (TRUE";
            where += get_one_Typethized_part(Type_CmBox, Type_ChBox, "Type", "typetable");
            where += get_one_Typethized_part(Place_CmBox, Place_ChBox, "Place", "placetable");
            where += get_one_Typethized_part(Place2_CmBox, Place2_ChBox, "Place2", "place2table");
            where += get_one_Typethized_part(OS_CmBox, OS_ChBox, "OS", "ostable");
            where += get_one_Typethized_part(Owner_CmBox, Owner_ChBox, "Owner", "ownertable");
         
            where += ")";

            if (where == "AND (TRUE)") where = "";



            return where;
        }

        public string get_one_Typethized_part(ComboBox cmb, CheckBox options,string field,string table)
        {
            string rett = " ";
            if (options.Checked)
            {
                return " AND itemtable."+field+"=" +
                       SQL_Class.ReadValueInt32("select ID from " + table + " where " + field + "='" + cmb.SelectedItem +
                                                "'")+" ";
            }
            else
            {
                return "";
            }
            
        }


        public List<string> get_all_OrLike()
        {
            List<string> rett=new List<string>();
            List<string> mas =new List<string>();
            mas.Add( "Equals");
            mas.Add(  "Contains");
            mas.Add(  "Begins with");
            mas.Add(  "Ends with");
           

            for (int i = 0; i < wide_dgv.RowCount-1; i++)
            {
                int ind = mas.IndexOf(wide_dgv.Rows[i].Cells[1].Value.ToString());
                rett.Add(get_one_orlike(wide_dgv.Rows[i].Cells[0].Value.ToString(),ind));    
            }
            return rett;
        }

        public string get_one_orlike(string str, int ind)
        {
            ind++;
            string where = " AND (";
            string like = "";
            switch (ind)
            {
                case 0:
                    like = " True ";    
                    break;
                case 1:
                    like = " like '" + str + "'";
                    break;
                case 2:
                    like = " like '%" + str + "%'";
                    break;
                case 3:
                    like = " like '" + str + "%'";
                    break;
                case 4:
                    like = " like '%" + str + "'";
                    break;
            }

            for (int i = 0; i < tbl.el_list.Count; i++)
            {
                if (!"ID Date".Contains(tbl.el_list[i].name))
                {
                    if (tbl.el_list[i].cmbox)
                    {
                        where += " OR (" + tbl.el_list[i].addtable + "." + tbl.el_list[i].name + " " + like+")";
                    }
                    else
                    {
                        where += " OR (" + tbl.Table_Name + "." + tbl.el_list[i].name + " " + like+")";
                    }
                }
            }
            where = where.Replace(" AND ( OR", " AND (");
            return where+")";
        }


    }
}
