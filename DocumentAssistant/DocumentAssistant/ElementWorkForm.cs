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
          
        }
        public ElementWorkForm()
        {
            InitializeComponent();
            prepare_CmBox();
            pr = new Compare_Pare();
            pr.base_el = null;
            pr.xls_el = null;
            pr.full_pair = false;
           
        }

        public void prepare_CmBox()
        {
            mark1.DataSource = SQL_Class.get_data_Source("select Mark from marktable");
            type1.DataSource= SQL_Class.get_data_Source("select Type from typetable");
            place1.DataSource = SQL_Class.get_data_Source("select Place from placetable");
            place21.DataSource = SQL_Class.get_data_Source("select Place2 from place2table");
            status1.DataSource = SQL_Class.get_data_Source("select Status from statustable");
            os1.DataSource = SQL_Class.get_data_Source("select OS from ostable");
        }

        private void ComparePareForm_Load(object sender, EventArgs e)
        {

        }

        public void load_one_item(string p1, string p2,int i1,int i2, TextBox tb1,TextBox tb2)
        {
            tb1.Text = p1;
            tb2.Text = p2;
            if (i1 != i2)
            {
                tb1.BackColor=Color.Red;
                tb2.BackColor = Color.Red;
            }
            else
            {
                tb1.BackColor=Color.Green;
                tb2.BackColor = Color.Green;
            }
        }
        public void load_one_item(string p1, string p2,  TextBox tb1, TextBox tb2)
        {
            tb1.Text = p1;
            tb2.Text = p2;
            if (p1 != p2)
            {
                tb1.BackColor = Color.Red;
                tb2.BackColor = Color.Red;
            }
            else
            {
                tb1.BackColor = Color.Green;
                tb2.BackColor = Color.Green;
            }
        }
        public void load_one_item(string p1, string p2, int i1, int i2, ComboBox cmb1, TextBox tb2)
        {
            cmb1.SelectedItem = p1;
            tb2.Text = p2;
            if (i1 != i2)
            {
                cmb1.BackColor = Color.Red;
                tb2.BackColor = Color.Red;
            }
            else
            {
                cmb1.BackColor = Color.Green;
                tb2.BackColor = Color.Green;
            }
        }

       

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
            ser1.Text = pr.xls_el.Serial;
            ser21.Text = pr.xls_el.Serial2;
            mark2.Text = pr.xls_el.Mark;
            type2.Text = pr.xls_el.Type;
            place2.Text = pr.xls_el.Place;
            place22.Text = pr.xls_el.Place2;
            status2.Text = pr.xls_el.Status;
            //status2
            os2.Text = pr.xls_el.OS;
            

            date2.Text = Convert.ToDateTime(pr.xls_el.date).ToString();
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

            if (pr.base_el.Typeid != pr.xls_el.Typeid)
            {
                paint_pair(type1, type2, Color.Red);
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

            if (pr.base_el.Place2id != pr.xls_el.Place2id)
            {
                paint_pair(place21, place22, Color.Red);
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
           string base_par= SQL_Class.ReadValueString("select ID from " + table + " where xls_" + par+ "= '" + tb2.ToString() +
                                                     "'");
            cmb1.SelectedItem = base_par;
        }
        
        public void upload(string inter_str, ref string param, string par_name, string table,bool cmb)
        {
            if (inter_str != param)
            {
                if (MessageBox.Show("Сохранить?", "Сохранить?", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    param = inter_str;
                    if (cmb)
                    {
                        int id =
                            SQL_Class.ReadValueInt32("select ID from " + table + " where " + par_name + "= '" + param +
                                                     "'");
                        SQL_Class.Execute("update itemtable set " + par_name + "=" + id + " where ID=" + pr.base_el.ID);
                    }
                    else
                    {
                        SQL_Class.Execute("update itemtable set " + par_name + "='" + param + "' where ID=" + pr.base_el.ID);
                    }
                }
            }
        }

        public void upload(string inter_str, ref int param, string par_name, string table)
        {
            if (Convert.ToInt32(inter_str) != param)
            {
                if (MessageBox.Show("Сохранить?", "Сохранить?", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    param = Convert.ToInt32(inter_str);
                    
                    {
                        SQL_Class.Execute("update itemtable set " + par_name + "=" + param + " where ID=" + pr.base_el.ID);
                    }
                }
            }
        }

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
           
        }
    }
}
