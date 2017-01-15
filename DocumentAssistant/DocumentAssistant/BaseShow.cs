using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DocumentAssistant.Properties;

namespace DocumentAssistant
{
    public partial class BaseShow : Form
    {
        //FormBuilder builder;
        Table tbl;
        public BaseShow()
        {
            InitializeComponent();


            Type_CmBox.DataSource = CMB.get_ordered_datasource("Type","typetable");//SQL_Class.get_data_Source("select Type from typetable"));
            Place_CmBox.DataSource = CMB.get_ordered_datasource("Place", "placetable");//SQL_Class.get_data_Source("select Place from placetable");
            Place2_CmBox.DataSource = CMB.get_ordered_datasource("Place2", "place2table");//SQL_Class.get_data_Source("select Place2 from place2table");
            OS_CmBox.DataSource = CMB.get_ordered_datasource("OS", "ostable");//SQL_Class.get_data_Source("select OS from ostable");
            Owner_CmBox.DataSource = CMB.get_ordered_datasource("Owner", "ownertable");// SQL_Class.get_data_Source("select Owner from ownertable");


            Filter_Clear();
            








            List<Element> lst = new List<Element>();
            lst.Add(new Element("itemtable", "ID", false, false, ""));
            lst.Add(new Element("itemtable", "Serial", true, false, ""));                         //
            lst.Add(new Element("itemtable", "Serial2", true, false, ""));                        //

            lst.Add(new Element("itemtable", "Mark", false, true, "marktable"));
            lst.Add(new Element("itemtable", "Type", false, true, "typetable"));
            lst.Add(new Element("itemtable", "Place", false, true, "placetable"));
            lst.Add(new Element("itemtable", "Place2", false, true, "place2table"));
            lst.Add(new Element("itemtable", "Status", false, true, "statustable"));
            lst.Add(new Element("itemtable", "Status2", false, true, "status2table"));
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
            Load_Data_With_Filters();
            paint_dgv();


            st1.BackColor = Settings.Default.st1;
            st2.BackColor = Settings.Default.st2;
            st3.BackColor = Settings.Default.st3;
            st4.BackColor = Settings.Default.st4;
            st5.BackColor = Settings.Default.st5;
            st6.BackColor = Settings.Default.st6;

            st2_1.BackColor = Settings.Default.st_2_1;
            st2_2.BackColor = Settings.Default.st_2_2;
            st2_3.BackColor = Settings.Default.st_2_3;
            st2_4.BackColor = Settings.Default.st_2_4;
            st2_5.BackColor = Settings.Default.st_2_5;






        }

        private void BaseShow_Load(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Load_Data_With_Filters();
        }

        private void dgv_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex!=-1)
                if (dgv.Rows[e.RowIndex].Cells[0].Value != null)
                {
                    //FormBuilder.Prepare_Form_To_Edit(tbl,new Point(50,50), Convert.ToInt32(dgv.Rows[e.RowIndex].Cells[0].Value));
                    ElementWorkForm frm =
                        new ElementWorkForm(FuncClass.get_Element(Convert.ToInt32(dgv.Rows[e.RowIndex].Cells[0].Value)));
                    frm.ShowDialog();
                }
        }

        private void Add_but_Click(object sender, EventArgs e)
        {
            //FormBuilder.Prepare_Form_To_Add(tbl, new Point(50, 50));
            ElementWorkForm frm =
                        new ElementWorkForm();
            frm.ShowDialog();
        }

       
        public void Load_Data_With_Filters()
        {
            DataTable table = tbl.ret_Datatable(get_request());
            dgv.DataSource = table;
            ElementsFound_TBox.Text = table.Rows.Count.ToString();
            double prise = 0;
            int ind = 0;
            for (int i = 0; i < table.Columns.Count; i++)
            {
                if (table.Columns[i].ColumnName == "Prise") ind = i;
            }
            
            for (int i = 0; i < table.Rows.Count; i++)
            {
                try
                {
                    prise += Convert.ToDouble(table.Rows[i][ind].ToString());
                }
                catch (Exception)
                {

                }
            }
            ElementsFoundPrice_TBox.Text = prise.ToString();
            paint_dgv();
        }

        public void paint_dgv()
        {
            string par = "";
            if (Status_Rbut.Checked)
            {
                par = "Status";
            }
            else
            {
                par = "Status2";
            }

            int i = 0;
            for (int j = 0; j < dgv.Columns.Count; j++)
            {
                if (dgv.Columns[j].Name == par) i = j;
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

                Color col = Color.AliceBlue;
                if (Status_Rbut.Checked)
                {
                   col = get_col(vl);
                }
                else
                {
                    col = get_col_2(vl);
                }
                
                dgv.Rows[j].DefaultCellStyle.BackColor = col;
            }
            dgv.Refresh();
        }

        public Color get_col(string val)
        {
            switch (val)
            {
                case "В работе":
                    return st1.BackColor;
                    break;
                case "В резерве":
                    return st2.BackColor;
                    break;
                case "Списано":
                    return st3.BackColor;
                    break;
                case "Утилизировано":
                    return st4.BackColor;
                    break;
                case "Передано":
                    return st5.BackColor;
                    break;

                case "Ремонт":
                    return st6.BackColor;
                    break;
              
            }
            return Color.FloralWhite;
        }

        public Color get_col_2(string val)
        {
            switch (val)
            {
                case "Новый":
                    return st2_1.BackColor;
                    break;
                case "Сверено":
                    return st2_2.BackColor;
                    break;
                case "Уточнить":
                    return st2_3.BackColor;
                    break;
                case "Найти":
                    return st2_4.BackColor;
                    break;
                case "Только в базе":
                    return st2_5.BackColor;
                    break;

                

            }
            return Color.FloralWhite;
        }

        public string get_request()
        {
            string request = "";
            string preDeep = get_PreDeep_where_part();
            string main = tbl.get_firstPartOfRequest();
            if (WideFileldFilter_ChBox.Checked)
            {
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
            if (MainFileldFilter_ChBox.Checked)
            {
                where += get_one_Where_Block(Serial_1_TBox, Serial_1_CmBox, "itemtable.Serial");
                where += get_one_Where_Block(Serial_2_TBox, Serial_2_CmBox, "itemtable.Serial2");
            }

            if (TextFileldFilter_ChBox.Checked)
            {
                where += get_one_Where_Block(Text_1_TBox, Text_1_CmBox, "itemtable.Text");
                where += get_one_Where_Block(Text_2_TBox, Text_2_CmBox, "itemtable.Text2");
                where += get_one_Where_Block(Text_3_TBox, Text_3_CmBox, "itemtable.Text3");
                where += get_one_Where_Block(Text_4_TBox, Text_4_CmBox, "itemtable.Text4");
                where += get_one_Where_Block(Text_5_TBox, Text_5_CmBox, "itemtable.Text5");
                where += get_one_Where_Block(Text_6_TBox, Text_6_CmBox, "itemtable.Text6");
            }
          

            where += get_stat_part();
            where += get_stat2_part();
            where += get_date_where_part();
            where += get_Typethized_part();

            return where;
        }

        public string get_date_where_part()
        {
            if (DateFileldFilter_ChBox.Checked)
            {
                string where = " AND (itemtable.Date between '";
                DateTime d1 = dateTimePicker1.Value.Date;
                DateTime d2;
                if (DateOption_CmBox.SelectedIndex == 1)
                {
                    d2 = dateTimePicker2.Value.Date.AddDays(1);
                }
                else
                {
                    d2 = d1.AddDays(1);
                }
                where += d1.ToString("yyyy-MM-dd") + "' and '";
                where += d2.ToString("yyyy-MM-dd") + "' )";
              
                return where;
            }
            else
            {
                return "";
            }
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
            if (Status1FileldFilter_ChBox.Checked)
            {
                if (st1_ChBox.Checked) where += " OR itemtable.Status=1 ";
                if (st2_ChBox.Checked) where += " OR itemtable.Status=2 ";
                if (st3_ChBox.Checked) where += " OR itemtable.Status=3 ";
                if (st4_ChBox.Checked) where += " OR itemtable.Status=4 ";
                if (st5_ChBox.Checked) where += " OR itemtable.Status=5 ";
                if (st6_ChBox.Checked) where += " OR itemtable.Status=6 ";
               
            }
           
            where += ")";

            if (where == " AND (FALSE)") where = "";



            return where;
        }
        public string get_stat2_part()
        {
            string where = " AND (FALSE";
            if (Status2FileldFilter_ChBox.Checked)
            {
                if (st2_1_ChBox.Checked) where += " OR itemtable.Status2=1 ";
                if (st2_2_ChBox.Checked) where += " OR itemtable.Status2=2 ";
                if (st2_3_ChBox.Checked) where += " OR itemtable.Status2=3 ";
                if (st2_4_ChBox.Checked) where += " OR itemtable.Status2=4 ";
                if (st2_5_ChBox.Checked) where += " OR itemtable.Status2=5 ";
               
            }

            where += ")";

            if (where == " AND (FALSE)") where = "";



            return where;
        }
        public string get_Typethized_part()
        {
            string where = " AND (TRUE";
            if (TypedFileldFilter_ChBox.Checked)
            {
                where += get_one_Typethized_part(Type_CmBox, Type_ChBox, "Type", "typetable");
                where += get_one_Typethized_part(Place_CmBox, Place_ChBox, "Place", "placetable");
                where += get_one_Typethized_part(Place2_CmBox, Place2_ChBox, "Place2", "place2table");
                where += get_one_Typethized_part(OS_CmBox, OS_ChBox, "OS", "ostable");
                where += get_one_Typethized_part(Owner_CmBox, Owner_ChBox, "Owner", "ownertable");
            }
            
         
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
           
            List<string> bool_mas=new List<string>();
            bool_mas.Add("И");
            bool_mas.Add("Или");
            bool_mas.Add("И НЕ");
            bool_mas.Add("Или НЕ");

            for (int i = 0; i < wide_dgv.RowCount-1; i++)
            {
                int ind = mas.IndexOf(wide_dgv.Rows[i].Cells[2].Value.ToString());
                int bool_log = bool_mas.IndexOf(wide_dgv.Rows[i].Cells[0].Value.ToString());
                rett.Add(get_one_orlike(wide_dgv.Rows[i].Cells[1].Value.ToString(),ind,bool_log));    
            }
            return rett;
        }

        public string get_one_orlike(string str, int ind,int bool_logic)
        {
            ind++;

            string where =" ";//= " AND (";


            switch (bool_logic)
            {
                case 0:
                    where = " AND ( ";
                    break;
                case 1:
                    where = " OR ( ";
                    break;
                case 2:
                    where = " AND NOT ( ";
                    break;
                case 3:
                    where = " OR NOT ( ";
                    break;
               
            }

            

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
                if (i == 0)
                {
                    where += "##";
                }

                if (!"ID Date".Contains(tbl.el_list[i].name))
                {
                    

                    if (tbl.el_list[i].cmbox)
                    {
                      if(i!=0)  
                          where += " OR (" + tbl.el_list[i].addtable + "." + tbl.el_list[i].name + " " + like+")";
                    }
                    else
                    {
                      if(i!=0)  
                          where += " OR (" + tbl.Table_Name + "." + tbl.el_list[i].name + " " + like+")";
                    }
                }
            }

            where = where.Replace("( ## OR", " (");
           // where = where.Replace(" AND ( OR", " AND (");
           // where = where.Replace(" AND (  OR", " AND (");
            return where+")";
        }

        private void Clear_Filter_But_Click(object sender, EventArgs e)
        {
            Filter_Clear();
        }

        public void Filter_Clear()
        {
            TextFileldFilter_ChBox.Checked = true;
            MainFileldFilter_ChBox.Checked = true;
            TypedFileldFilter_ChBox.Checked = true;
            Status1FileldFilter_ChBox.Checked = true;
            Status2FileldFilter_ChBox.Checked = true;
            WideFileldFilter_ChBox.Checked = true;
            DateFileldFilter_ChBox.Checked = true;


            st1_ChBox.Checked = true;
            st2_ChBox.Checked = true;
            st3_ChBox.Checked = true;
            st4_ChBox.Checked = true;
            st5_ChBox.Checked = true;
            st6_ChBox.Checked = true;
            st7_ChBox.Checked = true;

            st2_1_ChBox.Checked = true;
            st2_2_ChBox.Checked = true;
            st2_3_ChBox.Checked = true;
            st2_4_ChBox.Checked = true;
            st2_5_ChBox.Checked = true;

            Type_ChBox.Checked = false;
            Place2_ChBox.Checked = false;
            Place_ChBox.Checked = false;
            OS_ChBox.Checked = false;
            Owner_ChBox.Checked = false;

            Serial_1_CmBox.SelectedIndex = 0;
            Serial_2_CmBox.SelectedIndex = 0;

            Text_1_CmBox.SelectedIndex = 0;
            Text_2_CmBox.SelectedIndex = 0;
            Text_3_CmBox.SelectedIndex = 0;
            Text_4_CmBox.SelectedIndex = 0;
            Text_5_CmBox.SelectedIndex = 0;
            Text_6_CmBox.SelectedIndex = 0;

            wide_dgv.Rows.Clear();
            
        }

      

        private void dgv_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex==-1&&e.Button==MouseButtons.Middle)
            {
                string name = dgv.Columns[e.ColumnIndex].Name;
                for (int i = 0; i < tbl.el_list.Count; i++)
                {
                    if (name == tbl.el_list[i].name && tbl.el_list[i].cmbox)
                    {
                        Element el = tbl.el_list[i];
                        GroupChangeForm frm = new GroupChangeForm(el);
                        frm.ShowDialog();
                        Application.DoEvents();
                        if (frm.Acept)
                        {
                            int new_index = frm.id;
                            List<int> ids = new List<int>();
                            for (int j = 0; j < dgv.RowCount; j++)
                            {
                                ids.Add((int)dgv.Rows[j].Cells[0].Value);
                            }

                            foreach (var VARIABLE in ids)
                            {
                                string req = "update itemtable set " + el.name + " = " + new_index + "  where ID=" +
                                             VARIABLE;
                                SQL_Class.Execute(req);
                                Logs.add_upload_log(VARIABLE,el.name,el.addtable, SQL_Class.ReadValueInt32("select "+el.name+" from itemtable where ID="+VARIABLE),new_index);
                            }
                            Load_Data_With_Filters();
                        }
                    }
                }
            }
        }

        private void Export_But_Click(object sender, EventArgs e)
        {
            if (Place_ChBox.Checked)
            {
                if (TempDirectory.AllowWork && TempDirectory.ShablonsEnabled)
                {
                    string postfix = DateTime.Now.ToString("yyyy-MM-dd HH-mm-ss");
                    string filename = "Export-" + postfix + ".xlsx";
                    string path = TempDirectory.Path + "\\" + filename;
                    File.Copy(TempDirectory.Path + "\\xls.xlsx", path);
                    if (File.Exists(path))
                    {




                        int row = 4;
                        int j = 1;
                        XLS_Class cl = new XLS_Class(path);
                        cl.set_val(1, 2, DateTime.Now.ToString("D"));
                        cl.set_val(2, 2, Place2_CmBox.SelectedItem.ToString());
                        for (int i = 0; i < dgv.RowCount; i++)
                        {
                            cl.set_val(row, 0, j.ToString());
                            cl.set_val(row, 1, dgv.Rows[i].Cells[4].Value.ToString());
                            cl.set_val(row, 2, dgv.Rows[i].Cells[3].Value.ToString());
                            cl.set_val(row, 3, dgv.Rows[i].Cells[1].Value.ToString());
                            cl.set_val(row, 4, dgv.Rows[i].Cells[2].Value.ToString());
                            cl.set_val(row, 5, dgv.Rows[i].Cells[17].Value.ToString());
                            cl.set_val(row, 6, dgv.Rows[i].Cells[8].Value.ToString());
                            
                            row++;
                            j++;
                        }
                        cl.save_as(path);
                    }
                }
            }
            else
            {
                MessageBox.Show(
                    "Для создания инвентаризационного документа по аппаратной включите фильтр по аппаратной (Place2)");
            }
        }

        private void dgv_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            paint_dgv();
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {

           
            foreach (DataGridViewRow VARIABLE in dgv.SelectedRows)
            {
                new HistoryForm(Convert.ToInt32(VARIABLE.Cells[0].Value.ToString())).Show();
            }
        }


        

        private void st1_Click(object sender, EventArgs e)
        {
            Color cl = FuncClass.get_color_from_table(st1.BackColor);
            st1.BackColor = cl;
            Settings.Default.st1 = cl;
            Settings.Default.Save();
            Refresh();
        }

        private void st2_Click(object sender, EventArgs e)
        {
            Color cl = FuncClass.get_color_from_table(st2.BackColor);
            st2.BackColor = cl;
            Settings.Default.st2 = cl;
            Settings.Default.Save();
            Refresh();
        }

        private void st3_Click(object sender, EventArgs e)
        {
            Color cl = FuncClass.get_color_from_table(st3.BackColor);
            st3.BackColor = cl;
            Settings.Default.st3 = cl;
            Settings.Default.Save();
            Refresh();
        }

        private void st4_Click(object sender, EventArgs e)
        {
            Color cl = FuncClass.get_color_from_table(st4.BackColor);
            st4.BackColor = cl;
            Settings.Default.st4 = cl;
            Settings.Default.Save();
            Refresh();
        }

        private void st5_Click(object sender, EventArgs e)
        {
            Color cl = FuncClass.get_color_from_table(st5.BackColor);
            st5.BackColor = cl;
            Settings.Default.st5 = cl;
            Settings.Default.Save();
            Refresh();
        }

        private void st6_Click(object sender, EventArgs e)
        {
            Color cl = FuncClass.get_color_from_table(st6.BackColor);
            st6.BackColor = cl;
            Settings.Default.st6 = cl;
            Settings.Default.Save();
            Refresh();
        }

        private void st2_1_Click(object sender, EventArgs e)
        {
            Color cl = FuncClass.get_color_from_table(st2_1.BackColor);
            st2_1.BackColor = cl;
            Settings.Default.st_2_1 = cl;
            Settings.Default.Save();
            Refresh();
        }

        private void st2_2_Click(object sender, EventArgs e)
        {
            Color cl = FuncClass.get_color_from_table(st2_2.BackColor);
            st2_2.BackColor = cl;
            Settings.Default.st_2_2 = cl;
            Settings.Default.Save();
            Refresh();
        }

        private void st2_3_Click(object sender, EventArgs e)
        {
            Color cl = FuncClass.get_color_from_table(st2_3.BackColor);
            st2_3.BackColor = cl;
            Settings.Default.st_2_3 = cl;
            Settings.Default.Save();
            Refresh();
        }

        private void st2_4_Click(object sender, EventArgs e)
        {
            Color cl = FuncClass.get_color_from_table(st2_4.BackColor);
            st2_4.BackColor = cl;
            Settings.Default.st_2_4 = cl;
            Settings.Default.Save();
            Refresh();
        }

        private void st2_5_Click(object sender, EventArgs e)
        {
            Color cl = FuncClass.get_color_from_table(st2_5.BackColor);
            st2_5.BackColor = cl;
            Settings.Default.st_2_5 = cl;
            Settings.Default.Save();
            Refresh();
        }
    }
}
