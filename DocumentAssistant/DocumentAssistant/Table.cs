using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace DocumentAssistant
{
    public class Table
    {
        public Table(List<Element> elList,DataGridView DGV,string tab_name)
        {
            el_list = elList;
            dgv = DGV;
            Table_Name = tab_name;
            Inner_Part = "";
            foreach (Element tmp in elList)
            {
                if (tmp.cmbox&&(!Inner_Part.Contains(tmp.addtable))) Inner_Part+= " left join " + tmp.addtable + " on " + Table_Name + "." + tmp.name + "=" +
                 tmp.addtable + "." + "ID ";
            }
        }

        public List<Element> el_list;
        public DataGridView dgv;
        public string Table_Name;
        public string Inner_Part;


        public string make_Read_Queue_For_DGV()
        {
            string zap = "Select ";
           
            for (int i = 0; i < el_list.Count; i++)
            {
                if (i != 0) zap += ", ";
                if (el_list[i].cmbox)
                {
                    zap += el_list[i].addtable + ".";
                   
                }
                else
                {
                    zap += Table_Name + ".";
                }
                zap += el_list[i].name + " ";
            }
            zap += "from " + Table_Name + " ";
            zap += Inner_Part;
            return zap;
        }
        public string make_Read_Queue_For_DGV(string where)
        {
            string zap = "Select ";

            for (int i = 0; i < el_list.Count; i++)
            {
                if (i != 0) zap += ", ";
                if (el_list[i].cmbox)
                {
                    zap += el_list[i].addtable + ".";

                }
                else
                {
                    zap += Table_Name + ".";
                }
                zap += el_list[i].name + " ";
            }
            zap += "from " + Table_Name + "  ";
            zap += Inner_Part + " where " + where;
            return zap;
        }

        public string make_Read_Queue_For_Edit_Form()
        {
            string zap = "Select ";

            for (int i = 0; i < el_list.Count; i++)
            {
                if (i != 0) zap += ", ";
                zap += Table_Name + ".";
                
                zap += el_list[i].name + " ";
            }
            zap += "from " + Table_Name + " ";
            zap += Inner_Part;
            return zap;
        }
        public string make_Read_Queue_For_Edit_Form(string where)
        {
            string zap = "Select ";

            for (int i = 0; i < el_list.Count; i++)
            {
                if (i != 0) zap += ", ";
                zap += Table_Name + ".";
                zap += el_list[i].name + " "; ;
            }
            zap += "from " + Table_Name  + "  ";
            zap += Inner_Part + " where " + where;
            return zap;
        }

        public string make_Insert_Queue(List<string> parameters)
        {
            string zap = "insert into " + Table_Name + " (";

            for (int i = 1; i < el_list.Count; i++)
            {
                if (i != 1) zap += ", ";
                zap += Table_Name + ".";
                zap += el_list[i].name + " "; ;
            }
            zap += ") values (";
            for (int i = 1; i < el_list.Count; i++)
            {
                if (i != 1) zap += ", ";
                if (el_list[i].cons) zap += "'";
                zap += parameters[i];
                if (el_list[i].cons) zap += "'";
            }
            zap += ")";
            return zap;
        }
        public string make_Update_Queue(List<string> parameters,int id)
        {
            string zap = "update " + Table_Name + " set ";

            for (int i = 0; i < el_list.Count; i++)
            {
                if (i != 0) zap += ", ";
                zap += Table_Name + ".";
                zap += el_list[i].name + " =";
                if (el_list[i].cons) zap += "'";
                zap += parameters[i];
                if (el_list[i].cons) zap += "'";
            }
            zap += " where ID="+id;
     
            return zap;
        }
        public string make_Delete_Queue(int id)
        {
            string zap = "delete * from "+Table_Name+" where ID="+id;
            return zap;
        }
        public void LoadData()
        {
            SQL_Class cl=new SQL_Class();
            MySqlCommand sqlCom = new MySqlCommand(make_Read_Queue_For_DGV().Replace("inner","left"), SQL_Class.SQL_Connection);
            sqlCom.ExecuteNonQuery();
            MySqlDataAdapter dataAdapter = new MySqlDataAdapter(sqlCom);
            DataTable dt = new DataTable();
            dataAdapter.Fill(dt);
            dgv.DataSource = dt;
            dgv.Refresh();
            
        }
    }

    public class FormBuilder
    {
        const int fill_width=200;
        const int label_width = 70;
        Table tbl;
        RedForm frm;
        List<object> fill_elements;
        List<object> label_elements;
        public FormBuilder(Table inp,Point pnt,int id)
        {
            int q = 0, w = 0;
            tbl = inp;
            frm = new RedForm(id,this);
            fill_elements =new List<object>(tbl.el_list.Count);
            label_elements = new List<object>(tbl.el_list.Count);
            for (int i = 0; i < tbl.el_list.Count; i++)
            {
                label_elements.Add( new TextBox());
                ((TextBox)label_elements[i]).Parent = frm;
                ((TextBox)label_elements[i]).Width = label_width;
                ((TextBox)label_elements[i]).Text = tbl.el_list[i].name;
                ((TextBox)label_elements[i]).Location = new Point(pnt.X,pnt.Y+w);


                if (!tbl.el_list[i].cmbox)
                {
                    fill_elements.Add(new TextBox());
                    ((TextBox)fill_elements[i]).Parent = frm;
                    ((TextBox)fill_elements[i]).Width = fill_width;
                    ((TextBox) fill_elements[i]).Text = "";
                    ((TextBox)fill_elements[i]).Location = new Point(pnt.X + ((TextBox)label_elements[i]).Width+5, pnt.Y + w);
                }
                else
                {
                    fill_elements.Add(new ComboBox());
                    ((ComboBox)fill_elements[i]).Parent = frm;
                    ((ComboBox)fill_elements[i]).Width = fill_width;
                    ((ComboBox)fill_elements[i]).Text = "";
                    ((ComboBox)fill_elements[i]).Location = new Point(pnt.X + ((TextBox)label_elements[i]).Width + 5, pnt.Y + w);
                    fill_elements[i] = FuncClass.PrepareComboBox(((ComboBox) fill_elements[i]), tbl.el_list[i],
                        tbl.Table_Name);
                }
                w += ((TextBox)label_elements[i]).Height + 3;
            }
            frm.Height = pnt.Y + w +100;
        }

        public static void Prepare_Form_To_Add(Table inp, Point pnt)
        {
            FormBuilder bld = new FormBuilder(inp, pnt,0);
           
            bld.frm.Add_But.Visible = true;
            bld.frm.Show();
        }

        public List<string> agregate_parameters()
        {
            List<string> lst = new List<string>();
            for (int i = 0; i < fill_elements.Count; i++)
            {
                if (!tbl.el_list[i].cmbox)
                {

                    lst.Add(((TextBox) fill_elements[i]).Text);
                }
                else
                {

                    lst.Add(((ComboBox) fill_elements[i]).SelectedIndex.ToString());

                }
            }
            return lst;
        }

        public void Add_To_Base()
        {
            SQL_Class.Execute(tbl.make_Insert_Queue(agregate_parameters()));
            frm.Close();
        }
        public void Save_To_Base()
        {
            SQL_Class.Execute(tbl.make_Update_Queue(agregate_parameters(),frm.ID));
            frm.Close();
        }
        public void Delete_To_Base()
        {
            SQL_Class.Execute(tbl.make_Delete_Queue(frm.ID));
            frm.Close();
        }
        public static void Prepare_Form_To_Edit(Table inp, Point pnt,int id)
        {
            FormBuilder bld = new FormBuilder(inp,pnt,id);
            bld.Load_Element(id);
            bld.frm.Save_But.Visible = true;
            bld.frm.Delete_But.Visible = true;
            bld.frm.Show();
        }
        public void Load_Element(int id)
        {
            string zap = tbl.make_Read_Queue_For_Edit_Form(tbl.Table_Name+".ID=" + id);
            SQL_Class cl=new SQL_Class();
            cl.ReadValues(zap);
            cl.SQL_DataReader.Read();
            for (int i = 0; i < tbl.el_list.Count; i++)
            {
                if (tbl.el_list[i].cmbox)
                {
                    int index = cl.get_int(i);
                    ((ComboBox) fill_elements[i]).SelectedIndex = index;
                }
                else
                {
                    
                    ((TextBox)fill_elements[i]).Text = cl.get_string(i);
                }
            }
            cl.Manualy_Close_Connection2();
        }
    }
}
