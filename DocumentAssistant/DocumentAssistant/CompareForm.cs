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

namespace DocumentAssistant
{
    public partial class CompareForm : Form
    {
        Compare_Pare_Mas mas;
        XLS_Class mcl;
        public CompareForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            request_mas_of_base_elements();
            int start = Convert.ToInt32(start_Tbox.Text);
            int stop = Convert.ToInt32(stop_Tbox.Text);
            List<int> del_index=new List<int>();
            for (int i = start ; i < stop ; i++)
            {
                Compare_Element el = Compare_Element.get_el_as_xls_el_for_cmp(mcl, i).CloneElement();
                string serial2 = el.Serial2;
                int index = mas.Serial2_base.IndexOf(serial2);
                if (index != -1)
                {
                    Compare_Pare pr = mas.pre_mas[index].CloneComparePare();
                    pr.xls_el = el.CloneElement();
                    pr.check_equalence(Serial1_cm.Checked,Serial2_cm.Checked,Place_cm.Checked,Mark_cm.Checked,Date_cm.Checked,Prise_cm.Checked);
                    mas.dual_mas.Add(pr.CloneComparePare());



                    del_index.Add(index);
                }
                else
                {
                    Compare_Pare pr =new Compare_Pare();
                    pr.xls_el = el.CloneElement();
                    pr.check_equalence(Serial1_cm.Checked, Serial2_cm.Checked, Place_cm.Checked, Mark_cm.Checked, Date_cm.Checked, Prise_cm.Checked);
                    mas.xls_only_mas.Add(pr.CloneComparePare());
                }
            }
            for (int i = 0; i < mas.pre_mas.Count; i++)
            {
                if (!del_index.Contains(i))
                {
                    mas.pre_mas[i].check_equalence(Serial1_cm.Checked, Serial2_cm.Checked, Place_cm.Checked, Mark_cm.Checked, Date_cm.Checked, Prise_cm.Checked);
                    mas.base_only_mas.Add(mas.pre_mas[i]);
                }
            }

            mas.all_mas=new List<Compare_Pare>();
            mas.all_mas.AddRange(mas.dual_mas);
            mas.all_mas.AddRange(mas.xls_only_mas);
            mas.all_mas.AddRange(mas.base_only_mas);


            base_and_xls_dgv.Rows.Clear();
            base_only_dgv.Rows.Clear();
            xls_only_dgv.Rows.Clear();
            
            fill_dgv_with_list(mas.dual_mas,false,base_and_xls_dgv);
            fill_dgv_with_list(mas.xls_only_mas, true, xls_only_dgv);
            fill_dgv_with_list(mas.base_only_mas, false, base_only_dgv);

           
            all_lab.Text += " " + (mas.base_only_mas.Count + mas.dual_mas.Count + mas.xls_only_mas.Count);
            full_lab.Text += " " + mas.dual_mas.Count;
            base_lab.Text += " " + mas.base_only_mas.Count;
            xls_lab.Text += " " + mas.xls_only_mas.Count;
        }

        public void fill_dgv_with_list(List<Compare_Pare> ms, bool xls, DataGridView dgv)
        {
            dgv.RowCount = ms.Count;
            for (int i = 0; i < dgv.RowCount; i++)
            {
                if (xls)
                {
                    dgv.Rows[i].Cells[0].Value = ms[i].xls_el.Serial2;
                }
                else
                {
                    dgv.Rows[i].Cells[0].Value = ms[i].base_el.Serial2;
                }

                if (ms[i].full_pair)
                {
                    if (ms[i].equal)
                    {
                        dgv.Rows[i].Cells[0].Style.BackColor=Color.Green;
                    }
                    else
                    {
                        dgv.Rows[i].Cells[0].Style.BackColor = Color.OrangeRed;
                    }
                }

            }
        }

        private void CompareForm_Load(object sender, EventArgs e)
        {
           
            Owner_CmBox.DataSource = SQL_Class.get_data_Source("select Owner from ownertable");
            OS_CmBox.DataSource = SQL_Class.get_data_Source("select OS from ostable");
        }

        private void get_File_Click(object sender, EventArgs e)
        {
            XLS_Class cl = XLS_Class.get_xls();
            if (cl != null)
            {
                get_File.BackColor = Color.Green;
                mcl = cl;
            }
        }

        private void base_and_xls_dgv_DoubleClick(object sender, EventArgs e)
        {
            
        }

        private void base_and_xls_dgv_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                Compare_Pare pr = mas.dual_mas[e.RowIndex];

                new ElementWorkForm(pr).Show();
            }
        }

        private void base_only_dgv_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                new ElementWorkForm(mas.base_only_mas[e.RowIndex]).Show();
            }
        }

        private void xls_only_dgv_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                new ElementWorkForm(mas.xls_only_mas[e.RowIndex]).Show();
            }
        }


        public void request_mas_of_base_elements()
        {
            mas = Compare_Pare_Mas.get_base_elements(SQL_Class.ReadValueInt32("select ID from ownertable where Owner='" + Owner_CmBox.SelectedItem.ToString() + "'"), SQL_Class.ReadValueInt32("select ID from ostable where OS='" + OS_CmBox.SelectedItem.ToString() + "'"));
        }

        private void Owner_CmBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Owner_CmBox.DataSource != null)
            {
                if (SQL_Class.get_data_Source("select Owner from ownertable").Contains(Owner_CmBox.SelectedItem.ToString()))
                {
                    request_mas_of_base_elements();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //string lines = "First line.\r\nSecond line.\r\nThird line.";
            //string lines = "Not Found.\r\n";
            //foreach (Compare_Pare var in mas.xls_only_mas)
            //{
            //    lines += var.xls_el.Serial2 + "\r\n";
            //}



            //// Write the string to a file.
            //if (Directory.Exists("D:\\DocumentAssistant"))
            //{
            //    if (File.Exists("D:\\DocumentAssistant\\NOT__FOUND.txt"))
            //        File.Delete("D:\\DocumentAssistant\\NOT__FOUND.txt");
            //    StreamWriter file = new System.IO.StreamWriter("D:\\DocumentAssistant\\NOT__FOUND.txt");
            //    file.WriteLine(lines);

            //    file.Close();
            //}
            //else
            //{
            //    Directory.CreateDirectory("D:\\DocumentAssistant");
            //    StreamWriter file = new System.IO.StreamWriter("D:\\DocumentAssistant\\NOT__FOUND.txt");
            //    file.WriteLine(lines);

            //    file.Close();
            //}
        }

        private void Check_Start_Stop_Mark_Click(object sender, EventArgs e)
        {
            start_Tbox.Text = "";
            stop_Tbox.Text = "";
            
            for (int i = 1; i < 9000; i++)
            {

                string str = mcl.read_val(i, 1).ToString();

                if (str == "#start")
                {
                    start_Tbox.Text = (i + 1).ToString();
                }

                if (str == "#stop")
                {
                    stop_Tbox.Text = (i).ToString(); break;
                }
            }

            if (start_Tbox.Text == "")
            {
                MessageBox.Show("No Start Mark Found!!");
            }
            else
            {
                if (stop_Tbox.Text == "")
                {
                    MessageBox.Show("No Stop Mark Found!!");
                }
                else
                {
                    MessageBox.Show("OK!!");
                }
            }

        }

        public void start_CheckForm()
        {
            CheckType.Start_Check_Form(mcl.Path);
        }

        private void AutoCheck_But_Click(object sender, EventArgs e)
        {
            bool ok = true;
            if (FuncClass.Check_Both(mcl, Convert.ToInt32(start_Tbox.Text), Convert.ToInt32(stop_Tbox.Text),Properties.Settings.Default.xls_Mark, "marktable", "Mark"))
            {
                
            }
            else
            {
                ok = false;
            }

            if (FuncClass.Check_Both(mcl, Convert.ToInt32(start_Tbox.Text), Convert.ToInt32(stop_Tbox.Text), Properties.Settings.Default.xls_Status, "statustable", "Status"))
            {
                
            }
            else
            {
                ok = false;
            }

            if (FuncClass.Check_Both(mcl, Convert.ToInt32(start_Tbox.Text), Convert.ToInt32(stop_Tbox.Text), Properties.Settings.Default.xls_Place, "placetable", "Place"))
            {
               
            }
            else
            {
                ok = false;
            }

            if (FuncClass.Check_Both(mcl, Convert.ToInt32(start_Tbox.Text), Convert.ToInt32(stop_Tbox.Text),
                Properties.Settings.Default.xls_Type, "typetable", "Type"))
            {
               
            }
            else
            {
                ok = false;
            }

            if (FuncClass.Check_Both(mcl, Convert.ToInt32(start_Tbox.Text), Convert.ToInt32(stop_Tbox.Text),
                DocumentAssistant.Properties.Settings.Default.xls_OS, "ostable", "OS"))
            {
               
            }
            else
            {
                ok = false;
            }


            if (FuncClass.Check_Both(mcl, Convert.ToInt32(start_Tbox.Text), Convert.ToInt32(stop_Tbox.Text),
               Properties.Settings.Default.xls_Owner, "ownertable", "Owner"))
            {
               
            }
            else
            {
                ok = false;
            }


            if (FuncClass.Check_Both(mcl, Convert.ToInt32(start_Tbox.Text), Convert.ToInt32(stop_Tbox.Text),
              Properties.Settings.Default.xls_Place2, "place2table", "Place2"))
            {
               
            }
            else
            {
                ok = false;
            }


            if(!ok) start_CheckForm();
        }

        private void ExcelBut_Click(object sender, EventArgs e)
        {
            FuncClass.check_excel(ExcelBut);
        }

        private void OS_CmBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (OS_CmBox.DataSource != null)
            {
                if (SQL_Class.get_data_Source("select OS from ostable").Contains(OS_CmBox.SelectedItem.ToString()))
                {
                    request_mas_of_base_elements();
                }
            }
        }
    }
    }

