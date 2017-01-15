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
    public partial class ElementWorkForm : Form
    {
        Compare_Pare pr;
        private bool changed;
        public ElementWorkForm(Compare_Pare Pr)
        {
            InitializeComponent();
            prepare_CmBox();
            this.pr = Pr;
            changed = false;
            left_panel.Visible = false;
            up_panel.Visible = false;
            load_data_from_pair();
        }

        public void load_data_from_pair()
        {
            if (pr.full_pair)
            {
                load_base_el();
                load_xls_el();
                compare();
            }
            else
            {
                if (pr.base_el != null)
                {
                    load_base_el();
                }
                else
                {
                    load_xls_el();
                    up_panel.Visible = true;
                    Add_But.Visible = true;
                }
            }
        }

        public ElementWorkForm(Compare_Element el)
        {
            //edit
            InitializeComponent();
            prepare_CmBox();
            pr=new Compare_Pare();
            pr.base_el = el;
            pr.xls_el = null;
            pr.full_pair = false;
            up_panel.Visible = false;
            load_data_from_pair();
          
        }
        public ElementWorkForm()
        {
            InitializeComponent();
            prepare_CmBox();
            pr = new Compare_Pare();
            pr.base_el = null;
            pr.xls_el = null;
            pr.full_pair = false;
            Add_But.Visible = true;
        }

        public void prepare_CmBox()
        {
            mark1.DataSource = SQL_Class.get_data_Source_with_Null("select Mark from marktable");
            type1.DataSource= SQL_Class.get_data_Source_with_Null("select Type from typetable");
            place1.DataSource = SQL_Class.get_data_Source_with_Null("select Place from placetable");
            place21.DataSource = SQL_Class.get_data_Source_with_Null("select Place2 from place2table");
            status1.DataSource = SQL_Class.get_data_Source_with_Null("select Status from statustable");
            status21.DataSource = SQL_Class.get_data_Source_with_Null("select Status2 from status2table");
            os1.DataSource = SQL_Class.get_data_Source_with_Null("select OS from ostable");
            owner1.DataSource = SQL_Class.get_data_Source_with_Null("select Owner from ownertable");
        }

        private void ComparePareForm_Load(object sender, EventArgs e)
        {

        }

        //public void load_one_item(string p1, string p2,int i1,int i2, TextBox tb1,TextBox tb2)
        //{
        //    tb1.Text = p1;
        //    tb2.Text = p2;
        //    if (i1 != i2)
        //    {
        //        tb1.BackColor=Color.Red;
        //        tb2.BackColor = Color.Red;
        //    }
        //    else
        //    {
        //        tb1.BackColor=Color.Green;
        //        tb2.BackColor = Color.Green;
        //    }
        //}
        //public void load_one_item(string p1, string p2,  TextBox tb1, TextBox tb2)
        //{
        //    tb1.Text = p1;
        //    tb2.Text = p2;
        //    if (p1 != p2)
        //    {
        //        tb1.BackColor = Color.Red;
        //        tb2.BackColor = Color.Red;
        //    }
        //    else
        //    {
        //        tb1.BackColor = Color.Green;
        //        tb2.BackColor = Color.Green;
        //    }
        //}
        //public void load_one_item(string p1, string p2, int i1, int i2, ComboBox cmb1, TextBox tb2)
        //{
        //    cmb1.SelectedItem = p1;
        //    tb2.Text = p2;
        //    if (i1 != i2)
        //    {
        //        cmb1.BackColor = Color.Red;
        //        tb2.BackColor = Color.Red;
        //    }
        //    else
        //    {
        //        cmb1.BackColor = Color.Green;
        //        tb2.BackColor = Color.Green;
        //    }
        //}

       

        public void load_base_el()
        {
            ser1.Text = pr.base_el.Serial;
            ser21.Text = pr.base_el.Serial2;
            mark1.SelectedItem = pr.base_el.Mark;
            type1.SelectedItem = pr.base_el.Type;
            place1.SelectedItem = pr.base_el.Place;
            place21.SelectedItem = pr.base_el.Place2;
            status1.SelectedItem = pr.base_el.Status;
            //status2
            os1.SelectedItem = pr.base_el.OS;
            owner1.SelectedItem = pr.base_el.Owner;

             date1.Value = Convert.ToDateTime(pr.base_el.date); 
            

            date1.Value = Convert.ToDateTime(pr.base_el.date);
            prise1.Text = pr.base_el.Prise;

            t1.Text = pr.base_el.Text;
            t2.Text = pr.base_el.Text2;
            t3.Text = pr.base_el.Text3;
            t4.Text = pr.base_el.Text4;
            t5.Text = pr.base_el.Text5;
            t6.Text = pr.base_el.Text6;
        }

        public void load_xls_el()
        {
            ser2.Text = pr.xls_el.Serial;
            ser22.Text = pr.xls_el.Serial2;
            mark2.Text = pr.xls_el.Mark;
           
            place2.Text = pr.xls_el.Place;
           
            status2.Text = pr.xls_el.Status;
            //status2
            os2.Text = pr.xls_el.OS;
            
            
            date2.Text = pr.xls_el.date.ToString();
            prise2.Text = pr.xls_el.Prise;
            
        }

        public void compare()
        {
            if (pr.base_el.Serial != pr.xls_el.Serial)
            {
                paint_pair(ser1,ser2,Color.Red);
            }

            if (pr.base_el.Serial2 != pr.xls_el.Serial2)
            {
                paint_pair(ser21, ser22, Color.Red);
            }

            

            if (pr.base_el.Markid != pr.xls_el.Markid)
            {
                paint_pair(mark1, mark2, Color.Red);
            }

            if (pr.base_el.Statusid != pr.xls_el.Statusid)
            {
                paint_pair(status1, status2, Color.Red);
            }

            if (pr.base_el.Placeid != pr.xls_el.Placeid)
            {
                paint_pair(place1, place2, Color.Red);
            }

           

            if (pr.base_el.OSID != pr.xls_el.OSID)
            {
                paint_pair(os1, os2, Color.Red);
            }

           // and so on
        }

        public void paint_pair(Control c1,Control c2,Color cl)
        {
            c1.BackColor = cl;
            c2.BackColor = cl;
        }

        public void left(TextBox tb1, TextBox tb2)
        {
            tb1.Text = tb2.Text;
        }

        public void left(ComboBox cmb1, TextBox tb2,string par,string table)
        {
           string base_par= SQL_Class.ReadValueString("select "+par+" from " + table + " where xls" + par+ " like '%" + tb2.Text.ToString() +
                                                     "%'");
            cmb1.SelectedItem = base_par;
        }
        
        //public void upload(string inter_str, ref string param, string par_name, string table,bool cmb)
        //{
        //    if (inter_str != param)
        //    {
        //        if (MessageBox.Show("Сохранить?", "Сохранить?", MessageBoxButtons.YesNo) == DialogResult.Yes)
        //        {
        //            param = inter_str;
        //            if (cmb)
        //            {
        //                int id =
        //                    SQL_Class.ReadValueInt32("select ID from " + table + " where " + par_name + "= '" + param +
        //                                             "'");
        //                SQL_Class.Execute("update itemtable set " + par_name + "=" + id + " where ID=" + pr.base_el.ID);
        //            }
        //            else
        //            {
        //                SQL_Class.Execute("update itemtable set " + par_name + "='" + param + "' where ID=" + pr.base_el.ID);
        //            }
        //            reload_base_el();
        //        }
        //    }
        //}
        public void upload(string inter_str,  int param, string par_name, string table) // for cmbox
        {
            int new_param_id =
                SQL_Class.ReadValueInt32("select ID from " + table + " where " + par_name + " ='" + inter_str + "'");
            if (new_param_id != param)
            {
                if (MessageBox.Show("Сохранить?", "Сохранить?", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    param = new_param_id;
                    SQL_Class.Execute("update itemtable set " + par_name + "=" + new_param_id + " where ID=" + pr.base_el.ID);
                    reload_base_el();
                }
            }
        }
        public void upload(string inter_str,  int param, string par_name)
        {
            if (Convert.ToInt32(inter_str) != param)
            {
                if (MessageBox.Show("Сохранить?", "Сохранить?", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    param = Convert.ToInt32(inter_str);
                    
                    
                    SQL_Class.Execute("update itemtable set " + par_name + "=" + param + " where ID=" + pr.base_el.ID);
                    reload_base_el();
                }
            }
        } // for number

        public void upload(DateTime inter_str, DateTime param, string par_name)
        {
            if (Convert.ToDateTime(inter_str) != param)
            {
                if (MessageBox.Show("Сохранить?", "Сохранить?", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    param = Convert.ToDateTime(inter_str);


                    SQL_Class.Execute("update itemtable set " + par_name + "=" + param + " where ID=" + pr.base_el.ID);
                    reload_base_el();
                }
            }
        } // for number
        public void upload(string inter_str,  string param, string par_name)
        {
            if (inter_str != param)
            {
                if (MessageBox.Show("Сохранить?", "Сохранить?", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    param = inter_str;
                    SQL_Class.Execute("update itemtable set " + par_name + "='" + param + "' where ID=" + pr.base_el.ID);
                    reload_base_el();
                }
            }
        } // for string

        public void reload_base_el()
        {
            changed = true;
            int id = pr.base_el.ID;
            Compare_Element el = FuncClass.get_Element(id);
            if (el != null)
            {
                pr.base_el = el;
                load_data_from_pair();
                
            }
        }

        private void ser1_but_Click(object sender, EventArgs e)
        {
           left(ser1,ser2);
        }

        private void ser10_up_but_Click(object sender, EventArgs e)
        {
            Logs.add_upload_log(pr.base_el.ID, "Serial", pr.base_el.Serial, ser1.Text);
            upload(ser1.Text,pr.base_el.Serial,"Serial");
            
        }

        private void ser20_but_Click(object sender, EventArgs e)
        {
            left(ser21,ser22);
        }

        private void ser20_up_but_Click(object sender, EventArgs e)
        {
            Logs.add_upload_log(pr.base_el.ID, "Serial2", pr.base_el.Serial2, ser21.Text);
            upload(ser21.Text,  pr.base_el.Serial2, "Serial2");
            
        }

        private void mark_but_Click(object sender, EventArgs e)
        {
            left(mark1,mark2,"Mark","marktable");
        }

        private void mark_up_but_Click(object sender, EventArgs e)
        {
            Logs.add_upload_log(pr.base_el.ID, "Mark", "marktable", pr.base_el.Markid, mark1.SelectedItem.ToString());
            upload(mark1.SelectedItem.ToString(), pr.base_el.Markid,"Mark","marktable");
           
        }

      

        private void type_up_but_Click(object sender, EventArgs e)
        {
            Logs.add_upload_log(pr.base_el.ID, "Type", "typetable", pr.base_el.Typeid, type1.SelectedItem.ToString());
            upload(type1.SelectedItem.ToString(),pr.base_el.Typeid,"Type","typetable");
            
        }

        private void place_but_Click(object sender, EventArgs e)
        {
            left(place1,place2,"Place","placetable");
        }

        private void place_up_but_Click(object sender, EventArgs e)
        {
            upload(place1.SelectedItem.ToString(),pr.base_el.Placeid,"Place","placetable");
            Logs.add_upload_log(pr.base_el.ID, "Place", "placetable", pr.base_el.Placeid, place1.SelectedItem.ToString());
        }


        private void place20_up_but_Click(object sender, EventArgs e)
        {
            upload(place21.SelectedItem.ToString(),pr.base_el.Place2id,"Place2","place2table");
            Logs.add_upload_log(pr.base_el.ID, "Place2", "place2table", pr.base_el.Place2id, place21.SelectedItem.ToString());
        }

        private void status_but_Click(object sender, EventArgs e)
        {
            left(status1,status2,"Status","statustable");
        }

        private void status_up_but_Click(object sender, EventArgs e)
        {
            upload(status1.SelectedItem.ToString(),pr.base_el.Statusid,"Status","statustable");
            Logs.add_upload_log(pr.base_el.ID, "Status", "statustable", pr.base_el.Statusid, status1.SelectedItem.ToString());
        }

        private void os_but_Click(object sender, EventArgs e)
        {
            left(os1,os2,"OS","ostable");
        }

        private void os_up_but_Click(object sender, EventArgs e)
        {
            upload(os1.SelectedItem.ToString(),pr.base_el.OSID,"OS","ostable");
            Logs.add_upload_log(pr.base_el.ID, "OS", "ostable", pr.base_el.OSID, os1.SelectedItem.ToString());
        }

        private void date_but_Click(object sender, EventArgs e)
        {
            try
            {
                date1.Value = Convert.ToDateTime(date2.Text);
            }
            catch (Exception)
            {
                
            }
            
        }

        private void date_up_but_Click(object sender, EventArgs e)
        {
            upload(date1.Value,pr.base_el.date,"Date");
            Logs.add_upload_log(pr.base_el.ID, "Date", pr.base_el.date.ToString(), date1.Value.ToString());
        }

        private void prise_but_Click(object sender, EventArgs e)
        {
            left(prise1,prise2);
        }

        private void prise_Click(object sender, EventArgs e)
        {
            upload(prise1.Text,pr.base_el.Prise,"Prise");
            Logs.add_upload_log(pr.base_el.ID, "Prise", pr.base_el.Prise, prise1.Text);
        }

        private void text1_but_Click(object sender, EventArgs e)
        {
            upload(t1.Text,pr.base_el.Text,"Text");
            Logs.add_upload_log(pr.base_el.ID, "Text", pr.base_el.Text, t1.Text);
        }

        private void text2_but_Click(object sender, EventArgs e)
        {
            upload(t2.Text, pr.base_el.Text2, "Text2");
            Logs.add_upload_log(pr.base_el.ID, "Text2", pr.base_el.Text2, t2.Text);
        }

        private void text3_but_Click(object sender, EventArgs e)
        {
            upload(t3.Text, pr.base_el.Text3, "Text3");
            Logs.add_upload_log(pr.base_el.ID, "Text3", pr.base_el.Text3, t3.Text);
        }

        private void text4_but_Click(object sender, EventArgs e)
        {
            upload(t4.Text, pr.base_el.Text4, "Text4");
            Logs.add_upload_log(pr.base_el.ID, "Text4", pr.base_el.Text4, t4.Text);
        }

        private void text5_but_Click(object sender, EventArgs e)
        {
            upload(t5.Text, pr.base_el.Text5, "Text5");
            Logs.add_upload_log(pr.base_el.ID, "Text5", pr.base_el.Text5, t5.Text);
        }

        private void text6_but_Click(object sender, EventArgs e)
        {
            upload(t6.Text, pr.base_el.Text6, "Text6");
            Logs.add_upload_log(pr.base_el.ID, "Text6", pr.base_el.Text6, t6.Text);
        }

        private void Add_But_Click(object sender, EventArgs e)
        {
            Compare_Element el=new Compare_Element();
            el.Serial = ser1.Text;
            el.Serial2 = ser21.Text;

            el.Text = t1.Text;
            el.Text2 = t2.Text;
            el.Text3 = t3.Text;
            el.Text4 = t4.Text;
            el.Text5 = t5.Text;
            el.Text6 = t6.Text;

            el.Prise = prise1.Text;
            el.date = date1.Value;
            el.Status2id = SQL_Class.ReadValueInt32("select ID from status2table where Status2 ='" + status21.SelectedItem + "'");
            el.Typeid = SQL_Class.ReadValueInt32("select ID from typetable where Type ='" + type1.SelectedItem + "'");
            el.Markid = SQL_Class.ReadValueInt32("select ID from marktable where Mark ='" + mark1.SelectedItem + "'");
            el.Statusid =
                SQL_Class.ReadValueInt32("select ID from statustable where  Status ='" + status1.SelectedItem + "'");
            el.Placeid = SQL_Class.ReadValueInt32("select ID from placetable where Place ='" + place1.SelectedItem + "'");
            el.Place2id =
                SQL_Class.ReadValueInt32("select ID from place2table where PLace2  ='" + place21.SelectedItem + "'");
            el.OSID = SQL_Class.ReadValueInt32("select ID from ostable where  OS ='" + os1.SelectedItem + "'");
            el.OwnerID = SQL_Class.ReadValueInt32("select ID from ownertable where Owner ='" + owner1.SelectedItem + "'");

            if (FuncClass.add_Element(el))
            {
              Close();
            }
            else
            {
                MessageBox.Show("Элемент не добавлен");
            }
        }

        private void status21_but_Click(object sender, EventArgs e)
        {
            upload(status21.SelectedItem.ToString(), pr.base_el.Status2id, "Status2", "status2table");
            Logs.add_upload_log(pr.base_el.ID, "Status2", "status2table", pr.base_el.Status2id, status21.SelectedItem.ToString());
        }
    }
}
